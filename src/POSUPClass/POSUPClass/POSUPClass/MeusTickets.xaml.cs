using POSUPClass.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeusTickets : ContentPage
    {
        public MeusTickets()
        {
            InitializeComponent();
            ticketsListView.ItemsSource = new List<Ticket>
            {
                new Ticket
                {
                    Descricao = "Consetar botão"
                },
                new Ticket
                {
                    Descricao = "Página não está carregando."
                },
                new Ticket
                {
                    Descricao = "Como faço para adicionar cursos?"
                },
            };
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var page = new DetalheTicketPage();
            await Navigation.PushAsync(page);
        }
    }
}