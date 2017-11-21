using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POSUPClass
{
    public partial class PerfilProfessor : ContentPage
    {
        public PerfilProfessor()
        {
            InitializeComponent();

            Title = "Perfil Professor";

            ToolbarItems.Add(new ToolbarItem("Search", "ic_share.png", () =>
            {

            }));

            profilePic.Source = Data.ProfessorFactory.Prof.Picture;

            CursosLabel.Text = "Cursos de " + Data.ProfessorFactory.Prof.Name;

            SobreLabel.Text = Data.ProfessorFactory.Prof.Description;

            StackLayout sl = ListCursos;

            foreach (var curso in Data.ProfessorFactory.ProfCursos)
            {
                StackLayout parentContainer = new StackLayout()
                {
                    Orientation = StackOrientation.Vertical,
                    BackgroundColor = Color.White,
                    WidthRequest = 170,
                    HeightRequest = 200,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Image img = new Image()
                {
                    Source = curso.Picture,
                    HeightRequest = 80,
                    WidthRequest = 170,
                    Aspect = Aspect.AspectFill,
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Start
                };

                Label title = new Label()
                {
                    FontSize = 18,
                    TextColor = Color.Black,
                    Text = curso.Name,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(10, 0, 10, 0)
                };

                parentContainer.Children.Add(img);
                parentContainer.Children.Add(title);

                StackLayout starsContainer = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    BackgroundColor = Color.White,
                    HeightRequest = 20,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Padding = new Thickness(10, 20, 10, 10),
                    Spacing = 2
                };

                int votes = curso.Stars;
                Image imgStar;

                for (int i = 1; i < 6; i++)
                {
                    if (i <= votes)
                    {
                        imgStar = new Image()
                        {
                            Source = "yellow.png",
                            HeightRequest = 18,
                            WidthRequest = 18,
                            Aspect = Aspect.AspectFill,
                            BackgroundColor = Color.White,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                        };
                    }
                    else
                    {
                        imgStar = new Image()
                        {
                            Source = "gray.png",
                            HeightRequest = 18,
                            WidthRequest = 18,
                            Aspect = Aspect.AspectFill,
                            BackgroundColor = Color.White,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                        };
                    }

                    starsContainer.Children.Add(imgStar);
                }

                Label votesLabel = new Label()
                {
                    FontSize = 16,
                    TextColor = Color.Gray,
                    Text = "(" + curso.Votes + ")",
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(5, 0, 0, 0)
                };

                starsContainer.Children.Add(votesLabel);

                parentContainer.Children.Add(starsContainer);

                sl.Children.Add(parentContainer);
            }

            StackLayout slContatos = ListContatos;

            foreach (var contato in Data.ProfessorFactory.ProfContatos)
            {
                StackLayout parentContainer = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    BackgroundColor = Color.White,
                    HeightRequest = 70,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Padding = new Thickness(10, 0)
                };

                StackLayout imageContainer = new StackLayout()
                {
                    BackgroundColor = Color.White,
                    Spacing = 0,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(3)
                };

                Image img = new Image()
                {
                    Source = contato.Picture,
                    HeightRequest = 40,
                    WidthRequest = 40,
                    Aspect = Aspect.AspectFill,
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Start
                };

                imageContainer.Children.Add(img);
                parentContainer.Children.Add(imageContainer);

                StackLayout infoContainer = new StackLayout()
                {
                    Orientation = StackOrientation.Vertical,
                    BackgroundColor = Color.White,
                    Spacing = 0,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(5)
                };

                Label title = new Label()
                {
                    FontSize = 14,
                    TextColor = Color.Black,
                    Text = contato.Social,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    VerticalOptions = LayoutOptions.Center
                };

                Label link = new Label()
                {
                    FontSize = 12,
                    TextColor = Color.Gray,
                    Text = contato.Url,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Margin = new Thickness(0, 5, 0, 0)
                };

                infoContainer.Children.Add(title);
                infoContainer.Children.Add(link);

                parentContainer.Children.Add(infoContainer);

                slContatos.Children.Add(parentContainer);
            }
        }
    }
}
