using System.Collections.Generic;

namespace Test.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public List<Person> Persons { get; set; }
        public Role()
        {
            Persons = new List<Person>();
        }
    }
}
