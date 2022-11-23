using BusinessLogic2;
using Ninject;
using SimpleConfiqModuleNamespace;
using System;
using System.Linq;

namespace Consolee
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IKernel ninjectKernel = new StandardKernel(new SimpleConfiqModule());
            Logic logic = ninjectKernel.Get<Logic>();


            // Logic logic = new Logic();


            Console.WriteLine("Студент добавлен!");




            Console.WriteLine("Здравствуйте! Добро пожаловать в Деканат");
            while (true)
            {
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1 - Добавить студента, 2 - Удалить студента, 3 - Вывести список студентов");
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Введите id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите имя");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите специальность");
                        string speciality = Console.ReadLine();

                        Console.WriteLine("Введите группу");
                        string group = Console.ReadLine();
                        Console.WriteLine();


                        foreach (var a in logic.GetAll())
                        {
                            if (a == id.ToString())
                            {
                                Console.WriteLine("Человек с таким айди уже есть");
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                logic.AddStudent(id, name, speciality, group);
                                Console.WriteLine("Студент Добавлен");
                                Console.WriteLine();
                                break;
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("Введите id");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var a in logic.GetAll())
                        {
                            if (a == id.ToString())
                            {
                                Console.Clear();
                                Console.WriteLine("Стдуент удален");
                            }
                            else
                            {
                                Console.WriteLine("Invalid id, try again!!!");
                                break;
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("____Список студентов____");
                        for (int i = 0; i < logic.GetAll().Count(); i++)
                        {
                            Console.Write(logic.GetAll().ElementAt(i)[0] + " ");
                            Console.Write(logic.GetAll().ElementAt(i)[1] + " ");
                            Console.Write(logic.GetAll().ElementAt(i)[2] + " ");
                            Console.WriteLine(logic.GetAll().ElementAt(i)[3]);
                            Console.WriteLine();
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
