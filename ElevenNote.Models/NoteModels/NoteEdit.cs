using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models.NoteModels
{
    public class NoteEdit
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public bool IsStarred { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
    }
}
