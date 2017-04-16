using System.Collections.Generic;

namespace CriteriaPattern
{
    public class OrCriteria : ICriteria
    {
        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaItems = _criteria.MeetCriteria(persons);
            var otherCriteriaItems = _otherCriteria.MeetCriteria(persons);

            foreach (var person in otherCriteriaItems)
                if (!firstCriteriaItems.Contains(person))
                    firstCriteriaItems.Add(person);
            return firstCriteriaItems;
        }
    }
}