# Webbedder
## Project Information
[![](https://img.shields.io/badge/.NET_Framework-4.8-blue)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
[![](https://img.shields.io/badge/build-passing-seagreen)](#)
[![](https://img.shields.io/badge/Target_Platforms-x86,x64-goldenrod)](https://github.com/Lexz-08/releases/latest)
[![](https://img.shields.io/badge/status-development_stopped-red)](#)

## Description
A program that displays any specified webpage using CefSharp, with some URL restrictions (HTTP, HTTPS, and DATA only).<br><br>
*Supports multiple instances because each instance runs separately, although, there is no `TOP-MOST` feature, so you will have to keep the/each window in an easily accessible area to continually use it.*

## Command-Line
Usage to Auto-Embed: `<path_to>\Webbedder.exe "<your_link>" /y`<br>
Usage to Just Open: `<path_to>\Webbedder.exe "<your_link>"`<br>
$\color{red}\text{NOTE: Attempting to use Webbedder.exe from the Start Menu will always result in it loading the default page: Google.}$

## Issues I Haven't Solved
 - Whenever you load a webpage, any special icon characters will not render until you've loaded it a second time. I've tried making a timer loop that loads the webpage a second time after about half a second, or up to two seconds, but it never seems to do anything.
 - The Windows Aero border will for some reason either be disabled in normal mode and be enabled in embed mode, or vice versa, and I can't figure out why it does that, though the size/location change seems to be affecting it.

## Download
[![](https://img.shields.io/badge/download-(x86)_Standalone-red)](https://github.com/Lexz-08/Webbedder/releases/latest/download/Webbedder-x86.zip)<br>
[![](https://img.shields.io/badge/download-(x64)_Standalone-red)](https://github.com/Lexz-08/Webbedder/releases/latest/download/Webbedder-x64.zip)<br>
[![](https://img.shields.io/badge/download-(x86)_Installer-orange)](https://github.com/Lexz-08/Webbedder/releases/latest/download/Install-Webbedder-x86.exe)<br>
[![](https://img.shields.io/badge/download-(x64)_Installer-orange)](https://github.com/Lexz-08/Webbedder/releases/latest/download/Install-Webbedder-x64.exe)
