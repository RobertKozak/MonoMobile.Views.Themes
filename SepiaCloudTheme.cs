//
// SepiaCloudsTheme.cs:
//
// Author:
//   Robert Kozak (rkozak@gmail.com / Twitter:@robertkozak
//
// Copyright 2011, Nowcom Corporation
//
// Code licensed under the MIT X11 license
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
namespace MonoMobile.Views.Themes
{
	using System;
	using System.Drawing;
	using System.IO;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;

	[Preserve(AllMembers = true)]
	public class SepiaCloudsTheme : Theme
	{
		public SepiaCloudsTheme()
		{
			Name = "SepiaCloudsTheme";
	
			BarTintColor = UIColor.FromRGB(18, 115, 188);
			BarStyle = UIBarStyle.Default;
		
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
			{
				BackgroundUri = new Uri("file://" + Path.GetFullPath("Images/SepiaCloudsiPad.png"));
			}
			else
			{
				BackgroundUri = new Uri("file://" + Path.GetFullPath("Images/SepiaClouds.png"));
			}
			
			CellBackgroundColor = UIColor.White.ColorWithAlpha(0.4f);

			TextColor = UIColor.Black;
			TextShadowColor = UIColor.White.ColorWithAlpha(0.8f);
			TextShadowOffset = new SizeF(0, 1);
		
			PlaceholderColor = UIColor.FromWhiteAlpha(0.4f, 1.0f);
			DetailTextColor = UIColor.FromWhiteAlpha(0.1f, 0.8f);
			DetailTextAlignment = UITextAlignment.Right;
			PlaceholderAlignment = UITextAlignment.Right;
			
			HeaderTextColor = UIColor.FromRGB(37, 93, 177);
			HeaderTextShadowColor = UIColor.White.ColorWithAlpha(0.8f);
			HeaderTextShadowOffset = new SizeF(0.5f, 0.5f);
			
			FooterTextColor = UIColor.DarkGray;
			FooterTextShadowColor = UIColor.White.ColorWithAlpha(0.8f);
			FooterTextShadowOffset = new SizeF(0.5f, 0.5f);	
		}
	}
}

