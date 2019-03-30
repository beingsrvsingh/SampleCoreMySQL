using System;
using System.Collections.Generic;

namespace SampleCoreMySQL.Models
{
    public partial class Persons
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? Age { get; set; }
    }
}
