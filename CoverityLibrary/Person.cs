using System;
using System.Collections.Generic;

namespace CoverityLibrary
{
    public class Person
    {
        public Person()
        {
        }
        public Guid Id { get; set; }
        public string LegalName { get; set; }
        public string PreferredName { get; set; }
        public NodaTime.LocalDate DateOfBirth { get; set; }
        public List<Quote>  FavoriteQuotes { get; set; }
    }
}
