using System;

using UIKit;

namespace ALExample7Xamarin
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.



			var searchLabel = new UILabel();
			searchLabel.TranslatesAutoresizingMaskIntoConstraints = false;
			searchLabel.Text = "Search:";
			View.AddSubview(searchLabel);

			var textField = new UITextField();
			textField.TranslatesAutoresizingMaskIntoConstraints = false;
			textField.BorderStyle = UITextBorderStyle.RoundedRect;
			View.AddSubview(textField);

			/*
				Ajustamos el leading de la etiqueta
			*/

			var contraintSearchLabelLeading = NSLayoutConstraint.Create(searchLabel,
																		NSLayoutAttribute.Leading,
																		NSLayoutRelation.Equal, 
			                                                            View,
																		NSLayoutAttribute.LeadingMargin,
																		1.0f,
																		0.0f);
			contraintSearchLabelLeading.Active = true;

			/*

				Baseline entre la etiqueta y el textfield

			*/
			NSLayoutConstraint.Create(searchLabel,
									  NSLayoutAttribute.Baseline,
									  NSLayoutRelation.Equal,
									  textField,
									  NSLayoutAttribute.Baseline,
									  1.0f,
									  0.0f).Active = true;

			/*

       			Ajustamos el textfield
			*/

			NSLayoutConstraint.Create(View,
									  NSLayoutAttribute.TrailingMargin,
									  NSLayoutRelation.Equal,
									  textField,
									  NSLayoutAttribute.Trailing,
									  1.0f,
									  0.0f).Active = true;

			NSLayoutConstraint.Create(textField,
									  NSLayoutAttribute.Top,
									  NSLayoutRelation.Equal,
									  TopLayoutGuide,
									  NSLayoutAttribute.Bottom,
									  1.0f,
									  0.0f).Active = true;


			NSLayoutConstraint.Create(textField,
									  NSLayoutAttribute.Leading,
									  NSLayoutRelation.Equal,
									  searchLabel,
									  NSLayoutAttribute.Trailing,
									  1.0f,
									  0.0f).Active = true;



		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

