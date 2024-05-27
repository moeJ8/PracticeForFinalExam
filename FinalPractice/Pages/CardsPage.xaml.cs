namespace FinalPractice;

public partial class CardsPage : ContentPage
{
	public CardsPage()
	{
		InitializeComponent();
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
	}

    private void Add_Button_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCard(new Models.Card
        {
            Card_Name = name.Text,
            Card_Number = cardNumber.Text
        });
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCard((int)button.BindingContext);
        Cards_List_View.ItemsSource = App.DBTrans.GetCards();
    }
}