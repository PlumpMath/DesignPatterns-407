using System;
using System.Collections.Generic;
using System.Text;

namespace CriteriaPattern
{
   public class CriteriaFemale:ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.Gender.ToUpper().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }

            return femalePersons;
        }
    }
}
