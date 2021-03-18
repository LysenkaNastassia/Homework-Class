using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Group
    {
        public int number;
        public string title;
        public List<Student> students = new List<Student>();



        public void showStudents() //список студентов в группе
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Список студентов в группе {students[i].group.title}");
                Console.WriteLine($"ID номер студента:  {students[i].ID} ");
                Console.WriteLine($"Имя студента:  {students[i].FirstName}");
                Console.WriteLine($"Фамилия студента: {students[i].SecondName}");
                Console.WriteLine($"Средний балл студента:  {ReturnAverage(students[i].mark)}");
                Console.WriteLine();
            }


        }

        public float ReturnAverage(int[] mark)//метод возвращает среднее значение
        {
            float sum = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                sum += mark[i];
            }
            float result = sum / mark.Length;
            return result;
        }

        


    }
}

