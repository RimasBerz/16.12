using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp16
{
    [Serializable]
    public class Person 
    {
        string name;
        string surname;
        string fathername;
        string adresshome;
        MyDate birthday;
        string phonenumber;
        /// <summary>
        /// Ну типо имя
        /// </summary>
        public string Name {
            get => name;
            set
            {
                if (value == "Наполеон" )
                {
                    throw new PersonExceptionName("Ты не Наполеон", "You not Napoleon");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                name = value;
            }
        }

        /// <summary>
        /// Ну типо фамилия
        /// </summary>
        public string Surname { 
                get => surname;
                set
            {
                    if (value == "Наполеон")
                    {
                        throw new PersonExceptionName("Ты не Наполеон", "You not Napoleon");
                    }
                    else
                    {
                        Console.WriteLine("Окей!");
                    }
                    surname = value;
                }
            }
        /// <summary>
        /// Ну типо отчество
        /// </summary>
        public string Fathername
        {
            get => fathername;
            set
            {
                if (value == "Наполеон" )
                {
                    throw new PersonExceptionName("Ты не Наполеон", "You not Napoleon");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                fathername = value;
            }
        }
        /// <summary>
        /// Ну типо адрес
        /// </summary>
        public string Adresshome
        {
            get => adresshome;
            set
            {
                if (value == "Наполеон")
                {
                    throw new PersonExceptionName("Ты не Наполеон", "You not Napoleon");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                adresshome = value;
            }
        }
        /// <summary>
        /// Ну типо номер телефона
        /// </summary>
        public string Phonenumber
        {
            get => phonenumber;
            set
            {
                if (value == "228")
                {
                    throw new PersonExceptionName("У тебя не этот номер телефона!", "You dont have this phone number");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                phonenumber = value;
            }
        }

        public MyDate Birthday { get; set; }
        public void SetName(string name)
        {
           Name = name;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetFathername(string fathername)
        {
            Fathername = fathername;
        }
        public void SetAddress(string adresshome)
        {
            Adresshome = adresshome;
        }
        public void SetPhoneNumber(string phonenumber)
        {
            Phonenumber = phonenumber;
        }
        public void SetBirthday(MyDate birthday)
        {
            Birthday = birthday;
        }
        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetFathername()
        {
            return fathername;
        }

        public string GetAddress()
        {
            return adresshome;
        }

        public string GetPhonenumber()
        {
            return phonenumber;
        }

        public MyDate GetBirthday()
        {
            return birthday;
        }
        /// <summary>
        /// Ну типо без параметров
        /// </summary>
        public Person()// : this("Taras", "Bylba", "??????", "--------",22,23,1111) 
        {
            Console.WriteLine("Person Constructor Without Parameters!");
        }

        public Person(string name, string lastname, string fathername, string phonenumber, MyDate birthday)
        {
            Console.WriteLine("Person Constructor With Parameters!");
            Name = name;
            Surname = lastname;
            Fathername = fathername;
            Phonenumber = phonenumber;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Fathername + ",Phonenumber " + ", age: " + Birthday;
        }
    }
}