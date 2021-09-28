using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _512143_Note.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set;  }
        public DateTime? CreateDate { get; set; }

    }
}
