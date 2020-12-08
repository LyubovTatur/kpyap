using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    Программно промоделировать сдачу зачета студентами.
//    Каждый студент характеризуется ФИО и количеством
//    посещенных занятий.Также известно количество 
//    общих занятий = 20.Студенты делятся на обычных,
//    сообразительных и гениев (потомки класса студент).
//    Для каждого человека определите полиморфный метод «Сдать зачет» без параметров,
//    возвращающих логическое значение(сдал – true, не сдал – false).
//    Обычные студенты точно сдают зачет, если посетили все занятия,
//    если были более чем на половине занятий, то сдают с вероятностью 0,5;
//    иначе не сдают.Сообразительные студенты тоже точно сдают зачет,
//    если посетили все занятия, если были более чем на половине занятий,
//    то сдают с вероятностью 0,7;
//    иначе не сдают зачет Гении точно сдают зачет,
//    если были хотя бы на одном занятии, иначе не сдают.


//    Создайте массив из 10 студентов (5 обычных, 4 сообразительных и 1 гения),
//    задайте их ФИО и количество посещенных занятий константами,
//    указанными в конструкторах объектов и промоделируйте сдачу
//    зачета с выводом подробных результатов(всех сведений о студентах,
//    а также результате сдачи).

namespace doplaba10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("student_1 ",11 ));
            students.Add(new Student("student_2",5 ));
            students.Add(new Student("student_3 ",25 ));
            students.Add(new Student("student_4 ", 20));
            students.Add(new Student("student_5", 0));
            students.Add(new Soobraz("soobraz_1", 11));
            students.Add(new Soobraz("soobraz_2", 20));
            students.Add(new Soobraz("soobraz_3", 5));
            students.Add(new Soobraz("soobraz_4", -241));
            students.Add(new Geniy("geniy_1", 1));

            foreach (var item in students)
            {
                Console.Write(item.FIO + "\t посещенных занятий " + item.kolvo + "\t ");
                if (item.Zachet())
                    Console.Write("зачет");
                else
                    Console.Write("не зачет");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
