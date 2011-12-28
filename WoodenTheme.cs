//
// WoodenTheme.cs:
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
	using MonoMobile.Views;
	using MonoTouch.Foundation;
	using MonoTouch.UIKit;

	[Preserve(AllMembers = true)]
	public class WoodenTheme: Theme
	{
		public WoodenTheme()
		{
			CellBackgroundColor = UIColor.FromWhiteAlpha(1f, 0.2f);

			TextColor = UIColor.DarkTextColor;
			TextShadowColor = UIColor.FromWhiteAlpha(0.8f, 1.0f);
			TextShadowOffset = new SizeF(0, 1);

			BackgroundUri = new Uri ("file://" + Path.GetFullPath("Images/wood.jpg"));
			SeparatorColor = UIColor.Black;
			
			TextColor = UIColor.FromWhiteAlpha(1f, 0.8f);
			TextShadowColor = UIColor.Brown.ColorWithAlpha(0.8f);
			TextShadowOffset = new SizeF(0, 1);
			
			DetailTextColor = UIColor.FromWhiteAlpha(1f, 0.8f);
			DetailTextShadowColor = UIColor.Brown.ColorWithAlpha(0.8f);
			DetailTextShadowOffset = new SizeF(0, 1);

			BarTintColor = UIColor.Brown;
			BarStyle = UIBarStyle.Default;

			HeaderTextColor = UIColor.FromRGB(92, 69, 0);
			HeaderTextShadowColor = UIColor.FromWhiteAlpha(1f, 0.6f);

			FooterTextColor = UIColor.FromWhiteAlpha(1f, 0.8f);
			FooterTextShadowColor = UIColor.FromWhiteAlpha(0f, 0.2f);
		}
	}
}
