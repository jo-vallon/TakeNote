using System.Collections.ObjectModel;
using System.Diagnostics;
using Service;
using Service.Models;

namespace TakeNote;

public partial class MainPage : ContentPage
{
	public ObservableCollection<NoteDTO> userNotes = new ObservableCollection<NoteDTO>();
    private APIService _service = new APIService(); 

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

    async void btn_add_Pressed(System.Object sender, System.EventArgs e)
    {
        try
        {
            var res = await _service.GetTestInfo();
            userNotes.Add(new NoteDTO(res, "Get some milk"));
            //Navigation.PushAsync(new EditNote());
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}


