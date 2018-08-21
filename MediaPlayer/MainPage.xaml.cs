using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MediaPlayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Update();
        }
        private async void Update()
        {
            MessageDialog message = new MessageDialog($"Video {Video.Name} Playing", "Video Update");
            await message.ShowAsync();
        }

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Video.Play();
            MessageDialog message = new MessageDialog("Video Playing", "Video Update");
            await message.ShowAsync();
        }

        private async void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            Video.Pause();
            MessageDialog message = new MessageDialog("Video Paused", "Video Update");
            await message.ShowAsync();
        }

        private async void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Video.Stop();
            MessageDialog message = new MessageDialog("Video Stoped", "Video Update");
            await message.ShowAsync();
        }

        private async void VolumeUp_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog message;
            if (Video.Volume == 100.00)
            {
                message = new MessageDialog("Volume at Max", "Video Update");
                await message.ShowAsync();
            }
            else
            {
                Video.Volume ++;
                message = new MessageDialog($"Volume added and is now at {Video.Volume}", "Video Update");
                await message.ShowAsync();
            }
        }

        private async void VolumeDown_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog message;
            if (Video.Volume == 0.00)
            {
                message = new MessageDialog("Volume at Lowest", "Video Update");
                await message.ShowAsync();
            }
            else
            {
                Video.Volume --;
                message = new MessageDialog($"Volume Lowered and is now at {Video.Volume}", "Video Update");
                await message.ShowAsync();
            }
        }
    }
}
