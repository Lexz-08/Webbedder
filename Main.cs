using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using CefSharp.WinForms;

using Microsoft.Win32;

namespace Webbedder
{
	public partial class Main : Form
	{
		[StructLayout(LayoutKind.Sequential)]
		private struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		private static extern IntPtr LoadCursorFromFile(string lpFileName);

		[DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int attrSize, int attrValue);

		[DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		private ChromiumWebBrowser _wbdBrowser;

		private bool CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int enabled = 0;
				DwmIsCompositionEnabled(ref enabled);

				return enabled == 1;
			}

			return false;
		}

		public Main()
		{
			InitializeComponent();

			picture_AppClose.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Close];
			picture_AppMin.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Minimize];
			trayicon_TitleBarToggle.Icon = Icon;

			_wbdBrowser = new ChromiumWebBrowser(textbox_WebURL.Text);
			panel_BrowserContainer.Controls.Add(_wbdBrowser);

			int num = 0;
			Timer t = new Timer { Interval = 100 };
			t.Tick += (_, __) =>
			{
				if (num == 2)
					t.Dispose();
				else ToggleTitleBar_Click(_, __);

				num++;
			};
			t.Start();

			string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();
			Timer t2 = new Timer { Interval = 250 };
			t2.Tick += (_, __) =>
			{
				t2.Dispose();

				if (args.Length > 0)
				{
					if (args.Length >= 1)
					{
						textbox_WebURL.Text = args[0];
						LoadWebpage_Click(this, EventArgs.Empty);
					}

					if (args.Length == 2 && args[1].StartsWith("/"))
					{
						char arg = args[1].ToLower()[1];
						if (arg == 'y') ToggleTitleBar_Click(_, __);
						else if (arg == 'n')
						{
							_hideBorder = true;
							ToggleTitleBar_Click(_, __);
						}
						else MessageBox.Show("Unable to set embed state of webpage because invalid argument was provided.", "Invalid Embed Argument",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else MessageBox.Show("Unable to set embed state of webpage because invalid argument type was provided.", "Invalid Embed Argument Type",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			};
			t2.Start();

			if (args.Length == 0)
			{
				textbox_WebURL.Text = "https://www.google.com";
				LoadWebpage_Click(this, EventArgs.Empty);
			}
		}

		#region Program Behavior

		//

		#endregion

		#region Window Behavior

		private bool _aeroEnabled = false;
		private Size _stateChangeSize;

		private bool _hideBorder = false;

		private static readonly Dictionary<string, int> BORDER = new Dictionary<string, int>
		{
			{ "Left1",       10 },
			{ "Left2",       10 },
			{ "Right1",      11 },
			{ "Right2",      11 },
			{ "Top",         12 },
			{ "TopLeft",     13 },
			{ "TopRight",    14 },
			{ "Bottom",      15 },
			{ "BottomLeft",  16 },
			{ "BottomRight", 17 }
		};

		private Cursor HandCursor
		{
			get
			{
				string cursorPath = Registry.CurrentUser.OpenSubKey("Control Panel\\Cursors").GetValue("Hand").ToString();
				IntPtr cursorPtr = !string.IsNullOrEmpty(cursorPath) ? LoadCursorFromFile(cursorPath) : Cursors.Hand.Handle;

				GC.Collect();

				return new Cursor(cursorPtr);
			}
		}

		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private void Border_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, BORDER[((Control)sender).Name.Replace("picture_", "")], 0);
			}
		}

		private void ToggleTitleBar_Click(object sender, EventArgs e)
		{
			_hideBorder = !_hideBorder;

			if (_hideBorder)
			{
				ShowInTaskbar = false;

				Location = new Point(Location.X + 6, Location.Y + 70);
				Size = new Size(ClientSize.Width - 12, ClientSize.Height - 76);
				panel_BrowserContainer.Location = new Point(0, 0);
				panel_BrowserContainer.Size = new Size(Width, Height);
				trayicon_TitleBarToggle.Text = "Expand Border";
			}
			else
			{
				ShowInTaskbar = true;

				Location = new Point(Location.X - 6, Location.Y - 70);
				Size = new Size(ClientSize.Width + 12, ClientSize.Height + 76);
				panel_BrowserContainer.Location = new Point(6 + (sender == trayicon_TitleBarToggle ? 3 : 6), 65);
				panel_BrowserContainer.Size = new Size(Width - 12 - (sender == trayicon_TitleBarToggle ? 6 : 12), Height - 76);
				trayicon_TitleBarToggle.Text = "Embed Webpage";
			}
		}

		private void AppClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AppMin_Click(object sender, EventArgs e)
		{
			_stateChangeSize = ClientSize;
			WindowState = FormWindowState.Minimized;

			trayicon_TitleBarToggle.Visible = false;
		}

		private void LoadWebpage_Click(object sender, EventArgs e)
		{
			Uri result;
			if ((Uri.TryCreate(textbox_WebURL.Text, UriKind.Absolute, out result) &&
				(result.Scheme == Uri.UriSchemeFile || result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps)) ||
				textbox_WebURL.Text.StartsWith("data:"))
				_wbdBrowser.Load(textbox_WebURL.Text);
			else MessageBox.Show("Please enter a valid web url when attempting to embed.", "Invalid URL Provided",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void AppCaption_MouseEnter(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.Gainsboro;
			((Control)sender).Cursor = HandCursor;
		}

		private void AppCaption_MouseLeave(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.WhiteSmoke;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			_stateChangeSize = ClientSize;
			Size = new Size(ClientSize.Width - 16, ClientSize.Height - 39);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (_aeroEnabled)
			{
				int v = 2;
				DwmSetWindowAttribute(Handle, 2, ref v, 4);
				MARGINS margins = new MARGINS
				{
					leftWidth = 0,
					rightWidth = 0,
					topHeight = 1,
					bottomHeight = 0
				};
				DwmExtendFrameIntoClientArea(Handle, ref margins);
			}
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_NCCALCSIZE = 0x0083;
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MINIMIZE = 0xF020;
			const int SC_RESTORE = 0xF120;

			if (m.Msg == WM_NCCALCSIZE && (int)m.WParam == 1)
				return;

			if (m.Msg == WM_SYSCOMMAND)
			{
				int wParam = (int)m.WParam & 0xFFF0;

				if (wParam == SC_MINIMIZE) _stateChangeSize = ClientSize;
				if (wParam == SC_RESTORE)
				{
					Size = _stateChangeSize;
					trayicon_TitleBarToggle.Visible = true;
				}
			}

			base.WndProc(ref m);
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				_aeroEnabled = CheckAeroEnabled();

				if (!_aeroEnabled) cp.ClassStyle |= 0x20000;

				return cp;
			}
		}

		#endregion
	}
}
