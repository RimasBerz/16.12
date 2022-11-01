using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.IO;
namespace ConsoleApp16
{
    

        internal class StateSaver
        {
        
            public static void SaveStudent(Student b,string fileName)
            {
            Student save = new Student();
            Student product = new Student
            {
                Name = save.Name,
                Surname = save.Surname,
                Fathername = save.Fathername,
                Birthday = save.Birthday,
                Phonenumber = save.Phonenumber,
            };
            var formatter = new BinaryFormatter();
            using (var fStream = new FileStream(fileName,FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fStream, product);
            }
            string s = JsonConvert.SerializeObject(product, Formatting.Indented);
                Console.WriteLine(s);

                Student deserializedProduct = JsonConvert.DeserializeObject<Student>(s);
            }
            public static void SaveGroup(Group b, string fileName)
            {
                Group save = new Group();
                Group productG = new Group
                {
                    NameGroup = save.NameGroup,
                    NumberCourse = save.NumberCourse,
                    Length = save.Length,
                };
                var formatter = new BinaryFormatter();
                using (var fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(fStream, productG);
                }
                string s = JsonConvert.SerializeObject(productG, Formatting.Indented);
                Console.WriteLine(s);

                Student deserializedProduct = JsonConvert.DeserializeObject<Student>(s);
            }
        }
    
    class GroupEnumerator : Group, IEnumerator
    {

