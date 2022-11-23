using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using Model2;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.Security.Cryptography;

namespace BusinessLogic2
{
    public class Logic
    {
        public List<Student> students = new List<Student>() { new Student(123, "пися", "ffgdf", "dfgdfg")};

        public void AddStudent(int id, string name, string speciality, string group)
        {
            students.Add(new Student(id,name, speciality, group));

            /*for (int i = 0; i < students.Count; i++)
            {
                if (Convert.ToInt32(students[i].Id) != Convert.ToInt32(id))
                {
                    students.Add(new Student(id, name, speciality, group));
                }
            }*/

            /*for (int i = 0; i <students.Count;i++)
            {
                if (students[i].Id == id)
                {
                    
                }
                else
                {
                    students.Add(new Student(id, name, speciality, group));
                }
            }*/
        }
        public void DeleteStudent(int id)
        {
            //students.RemoveAt(id);
            for (int i = 0; i < students.Count; i++)
            {
                if (Convert.ToInt32(students[i].Id) == id)
                {
                    students.Remove(students[i]);
                }
            }
        }

        public List<string[]> GetAll() { return students.Select(s => new string[] { s.Id.ToString(),s.Name,s.Speciality,s.Group}).ToList();}




    }
}
