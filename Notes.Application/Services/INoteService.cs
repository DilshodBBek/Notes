using Notes.Domain.Models;

namespace Notes.Application.Services;
public interface INoteService
{
    Task<bool> CreateNote(Note note);
    Task<bool> UpdateNote(Note note);
    Task<bool> DeleteNote(int noteId);
    Task<IEnumerable<Note>> GetAll();
    Task<Note> GetById(int noteId);
}
