using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnalisisT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbed : TabbedPage
    {
        ObservableCollection<Productos> Items = new ObservableCollection<Productos>();

        public MainTabbed()
        {
            InitializeComponent();
            Items.Add(new Productos { Nombre = "Iphone 8", Descripcion = "Iphone 8 64 GB", Precio = "699$", Email = "jesus@gmail.com", Telefono = "12345678", Imagen = "iphone_8.png" });
            Items.Add(new Productos { Nombre = "Samsung", Descripcion = "Samsung Galaxy S7 G930a", Precio = "304$", Email = "mengano@gmail.com", Telefono = "87654321", Imagen = "samsung_s7.png" });
            Items.Add(new Productos { Nombre = "Iphone X", Descripcion = "Iphone X 256 GB", Precio = "1000$", Email = "richard@gmail.com", Telefono = "12345678", Imagen = "iphone_x.png" });
            Items.Add(new Productos { Nombre = "Nokia", Descripcion = "Nokia nuevo", Precio = "20$", Email = "ricardo@gmail.com", Telefono = "13572468", Imagen = "nokia.png" });
            Items.Add(new Productos { Nombre = "Bicicleta Azul", Descripcion = "Excelente estado y poco uso", Precio = "200$", Email = "mthurn@live.com", Telefono = "202-555-0187", Imagen = "transparent_bike.png" });
            Items.Add(new Productos { Nombre = "Botas negras", Descripcion = "Nuevas, muy a la moda", Precio = "45$", Email = "fangorn@hotmail.com", Telefono = "202-555-0164", Imagen = "black_boots.png" });
            Items.Add(new Productos { Nombre = "Camara Canon", Descripcion = "Impresionante simplicidad", Precio = "300$", Email = "webdragon@comcast.net", Telefono = "546-9442", Imagen = "camara.png" });
            Items.Add(new Productos { Nombre = "Drone DJI", Descripcion = "Es un pequeño pero potente dron ", Precio = "1200$", Email = "guyer@aol.com", Telefono = "446-8851", Imagen = "drone.png" });
            Items.Add(new Productos { Nombre = "iPad", Descripcion = "Respaldo y Garantia", Precio = "600$", Email = "sakusha@yahoo.ca", Telefono = "546-4478", Imagen = "ipad.png" });
            Items.Add(new Productos { Nombre = "Lentes Oakley", Descripcion = "Este modelo llama la atencion", Precio = "300$", Email = "crandall@sbcglobal.net", Telefono = "906-2721", Imagen = "lentes.png" });
            Items.Add(new Productos { Nombre = "Silla", Descripcion = "Tela en color negro de alta resistencia", Precio = "80$", Email = "firstpr@att.net", Telefono = "202-555-0161", Imagen = "silla.png" });
            Items.Add(new Productos { Nombre = "Smart tv", Descripcion = "Velocidad de actualización mejorada 120 Hz", Precio = "800$", Email = "jguyer@aol.com", Telefono = "446-8851", Imagen = "smart_tv.png" });
            MyListView.ItemsSource = Items;
            MyListView.ItemsSource = Items;
        }

        private void MainSearchBar(Object sender, EventArgs e)
        {
            string keyword = busqueda.Text.ToLower();
            IEnumerable<Productos> searchresult = Items.Where(name => name.Nombre.ToLower().Contains(keyword));
            MyListView.ItemsSource = searchresult;
        }

        private void MySearchBarOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            // Has Backspace or Cancel has been pressed?
            if (textChangedEventArgs.NewTextValue == string.Empty)
            {
                MyListView.ItemsSource = Items;
            }
            else
            {
                string keyword = textChangedEventArgs.NewTextValue.ToLower();
                IEnumerable<Productos> searchresult = Items.Where(name => name.Nombre.ToLower().Contains(keyword));
                MyListView.ItemsSource = searchresult;
            }

        }

        private void Iphone8(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Iphone8());
        }

        private void IphoneX(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new IphoneX());
        }
        private void SamsungS7(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SamsungS7());
        }
        private void Nokia(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Nokia());
        }

        private void azure(Object sender, EventArgs e)
        {
            new NavigationPage(new TodoList());
            this.Navigation.PushModalAsync(new TodoList());
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            DisplayAlert("Producto:", e.SelectedItem.ToString(), "Cerrar");
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            await Navigation.PushModalAsync(new Login());
        }
    }
}