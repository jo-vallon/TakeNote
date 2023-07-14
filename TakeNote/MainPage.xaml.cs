using System.Collections.ObjectModel;
using System.Diagnostics;
using Service.Models;

namespace TakeNote;

public partial class MainPage : ContentPage
{
	public ObservableCollection<NoteDTO> userNotes = new ObservableCollection<NoteDTO>();

    public MainPage()
	{
		InitializeComponent();
		GetUserNotes();

    }

	public async Task GetUserNotes()
	{
		try
		{
            userNotes.Add(new NoteDTO("Groceries1", "Get some milk"));
            userNotes.Add(new NoteDTO("Groceries2", "Get some milk"));
            userNotes.Add(new NoteDTO("Groceries3", "Get some milk"));
            userNotes.Add(new NoteDTO("Groceries4", "Get some milk"));
            userNotes.Add(new NoteDTO("Groceries5", "Get some milk"));

			lst_notes.ItemsSource = userNotes;
        }
		catch(Exception ex)
		{
			Debug.WriteLine(ex.Message);
		}
	}

    void btn_add_Pressed(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new EditNote());
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}


