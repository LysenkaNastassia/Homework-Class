using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Student
    {
        public int ID;
        public string FirstName;
        public string SecondName;
        public int[] mark = new int[] { };
        public Group group;

        public void Print() // информация о студенте
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Фамилия: {SecondName}");
            Console.WriteLine($"Имя: {FirstName}");
            for (int i = 0; i < mark.Length; i++)
            {
                 Console.WriteLine($"Оценкa #{i+1}: {mark[i]}");
            }
            Console.WriteLine($"Группа: {group.title}");
        }

        

 


    }
}
