using System;
using System.Collections.Generic;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var ATF = new Group()
            {
                number = 1,
                title = "АТФ",
                
            };

            var AF = new Group()
            {
                number = 2,
                title = "АФ"
            };

            var Firststudent = new Student()
            {
                ID = 15636,
                FirstName = "Иван",
                SecondName = "Сидоров",
                mark = new int[] { 4, 3, 5, 3, 5 },
                group = ATF
            };

            var Secondstudent = new Student()
            {
                ID = 13598,
                FirstName = "Андрей",
                SecondName = "Петров",
                mark = new int[] { 4, 5, 5, 3,5 },
                group = AF
            };

            var Thirdstudent = new Student() 
            {
                ID = 46598,
                FirstName = "Кирилл",
                SecondName = "Юденок",
                mark = new int[] { 2, 4, 3, 2, 3 },
                group = ATF
            };

            var Fourthstudent = new Student()
            {
                ID = 87433,
                FirstName = "Мария",
                SecondName = "Смирнова",
                mark = new int[] { 4, 4, 5, 5, 4, 5 },
                group = AF
            };


            ATF.students.Add(Firststudent);      
            ATF.students.Add(Thirdstudent);
            AF.students.Add(Secondstudent);
            AF.students.Add(Fourthstudent);

            AF.showStudents();

      
            Firststudent.Print();

            Console.WriteLine();

            Secondstudent.Print();


            static float ReturnAverage(int[] mark)//метод возвращает среднее значение
            {
                float sum = 0;
                for (int i = 0; i < mark.Length; i++)
                {
                    sum += mark[i];
                }
                float result = sum / mark.Length;
                return result;
            }

            float average1 = ReturnAverage(Firststudent.mark);

            Console.WriteLine($"Средний балл студента {Firststudent.FirstName} {Firststudent.SecondName} {average1}.");

            float average2 = ReturnAverage(Secondstudent.mark);

            Console.WriteLine($"Средний балл студента {Secondstudent.FirstName} {Secondstudent.SecondName} {average2}.");
            


        }
    }
}
