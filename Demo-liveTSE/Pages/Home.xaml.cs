using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_liveTSE.Pages ;

    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void Webview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebLiveView());
        }

        private void Imageview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageView());
        }

        private void Chartview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChartView());
        }
    }