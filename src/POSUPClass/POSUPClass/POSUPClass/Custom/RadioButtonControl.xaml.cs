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

        public String Text { get; private set; }

        public String Group { get; private set; }

        public bool IsSelected { get; private set; } = false;

        public event EventHandler SelectionChanged;

        public RadioButtonControl(String Text, String Group = "", EventHandler SelectionChanged = null)
        {
            //this.imgUnse
            InitializeComponent();

            this.Text = Text;
            this.Group = Group;
            this.IsSelected = IsSelected;

            this.lblLabel.Text = this.Text;
            this.imgUnselected.Source = ImgOff;
            this.imgSelected.Source = ImgOn;
            this.imgSelected.IsVisible = this.IsSelected;

            this.SelectionChanged = SelectionChanged;

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (object sender, EventArgs e) =>
            {
                this.imgUnselected.IsVisible = this.IsSelected;
                this.imgSelected.IsVisible = this.IsSelected = !this.IsSelected;

                SelectionChanged?.Invoke(this, null);
            };
            grid.GestureRecognizers.Add(tap);
        }
    }
}