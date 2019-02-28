using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelFonts
{
    public partial class MainPage : ContentPage
    {
        string[] font = {"OpenSans-Bold.ttf#OpenSans-Bold", "Poppins-Black.ttf#Poppins-Black", "Raleway-Black.ttf#Raleway-Black"};
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        void MudarFonte(object sender, EventArgs args)
        {

            label_01.FontFamily = font[random.Next(0,(font.Length - 1))];
            label_02.FontFamily = font[random.Next(0, (font.Length - 1))];
            label_03.FontFamily = font[random.Next(0, (font.Length - 1))];
        }

    }
}
