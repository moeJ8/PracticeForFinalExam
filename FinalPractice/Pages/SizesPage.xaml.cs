using FinalPractice.DataTransactions;

namespace FinalPractice;

public partial class SizesPage : ContentPage
{
    int i = 0;
    int j = 0;
    int tempPriceMemory = 0;
    int tempPriceRam = 0;
    string[] memorySizes = { "0", "1TB", "2TB" };
    string[] ramSizes = { "0", "16", "32" };
    public SizesPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
    private void memorySizeMinus_Clicked(object sender, EventArgs e)
    {
        int number;
        if (memorySize.Text != "0")
        {
            number = int.Parse(memorySize.Text);
            number--;
            memorySize.Text = number.ToString();
            GlobalTrans.Total -= 20;

        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
    
    private void memorySizePlus_Clicked(object sender, EventArgs e)
    {
        int number;
        if (memorySize.Text != "16")
        {
            number = int.Parse(memorySize.Text);
            number++;
            memorySize.Text = number.ToString();
            GlobalTrans.Total += 20;
        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void ramSizeMinus_Clicked(object sender, EventArgs e)
    {
        int number;
        if (ramSize.Text != "0")
        {
            number = int.Parse(ramSize.Text);
            number--;
            ramSize.Text = number.ToString();
            GlobalTrans.Total -= 20;

        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void ramSizePlus_Clicked(object sender, EventArgs e)
    {
        int number;
        if (ramSize.Text != "16")
        {
            number = int.Parse(ramSize.Text);
            number++;
            ramSize.Text = number.ToString();
            GlobalTrans.Total += 20;
        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
}