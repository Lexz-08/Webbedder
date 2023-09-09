namespace Webbedder
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.panel_TitleBar = new System.Windows.Forms.Panel();
			this.picture_AppMin = new System.Windows.Forms.PictureBox();
			this.picture_AppClose = new System.Windows.Forms.PictureBox();
			this.textbox_WebURL = new System.Windows.Forms.TextBox();
			this.picture_TopLeft = new System.Windows.Forms.PictureBox();
			this.picture_TopRight = new System.Windows.Forms.PictureBox();
			this.picture_Top = new System.Windows.Forms.PictureBox();
			this.picture_Bottom = new System.Windows.Forms.PictureBox();
			this.picture_BottomRight = new System.Windows.Forms.PictureBox();
			this.picture_BottomLeft = new System.Windows.Forms.PictureBox();
			this.picture_Left1 = new System.Windows.Forms.PictureBox();
			this.picture_Right1 = new System.Windows.Forms.PictureBox();
			this.picture_Left2 = new System.Windows.Forms.PictureBox();
			this.picture_Right2 = new System.Windows.Forms.PictureBox();
			this.trayicon_TitleBarToggle = new System.Windows.Forms.NotifyIcon(this.components);
			this.panel_BrowserContainer = new System.Windows.Forms.Panel();
			this.button_LoadWebpage = new System.Windows.Forms.Button();
			this.panel_BrowserControls = new System.Windows.Forms.Panel();
			this.panel_TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_AppMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_AppClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_TopLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_TopRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Top)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Bottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_BottomRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_BottomLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Left1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Right1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Left2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Right2)).BeginInit();
			this.panel_BrowserControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_TitleBar
			// 
			this.panel_TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel_TitleBar.Controls.Add(this.picture_AppMin);
			this.panel_TitleBar.Controls.Add(this.picture_AppClose);
			this.panel_TitleBar.Location = new System.Drawing.Point(6, 6);
			this.panel_TitleBar.Name = "panel_TitleBar";
			this.panel_TitleBar.Size = new System.Drawing.Size(671, 32);
			this.panel_TitleBar.TabIndex = 0;
			this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			// 
			// picture_AppMin
			// 
			this.picture_AppMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_AppMin.Location = new System.Drawing.Point(625, 2);
			this.picture_AppMin.Name = "picture_AppMin";
			this.picture_AppMin.Size = new System.Drawing.Size(22, 22);
			this.picture_AppMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picture_AppMin.TabIndex = 2;
			this.picture_AppMin.TabStop = false;
			this.picture_AppMin.Click += new System.EventHandler(this.AppMin_Click);
			this.picture_AppMin.MouseEnter += new System.EventHandler(this.AppCaption_MouseEnter);
			this.picture_AppMin.MouseLeave += new System.EventHandler(this.AppCaption_MouseLeave);
			// 
			// picture_AppClose
			// 
			this.picture_AppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_AppClose.Location = new System.Drawing.Point(647, 2);
			this.picture_AppClose.Name = "picture_AppClose";
			this.picture_AppClose.Size = new System.Drawing.Size(22, 22);
			this.picture_AppClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picture_AppClose.TabIndex = 1;
			this.picture_AppClose.TabStop = false;
			this.picture_AppClose.Click += new System.EventHandler(this.AppClose_Click);
			this.picture_AppClose.MouseEnter += new System.EventHandler(this.AppCaption_MouseEnter);
			this.picture_AppClose.MouseLeave += new System.EventHandler(this.AppCaption_MouseLeave);
			// 
			// textbox_WebURL
			// 
			this.textbox_WebURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_WebURL.Location = new System.Drawing.Point(2, 2);
			this.textbox_WebURL.Name = "textbox_WebURL";
			this.textbox_WebURL.Size = new System.Drawing.Size(567, 23);
			this.textbox_WebURL.TabIndex = 0;
			// 
			// picture_TopLeft
			// 
			this.picture_TopLeft.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picture_TopLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.picture_TopLeft.Location = new System.Drawing.Point(0, 0);
			this.picture_TopLeft.Name = "picture_TopLeft";
			this.picture_TopLeft.Size = new System.Drawing.Size(6, 6);
			this.picture_TopLeft.TabIndex = 1;
			this.picture_TopLeft.TabStop = false;
			this.picture_TopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_TopRight
			// 
			this.picture_TopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_TopRight.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picture_TopRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.picture_TopRight.Location = new System.Drawing.Point(677, 0);
			this.picture_TopRight.Name = "picture_TopRight";
			this.picture_TopRight.Size = new System.Drawing.Size(6, 6);
			this.picture_TopRight.TabIndex = 2;
			this.picture_TopRight.TabStop = false;
			this.picture_TopRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Top
			// 
			this.picture_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_Top.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picture_Top.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.picture_Top.Location = new System.Drawing.Point(6, 0);
			this.picture_Top.Name = "picture_Top";
			this.picture_Top.Size = new System.Drawing.Size(671, 6);
			this.picture_Top.TabIndex = 3;
			this.picture_Top.TabStop = false;
			this.picture_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Bottom
			// 
			this.picture_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_Bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.picture_Bottom.Location = new System.Drawing.Point(6, 583);
			this.picture_Bottom.Name = "picture_Bottom";
			this.picture_Bottom.Size = new System.Drawing.Size(671, 6);
			this.picture_Bottom.TabIndex = 6;
			this.picture_Bottom.TabStop = false;
			this.picture_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_BottomRight
			// 
			this.picture_BottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_BottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.picture_BottomRight.Location = new System.Drawing.Point(677, 583);
			this.picture_BottomRight.Name = "picture_BottomRight";
			this.picture_BottomRight.Size = new System.Drawing.Size(6, 6);
			this.picture_BottomRight.TabIndex = 5;
			this.picture_BottomRight.TabStop = false;
			this.picture_BottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_BottomLeft
			// 
			this.picture_BottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picture_BottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.picture_BottomLeft.Location = new System.Drawing.Point(0, 583);
			this.picture_BottomLeft.Name = "picture_BottomLeft";
			this.picture_BottomLeft.Size = new System.Drawing.Size(6, 6);
			this.picture_BottomLeft.TabIndex = 4;
			this.picture_BottomLeft.TabStop = false;
			this.picture_BottomLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Left1
			// 
			this.picture_Left1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picture_Left1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picture_Left1.Location = new System.Drawing.Point(0, 6);
			this.picture_Left1.Name = "picture_Left1";
			this.picture_Left1.Size = new System.Drawing.Size(6, 32);
			this.picture_Left1.TabIndex = 7;
			this.picture_Left1.TabStop = false;
			this.picture_Left1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Right1
			// 
			this.picture_Right1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_Right1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.picture_Right1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picture_Right1.Location = new System.Drawing.Point(677, 6);
			this.picture_Right1.Name = "picture_Right1";
			this.picture_Right1.Size = new System.Drawing.Size(6, 32);
			this.picture_Right1.TabIndex = 8;
			this.picture_Right1.TabStop = false;
			this.picture_Right1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Left2
			// 
			this.picture_Left2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.picture_Left2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picture_Left2.Location = new System.Drawing.Point(0, 38);
			this.picture_Left2.Name = "picture_Left2";
			this.picture_Left2.Size = new System.Drawing.Size(6, 545);
			this.picture_Left2.TabIndex = 9;
			this.picture_Left2.TabStop = false;
			this.picture_Left2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// picture_Right2
			// 
			this.picture_Right2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picture_Right2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picture_Right2.Location = new System.Drawing.Point(677, 38);
			this.picture_Right2.Name = "picture_Right2";
			this.picture_Right2.Size = new System.Drawing.Size(6, 545);
			this.picture_Right2.TabIndex = 10;
			this.picture_Right2.TabStop = false;
			this.picture_Right2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
			// 
			// trayicon_TitleBarToggle
			// 
			this.trayicon_TitleBarToggle.Text = "Embed Webpage";
			this.trayicon_TitleBarToggle.Visible = true;
			this.trayicon_TitleBarToggle.Click += new System.EventHandler(this.ToggleTitleBar_Click);
			// 
			// panel_BrowserContainer
			// 
			this.panel_BrowserContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_BrowserContainer.Location = new System.Drawing.Point(9, 68);
			this.panel_BrowserContainer.Name = "panel_BrowserContainer";
			this.panel_BrowserContainer.Size = new System.Drawing.Size(665, 512);
			this.panel_BrowserContainer.TabIndex = 11;
			// 
			// button_LoadWebpage
			// 
			this.button_LoadWebpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_LoadWebpage.Location = new System.Drawing.Point(575, 2);
			this.button_LoadWebpage.Name = "button_LoadWebpage";
			this.button_LoadWebpage.Size = new System.Drawing.Size(94, 23);
			this.button_LoadWebpage.TabIndex = 3;
			this.button_LoadWebpage.Text = "Load Webpage";
			this.button_LoadWebpage.UseVisualStyleBackColor = true;
			this.button_LoadWebpage.Click += new System.EventHandler(this.LoadWebpage_Click);
			// 
			// panel_BrowserControls
			// 
			this.panel_BrowserControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_BrowserControls.Controls.Add(this.button_LoadWebpage);
			this.panel_BrowserControls.Controls.Add(this.textbox_WebURL);
			this.panel_BrowserControls.Location = new System.Drawing.Point(6, 38);
			this.panel_BrowserControls.Name = "panel_BrowserControls";
			this.panel_BrowserControls.Size = new System.Drawing.Size(671, 27);
			this.panel_BrowserControls.TabIndex = 12;
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(683, 589);
			this.Controls.Add(this.panel_BrowserContainer);
			this.Controls.Add(this.picture_Right2);
			this.Controls.Add(this.picture_Left2);
			this.Controls.Add(this.picture_Right1);
			this.Controls.Add(this.picture_Left1);
			this.Controls.Add(this.picture_Bottom);
			this.Controls.Add(this.picture_BottomRight);
			this.Controls.Add(this.picture_BottomLeft);
			this.Controls.Add(this.picture_Top);
			this.Controls.Add(this.picture_TopRight);
			this.Controls.Add(this.picture_TopLeft);
			this.Controls.Add(this.panel_TitleBar);
			this.Controls.Add(this.panel_BrowserControls);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Webbedder";
			this.panel_TitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picture_AppMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_AppClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_TopLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_TopRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Top)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Bottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_BottomRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_BottomLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Left1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Right1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Left2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Right2)).EndInit();
			this.panel_BrowserControls.ResumeLayout(false);
			this.panel_BrowserControls.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_TitleBar;
		private System.Windows.Forms.PictureBox picture_TopLeft;
		private System.Windows.Forms.PictureBox picture_TopRight;
		private System.Windows.Forms.PictureBox picture_Top;
		private System.Windows.Forms.PictureBox picture_Bottom;
		private System.Windows.Forms.PictureBox picture_BottomRight;
		private System.Windows.Forms.PictureBox picture_BottomLeft;
		private System.Windows.Forms.PictureBox picture_Left1;
		private System.Windows.Forms.PictureBox picture_Right1;
		private System.Windows.Forms.PictureBox picture_Left2;
		private System.Windows.Forms.PictureBox picture_Right2;
		private System.Windows.Forms.NotifyIcon trayicon_TitleBarToggle;
		private System.Windows.Forms.TextBox textbox_WebURL;
		private System.Windows.Forms.PictureBox picture_AppMin;
		private System.Windows.Forms.PictureBox picture_AppClose;
		private System.Windows.Forms.Panel panel_BrowserContainer;
		private System.Windows.Forms.Button button_LoadWebpage;
		private System.Windows.Forms.Panel panel_BrowserControls;
	}
}

