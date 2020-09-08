using Octane.Xamarin.Forms.VideoPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TVTKXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var path =  new UriBuilder("//:vjs.zencdn.net/v/oceans.mp4");
            var y = VideoSource.FromUri("http://localhost:64647/getmultimedia?stream=Stream1&content=Video&id=0");
            videoPlayer.Source = y;//"http://vjs.zencdn.net/v/oceans.mp4";// http://localhost:64647/getmultimedia?stream=Stream1&content=Video&id=0";
            
             videoPlayer.Play();
        
        }
    }
}
