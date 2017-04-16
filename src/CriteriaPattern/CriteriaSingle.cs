using System;
using System.Collections.Generic;
using System.Text;

namespace CriteriaPattern
{
   public class CriteriaSingle:ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> sinlePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.MaritalStatus.ToUpper().Equals("SINGLE"))
                {
                    sinlePersons.Add(person);
                }
            }

            return sinlePersons;
        }
    }
}
