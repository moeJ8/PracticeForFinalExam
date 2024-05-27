namespace FinalPractice;

public partial class AddressPage : ContentPage
{
	public AddressPage()
	{
		InitializeComponent();
		Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
	}

    private void Add_Button_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddAddress(new Models.Address
        {
            City = city.Text,
            District = district.Text
        });
        Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteAddress((int)button.BindingContext);
        Address_List_View.ItemsSource = App.DBTrans.GetAddresses();
    }
}