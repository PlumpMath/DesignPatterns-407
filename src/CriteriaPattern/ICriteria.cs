using System.Collections.Generic;

namespace CriteriaPattern
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}