using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using MediaCtrl.MediaService;

namespace MediaCtrl
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        MediaCtrl.MediaService.Service1Client svc;
        bool play = false;
        public MainPage()
        {
            InitializeComponent();
            svc = new Service1Client();
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            svc.CommandAsync("Play", "");
            play = true;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (play == true)
            {
                svc.CommandAsync("Stop", "");
                play = false;
            }
        }
    }
}