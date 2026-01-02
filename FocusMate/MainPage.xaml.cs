//using Android.Widget;

namespace FocusMate;

public partial class MainPage : ContentPage
{
    private bool isCompleted = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnToggleClicked(object sender, EventArgs e)
    {
        isCompleted = !isCompleted;

        if (isCompleted)
        {
            StatusLabel.Text = "Status: Completed";
            StatusLabel.TextColor = Colors.Green;
            ToggleButton.Text = "Mark as Pending";
        }
        else
        {
            StatusLabel.Text = "Status: Pending";
            StatusLabel.TextColor = Colors.Red;
            ToggleButton.Text = "Mark as Completed";
        }
    }
}