        int position = -1;
        public GroupEnumerator(string[] days) => this.students = students;
        public object Current
        {
            get
            {
                if (position == -1 || position >= students.Count)
                    throw new ArgumentException();
                return students[position];
            }
        }
        public bool MoveNext()
        {
            if (position < students.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
    }
    [Serializable]
    public class Group 
    {
        public class GroupNameComparer : IComparer<Group> // пример необобщённого интерфейса
        {
            public int Compare(Group s, Group copy)
            {
                if (s.NameGroup.Length > copy.NameGroup.Length) return 1;
                else if (s.NameGroup.Length < copy.NameGroup.Length) return -1;
                else return 0;
            }
            //public int Compare(Student x, Student y)
            //{
            //    if (x.CompareTo(y) != 0)
            //    {
            //        return x.CompareTo(y);
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}
            //public int Compare(char a, char b)
            //{
            //    Student another = new Student();
            //    if (hometasks.Contains(a) == true &&
            //       another.hometasks.Contains(b) == true)
            //        return 1;
            //    if (hometasks.Contains(a) == true &&
            //      another.hometasks.Contains(b) == true)
            //        return -1;
            //    return a.CompareTo(b);
            //}
        }
        public class NumberGroupeComparer : IComparer<Group> // пример необобщённого интерфейса
        {
            public int Compare(Group s, Group copy)
            {
                if (s.NumberCourse > copy.NumberCourse) return 1;
                else if (s.NumberCourse < copy.NumberCourse) return -1;
                else return 0;
            }
            //public int Compare(Student x, Student y)
            //{
            //    if (x.CompareTo(y) != 0)
            //    {
            //        return x.CompareTo(y);
            //    else
            //    {
            //        return 0;
            //    }
            //}
            //public int Compare(char a, char b)
            //{
            //    Student another = new Student();
            //    if (hometasks.Contains(a) == true &&
            //       another.hometasks.Contains(b) == true)
            //        return 1;
            //    if (hometasks.Contains(a) == true &&
            //      another.hometasks.Contains(b) == true)
            //        return -1;
            //    return a.CompareTo(b);
            //}
        }

        //public IEnumerator GetEnumerator() => new GroupEnumerator(students);//
        string namegroup;
        int numbercourse;
        /// <summary>
        /// Ну типо список студентов
        /// </summary>
        protected List<Student> students = new List<Student>();
        public void SetNameGroup(string namegroup)
        {
            
            if (namegroup == "Дебилы" )
            {
                throw new PersonExceptionName("Имей уважение!", "Dont name group like this!");
            }
            else
            {
                Console.WriteLine("Окей!");
            }
            this.namegroup = namegroup;
        }
        public void SetNumberCourse(int numbercourse)
        {
            if (numbercourse <= 0 || numbercourse >= 1000)
            {
                throw new PersonExceptionName("Не тот диапазон!", "You runned out diapazon!");
            }
            else
            {
                Console.WriteLine("Окей!");
            }
            this.numbercourse = numbercourse;
        }
        public int GetColStudent()
        {
            return students.Count;
        }
        public string GetNameGroup()
        {
            return NameGroup;
        }
        public int GetNumberCourse()
        {
            return NumberCourse;
        }
        public string GetStudent { get; set; }
        public string NameGroup { get; set; }
        public int NumberCourse { get; set; }
        public void AddStudent(Student s) 
        {
            students.Add(s);
        }
        public void DelStudent(Student s)
        {
            students.Remove(s);
        }
        public void ShowStudent(Group s)
        {
            s.Print3();
        }
        public override bool Equals(object studentik)
        {
            Group Studentikg = studentik as Group;
            if (Studentikg == null)
            {
                Console.WriteLine("OOPS! ETO NE PERSON!!!");
                return false;
            }
            return Studentikg.students == this.students;
        }
        /// <summary>
        /// Ну типо перегрузка оператора ==
        /// </summary>
        public static bool operator ==(Group left, Group right)
        {
            return left.students.Count == right.students.Count;
        }
        /// <summary>
        /// Ну типо перегрузка оператора !=
        /// </summary>
        public static bool operator !=(Group left, Group right)
        {
            return !(left.students.Count == right.students.Count);
        }
     
        public int Length 
        {
            get
            {
               Int32 length = students.Count;
                return length;
            }
            set {  }
        }
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    Console.WriteLine("OOPS! Bad index!");
                    return students.ElementAt(index);
                }
                else
                {
                    throw new Exception();
                }
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    Console.WriteLine("OOPS! Bad index!");
                    return;
                }
                else
                {
                    students[index] = value;
                }
            }
        }
   
        public Student this[string name, string surname, string fathername,string adresshome,string phonenumber]
        {
            get
            {
                foreach (var person in students)
                {
                    if (person.Name == name) return person;
                    else if (person.Surname == surname) return person;
                    else if (person.Fathername == fathername) return person;
                    else if (person.Adresshome == adresshome) return person;
                    else if (person.Phonenumber == phonenumber) return person;
                }
                throw new Exception("Unknown name or something else");
            }
        }
        public Student this[MyDate birthday]
        {
            get
            {
                foreach (var person in students)
                {
                    //if (person.Birthday == birthday) return person;
                }
                throw new Exception("Unknown birthday");
            }
        }
        
        public void Print3() 
        {
            foreach (var s in students)
            {
                s.Print2();
            }
            Console.WriteLine("NameGroup:{0} ", NameGroup);
            Console.Write("NumberGroup:{0} ", NumberCourse);
        }

        public Group(string NameGroup, int NumberCourse)
        {
            SetNameGroup(NameGroup);
            SetNumberCourse(NumberCourse);
        }
        public Group(string NameGroup, int NumberCourse, int Length)
        {
            SetNameGroup(NameGroup);
            SetNumberCourse(NumberCourse);
            Console.WriteLine("Кол-во студентов{0}",Length);
        }
        public Group()
        {
            SetNameGroup("Имя группы");
            SetNumberCourse(0);
        }
        public int CompareTo(object obj)
        {
            if (obj is Group)
            {
                Group another = obj as Group;
                if (this.numbercourse == another.numbercourse) return 0;
                else if (this.numbercourse < another.numbercourse) return -1;
                else return 1;

                return this.numbercourse.CompareTo(another.numbercourse);
            }
            else
            {
                throw new ArgumentException("bad type for parameter!");
            }
        }
        //public static void TestGroup()
        //{
        //    Group first = new Group();
        //    Group another = new Group();
        //    bool isEqual = Enumerable.SequenceEqual(first, another.numbercourse);
        //    if (isEqual)
        //    {
        //        Console.WriteLine("Lists are Equal");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Lists are not Equal");
        //    }
        //    if (this.numbercourse > another.numbercourse) return 1;
        //}
        //public int CompareNumberC(Group? p1, Group? p2)
        //{
        //    if (p1 is null || p2 is null)
        //    {
        //        throw new ArgumentException("Некорректное значение параметра");
        //    }
        //    return p1.numbercourse - p2.numbercourse;
        //}
    }
}
