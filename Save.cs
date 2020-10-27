using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Test.Models;

namespace Test
{
    public class Save
    {
        private MySqlDbContext context = new MySqlDbContext();

        public bool IsValidEmail(string emaill)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(emaill);
        }

        public void saveChanges(string firstName, string secondName, string email, string pmail, string profilmyvalue)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pmail))
            {
                if (pmail.Length >= 6 && IsValidEmail(email))
                {
                    var person = context.Persons.Find(Convert.ToInt32(profilmyvalue));

                    person.FirstName = firstName;
                    person.SecondName = secondName;
                    person.Email = email;
                    person.Password = pmail;

                    context.SaveChanges();
                }
            }
        }


    }
}
