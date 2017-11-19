using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass.Custom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonControl : ContentView
    {
        protected ImageSource ImgOn { get { return ImageSource.FromResource("POSUPClass.Images.RadioOn.png"); } }

        protected ImageSource ImgOff { get { return ImageSource.FromResource("POSUPClass.Images.RadioOff.png"); } }

        public String Label { get; set; }

        public bool IsSelected { get; set; }

        public RadioButtonControl(String Label, bool IsSelected = false)
        {
            //this.imgUnse
            InitializeComponent();

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (object sender, EventArgs e) =>
            {
                this.imgUnselected.IsVisible = IsSelected;
                this.imgSelected.IsVisible = IsSelected = !IsSelected;
            };
            grid.GestureRecognizers.Add(tap);
        }
    }
}