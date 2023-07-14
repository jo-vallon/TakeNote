using System;
namespace Service.Models
{
	public class NoteDTO
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DueDate { get; set; }
        public bool isPinned { get; set; }

        public NoteDTO()
		{
		}

        public NoteDTO(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}

