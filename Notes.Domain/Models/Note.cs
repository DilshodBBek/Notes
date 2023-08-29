using Notes.Domain.States;

namespace Notes.Domain.Models;
public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsCompleted { get; set; }
    public NoteType Type { get; set; }
}
