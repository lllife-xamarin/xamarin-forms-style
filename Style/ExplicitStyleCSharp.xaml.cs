using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Style
{
	public partial class ExplicitStyleCSharp: ContentPage
	{
		public ExplicitStyleCSharp()
		{
			InitializeComponent ();
			Content = CreateContent();
		}

		private Setter CreateColorSetter(Color color)
		{
			return new Setter { Property = Label.TextColorProperty, Value = color };
		}

		private Setter CreateOptionsSetter ()
		{
			return new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand };
		}

		private View CreateContent()
		{
			var labelRedStyle = new Xamarin.Forms.Style (typeof (Label)) {
				Setters = { CreateColorSetter(Color.Red), CreateOptionsSetter() }
			};

			var labelBlueStyle = new Xamarin.Forms.Style (typeof (Label)) {
				Setters = { CreateColorSetter(Color.Blue), CreateOptionsSetter() }
			};

			var labelGreenStyle = new Xamarin.Forms.Style (typeof (Label)) {
				Setters = { CreateColorSetter (Color.Green), CreateOptionsSetter() }
			};

			var resources = new ResourceDictionary ();
			resources.Add ("labelRedStyle", labelRedStyle);
			resources.Add ("labelBlueStyle", labelBlueStyle);
			resources.Add ("labelGreenStyle", labelGreenStyle);

			var layout = new StackLayout {
				Children = {
					new Label { Text = "These labels", Style = labelRedStyle },
					new Label { Text = "are demonstrating", Style = labelGreenStyle },
					new Label { Text = "explict styles,", Style = labelBlueStyle },
					new Label { Text = "and an explict style override", Style = labelGreenStyle }
				}
			};
			layout.Resources = resources;

			return layout;
		}
	}
}

