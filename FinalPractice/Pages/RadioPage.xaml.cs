using FinalPractice.DataTransactions;

namespace FinalPractice;

public partial class RadioPage : ContentPage
{
    int processorTotal = 0;
    int rtxTotal = 0;
    public RadioPage()
	{
		InitializeComponent();
	}

    private void i3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if(processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if(i3.IsChecked)
        {
            processorTotal = 150;
            GlobalTrans.Processor = "i3";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void i5_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if (i5.IsChecked)
        {
            processorTotal = 200;
            GlobalTrans.Processor = "i5";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void i7_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if (i7.IsChecked)
        {
            processorTotal = 300;
            GlobalTrans.Processor = "i7";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void rtx36_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if (rtx36.IsChecked)
        {
            processorTotal = 450;
            GlobalTrans.Processor = "RTX3060";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void rtx36ti_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if (rtx36ti.IsChecked)
        {
            processorTotal = 500;
            GlobalTrans.Processor = "RTX3060ti";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void rtx37_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }
        if (rtx37.IsChecked)
        {
            processorTotal = 600;
            GlobalTrans.Processor = "RTX3070";
        }
        GlobalTrans.Total += processorTotal;
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void mouse_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (mouse.IsChecked)
        {
            GlobalTrans.Total += 60;
        }
        else
        {
            GlobalTrans.Total -= 60;
        }
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void keyboard_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (keyboard.IsChecked)
        {
            GlobalTrans.Total += 30;
        }
        else
        {
            GlobalTrans.Total -= 30;
        }
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void headphones_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (headphones.IsChecked)
        {
            GlobalTrans.Total += 100;
        }
        else
        {
            GlobalTrans.Total -= 100;
        }
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        totalprice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
}