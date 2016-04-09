using System;

using Xamarin.Forms;

namespace Style
{
	public class ImplicitStyleCSharp : ContentPage
	{
		public ImplicitStyleCSharp ()
		{
			var entryStyle = new Xamarin.Forms.Style (typeof (Entry)) {
				Setters = {
					new Setter { Property = Entry.TextColorProperty, Value = Color.Blue }
				}
			};

			Resources = new ResourceDictionary ();
			Resources.Add (entryStyle);
			Content = new StackLayout {
				Children = {
					new Entry { Text = "These entries" },
					new Entry { Text = "are demostrating" },
					new Entry { Text = "implicit styles," },
					new Entry { Text = "and an implicit style override" , BackgroundColor= Color.Lime },
				}
			};
		}
	}
}


