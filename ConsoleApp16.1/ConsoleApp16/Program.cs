using ConsoleApp16;
using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
class Program
{
    static void Main(string[] args)
    {
        //Group g = new Group();
        //g.AddStudent("Vasya");
        //g.AddStudent("Petya");
        //Console.WriteLine(g[0]);

        //Student[] people =
        //{
        //       new Student() { Name = "Артур", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Гена", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Стас", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Влад", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Миша", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Гриша", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Даня", Surname = "Кукурузов", Birthday = new MyDate() },
        //       new Student() { Name = "Степа ", Surname = "Кукурузов", Birthday = new MyDate() }
        //};

        //Array.Sort(people);
        //foreach (var person in people)
        //{
        //    Console.WriteLine(person.Name + " " + person.Surname + " " + person.Birthday);
        //}
        //string myString = string.Empty;
        //while (myString != "0")
        //{
        //    char[] arr = (myString = Console.ReadLine()).ToCharArray();
        //    //Array.Sort(arr, new Student());
        //    Console.WriteLine(arr);
        //}

       Student b = new Student("Римас","Бер","Вик");
        StateSaver.SaveStudent(b, "C:/Users/Пользователь/Desktop/ConsoleApp16.1/НовыйДокумент.txt");
        //    var p = new Student("Римас", "Берж", "В","фвг9шар","228 ");
        //    p.Avtomat += NewMark;
        //    p.ChekAvtomat();

        //    static void NewMark(object sender, EventArgs e)
        //    {
        //        var p = sender as Student;
        //        var data = e as ChekMarksEventArgs;

        //        Console.WriteLine(p.Surname + " получил 11 и выше и сдал экзамен на автомат " + data.Avtomat);
        //    }
        //    p.Iskluchenue += NewMess;
        //    p.ChekIskluchenie();
        //    static void NewMess(object sender, EventArgs e)
        //    {
        //        var p = sender as Student;
        //        var data = e as ChekIskluchenueEventArgs;

        //        Console.WriteLine(p.Name + " ,Браво,ты вылетаешь потому что твоя оценка- " + data.Message);
        //    }
        //}

    }
}
