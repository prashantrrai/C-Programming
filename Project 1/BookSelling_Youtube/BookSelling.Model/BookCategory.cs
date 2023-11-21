using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSelling.Model
{
    //this is the model file where how the data is designed to store in db logic is written.
    public class BookCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
    }
}
