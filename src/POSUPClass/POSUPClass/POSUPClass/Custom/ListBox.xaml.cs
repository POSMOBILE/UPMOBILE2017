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
    public partial class ListBox : ContentView
    {
        protected ImageSource ImgArrowDown { get { return ImageSource.FromResource("POSUPClass.Images.ArrowDown.png"); } }

        Dictionary<String, int> Items { get; set; }

        public String SelectedItem
        {
            get { return this.lblSelectedItem.Text; }
        }

        public ListBox(List<String> Items)
        {
            InitializeComponent();

            var pickOptions = new Picker();
            pickOptions.IsVisible = false;
            foreach (var item in Items)
            {
                pickOptions.Items.Add(item);
            }
            pickOptions.SelectedIndex = 0;
            pickOptions.SelectedIndexChanged += (snd, evt) =>
            {
                this.lblSelectedItem.Text = ((Picker)snd).SelectedItem.ToString();
            };
            this.grid.Children.Add(pickOptions);

            this.lblSelectedItem.Text = Items?.First();
            this.imgArrowDown.Source = ImgArrowDown;

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (object sender, EventArgs e) =>
            {
                pickOptions.Focus();
            };
            grid.GestureRecognizers.Add(tap);
        }

        private void PickOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}