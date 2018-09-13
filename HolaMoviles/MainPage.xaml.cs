using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HolaMoviles.Modelos;

namespace HolaMoviles
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<object> Items { get; set; } = new ObservableCollection<object> { 1, "2", true, false };

        public MainPage()
        {
            InitializeComponent();

            ButtonAgregar.Clicked += ButtonAgregar_Click;
        }

        private async void ButtonAgregar_Click (object sender, EventArgs arg)
        {
            IsBusy = true;

            await Task.Delay(2500);

            Items.Add($"Elemento #{Items.Count}");

            foreach (var item in CargarProductos())
            {
                Items.Add(item);
            }

            IsBusy = false;

            //await DisplayAlert("Hola Mundo", "Hola", "Cerrar");

        }

        private Producto[] CargarProductos()
        {

            return new[] {
                new Producto {Name = "Producto 1" }
            };
        }

    }                            
}
