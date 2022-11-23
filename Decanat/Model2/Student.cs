namespace Model2
{
    public interface IDomainObject
    {
        int Id { get; set; }
    }

    public class Student : IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        public Student(int id, string name, string group, string speciality)
        {
            int Id = id;
            Name = name;
            Speciality = speciality;
            Group = group;
        }
        public Student() { }

    }
}
