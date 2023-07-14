using System.Diagnostics;

namespace TakeNote;

public partial class EditNote : ContentPage
{
	public EditNote()
	{
		InitializeComponent();
	}

    void btn_add_Pressed(System.Object sender, System.EventArgs e)
    {
		try
		{

		}
		catch(Exception ex)
		{
			Debug.WriteLine(ex.Message);
		}
    }
}
