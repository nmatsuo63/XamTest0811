using System;

using UIKit;

namespace XamAppCenterSample2018.iOS.Views
{
    public partial class MainViews : UIViewController
    {
        public MainViews() : base("MainViews", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

