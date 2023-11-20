using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace bookselling.Model
{
    public class BookCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;

    }
}
