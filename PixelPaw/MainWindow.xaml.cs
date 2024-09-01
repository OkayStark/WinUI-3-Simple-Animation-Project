using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System.Numerics;
using Windows.Foundation.Metadata;

namespace PixelPaw
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AppWindow.MoveAndResize(new Windows.Graphics.RectInt32(0, 0, 500, 870));
            this.AppWindow.Title = "Test App";
        }
        private void RescaleButton_Click(object sender, RoutedEventArgs e)
        {
            // Define the pixel increase value
            double pixelIncrease = 10.0; // Example increase by 20 pixels

            // Define the maximum height limit
            double maxHeight = 270.0;

            // Increase the rectangle's height, ensuring it does not exceed the maximum height
            if (ScaleRectangle.Height + pixelIncrease <= maxHeight)
            {
                ScaleRectangle.Height += pixelIncrease;
            }
            else
            {
                ScaleRectangle.Height = maxHeight;
            }
        }
    }
}
