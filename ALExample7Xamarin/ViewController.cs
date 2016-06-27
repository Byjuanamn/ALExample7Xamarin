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
			NSLayoutConstraint(item: searchLabel,
                           attribute: .Baseline,
                           relatedBy: .Equal,
                           toItem: textField,
                           attribute: .Baseline,
                           multiplier: 1.0,
                           constant: 0.0)
            .active = true

			*/
			NSLayoutConstraint.Create(searchLabel,
									  NSLayoutAttribute.Baseline,
									  NSLayoutRelation.Equal,
									  textField,
									  NSLayoutAttribute.Baseline,
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

