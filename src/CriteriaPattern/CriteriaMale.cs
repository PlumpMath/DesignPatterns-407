using System;
using System.Collections.Generic;
using System.Text;

namespace CriteriaPattern
{
    public class CriteriaMale:ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons=new List<Person>();
            foreach (var person in persons)
            {
                if (person.Gender.ToUpper().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }

            return malePersons;
        }
    }
}
