using Notes.Application.Services;
using Notes.Domain.Models;
using Notes.Infrastructure.DbConfiguration;

namespace Notes.Infrastructure.Services;
public class NoteService : INoteService
{
    private readonly INoteDbContext _context;

    public NoteService()
    {
        _context = new NoteDbContext();
    }

    public async Task<bool> CreateNote(Note note)
    {
        string command = @$"insert into note(title, created_date, is_completed, type) values
                          ('{note.Title}', '{note.CreatedDate}', '{note.IsCompleted}', '{note.Type}')";
        int effectedRows = await _context.ExecuteCommandAsync(command);
        return effectedRows > 0;
    }

    public async Task<bool> DeleteNote(int noteId)
    {
        string command = $"delete from note where id={noteId}";
        int effectedRows = await _context.ExecuteCommandAsync(command);
        return effectedRows > 0;
    }

    public Task<IEnumerable<Note>> GetAll()
    {
        return null;
    }

    public Task<Note> GetById(int noteId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateNote(Note note)
    {
        throw new NotImplementedException();
    }
}
