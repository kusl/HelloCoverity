using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverityLibrary
{
    public class Quote
    {
        public Quote()
        {

        }
        public string Text { get; set; }
        public Person Author { get; set; }
        public LocalDate UtteredDate { get; set; }
    }
}
