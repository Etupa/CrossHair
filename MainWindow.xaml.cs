using System.Windows;
using System.Windows.Input; // Include for KeyEventArgs

namespace GreenCrosshairOverlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Assuming the overlay window size is 100x100 for the crosshair
            this.Width = 100;
            this.Height = 100;

            // Center window on a 1920x1080 screen
            this.Left = (1920 - this.Width) / 2;
            this.Top = (1080 - this.Height) / 2;
        }
    }
}
