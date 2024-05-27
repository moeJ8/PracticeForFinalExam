using FinalPractice.DataTransactions;
using FinalPractice.Models;

namespace FinalPractice;

public partial class CheckoutPage : ContentPage
{
    int Add_ID;
    int Cardd_ID;

	public CheckoutPage()
	{
		InitializeComponent();
        Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
        Proceed_List_View.ItemsSource = App.DBTrans.GetBills();
    }

    private void Show_Lists_Clicked(object sender, EventArgs e)
    {
        Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        total.Text = "Total Price: " + GlobalTrans.Total.ToString();
        Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
        Proceed_List_View.ItemsSource = App.DBTrans.GetBills();
    }

    private void Address_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var address = e.Item as Address;
        Add_ID = address.Address_ID;
    }

    private void Cards_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var card = e.Item as Card;
        Cardd_ID = card.Card_ID;
    }

    private void useItems_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddBill(new Models.Bills
        {
            Address_ID = Add_ID,
            Card_ID = Cardd_ID,
            Processor = GlobalTrans.Processor,
            Memory_Size = GlobalTrans.MemorySize,
            Ram_Size = GlobalTrans.ramSize,
            RTX = GlobalTrans.RTX,
            Total = GlobalTrans.Total

        });
        Proceed_List_View.ItemsSource = App.DBTrans.GetBills();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteBill((int)button.BindingContext);
        Proceed_List_View.ItemsSource = App.DBTrans.GetBills();
    }
}