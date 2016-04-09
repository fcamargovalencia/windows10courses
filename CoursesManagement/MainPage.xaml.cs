using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using CoursesManagement.Models;
using Newtonsoft.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CoursesManagement
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }


        private async void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            HttpClient http = new HttpClient();
            var url = String.Format("http://webservicecourses.azurewebsites.net/getUsuario.php?usuario={0}&&password={1}", textBoxUsuario.Text, textBoxPassword.Password);
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<Usuario>>(result);
            
            if(data.Count > 0)
            {
                Frame.Navigate(typeof(DashBoard),data[0]);
            }
            else {
            }
        }
    }
}
