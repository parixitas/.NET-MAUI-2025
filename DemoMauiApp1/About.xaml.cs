namespace DemoMauiApp1;

public partial class About : ContentPage
{
    //string filename = "F:\\Rohit\\Note.txt";
    string filename = Path.Combine(FileSystem.AppDataDirectory, "Note.txt");
	public About()
	{
		InitializeComponent();
        if (File.Exists(filename))
            TextEditor.Text = File.ReadAllText(filename);      
     }
    private void OnButtonClicked(object sender, EventArgs args)
    {         
         DisplayAlert("Clicked!", "The button labeled  has been clicked", "Cancel");
    }
    private void save(object sender, EventArgs args)
    {   
        try
        {
            File.WriteAllText(filename, TextEditor.Text);
            DisplayAlert("", "Successfully", "ok");
        }catch (Exception ex)
        {
            DisplayAlert("Message", "The Message" + ex , "ok");
           // DisplayAlert("Error Message" + ex);
        }
    }
    private void Delete(object sender, EventArgs args)
    {
        if(File.Exists(filename))
        {
            File.Delete(filename);
            TextEditor.Text = string.Empty;
            
        }
        DisplayAlert("Message", "Delete Successfully", "Ok");
    }



}