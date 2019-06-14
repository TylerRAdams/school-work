using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KanyeREST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Song convertedSong = new Song();
                convertedSong.Title = txtTitle.Text;
                convertedSong.Title = convertedSong.Title.ToLower();
                convertedSong.Title = convertedSong.Title.Replace(' ', '_');
                Request request = new Request();
                String Input = request.GetResponse(convertedSong.Title);

                JsonInput inputObject = new JsonInput();
                inputObject.Json = Input;

                JSONConverter converterObject = new JSONConverter();
                convertedSong = converterObject.Convert(inputObject);
                txtLyrics.Text = convertedSong.Lyrics;
            }
            catch (System.Net.WebException)
            {
                System.Windows.MessageBox.Show("Song Not Found", "404 Error");
            }
        }
    }
}
