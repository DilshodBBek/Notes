using Notes.Presentation.NoteUI;

namespace Notes.Presentation;

internal class Program
{

    static void Main(string[] args)
    {
		try
		{
			new NoteController().StartNote();
		}
		catch (Exception)
		{

			throw;
		}
    }
}
