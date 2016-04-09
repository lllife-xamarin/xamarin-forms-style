using System;

using Xamarin.Forms;

namespace Style
{
	public class NoStylePage : ContentPage
	{
		public NoStylePage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


