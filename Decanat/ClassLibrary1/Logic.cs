using DataAccessLayer;
using Model2;
using System.Collections.Generic;




namespace BusinessLogic2
{
    public class Logic
    {
        /* public static List<Student> students { get; set; } = new List<Student>()
         {
             new Student(1, "Тибеклек", "Ки21-12б", "Исит"),
             new Student(2, "Алишер", "Ки21-12б", "Исит"),
             new Student(3, "Иван", "Пи21-12б", "Пи")
         };*/

        //<--- Подключение через Энтити --->
        //public IRepository<Student> repository = new DapperRepository<Student>(); 

        //<--- Подключение через Даппер --->
        /*public IRepository<Student> repository = new DapperRepository<Student>();*///тип связи ассоциация 

        IRepository<Student> repository;

        public Logic(IRepository<Student> repositoryS)
        {
            repository = repositoryS;
        }

        public void AddStudent(int id, string name, string speciality, string group)
        {
            repository.Create(new Student(id, name, speciality, group));//работает
            repository.Save();


        }
        public void DeleteStudent(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public List<string> GetAll()
        {
            List<string> studentsList = new List<string>();

            IEnumerable<Student> students = repository.GetAll();

            foreach (Student student in students)
            {
                int id = student.Id;
                string name = student.Name;
                string group = student.Group;
                string speciality = student.Speciality;
                studentsList.Add($"{id} {name} {speciality} {group}");
            }

            return studentsList;
        }




    }
}
