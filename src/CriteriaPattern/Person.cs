namespace CriteriaPattern
{
    public class Person
    {
        public Person(string name, string gender, string maritalStatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public string Gender { get; }

        public string MaritalStatus { get; }

        public string Name { get; }
    }
}