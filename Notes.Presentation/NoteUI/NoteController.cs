using Notes.Application.Services;
using Notes.Domain.Models;
using Notes.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Presentation.NoteUI;
public class NoteController
{
    private readonly INoteService _noteService;

    public NoteController()
    {
        _noteService = new NoteService(); 
    }

    public void StartNote()
    {

        Note note = new();
        note.CreatedDate = DateTime.Now;

        Console.WriteLine("Title:");
        note.Title = Console.ReadLine();
        Console.WriteLine("IsCompleted:");

        bool.TryParse(Console.ReadLine(), out bool res);
        note.IsCompleted = res;

        _noteService.CreateNote(note);
    }
}
