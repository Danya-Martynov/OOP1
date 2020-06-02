using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        public class buyer
        {
            public string lastname;
            public string firstname;
            internal string middlename;
            internal string cardnum;
            protected internal string bunknum;
        }
        public class subscriber
        {
            protected internal string id;
            public string lastname;
            public string firstname;
            internal string middlename;
            public string address;
            internal string cardnum;
            protected internal string ldnegotiations;
            protected internal string fcnegotiations;
        }
        public class petshop
        {
            public string pet;
            public string sex;
            public string name;
            public string price;
            public string quntity;
        }
        static void Main(string[] args)
        {
            buyer buyer1 = new buyer();
            buyer1.lastname = "Яренчких";
            buyer1.firstname = "Антон";
            buyer1.middlename = "Викторович";
            buyer1.cardnum = "4276 1616 8706 6746";
            buyer1.bunknum = "40817810570000123455";
            Console.WriteLine(buyer1.lastname);
            Console.WriteLine(buyer1.firstname);
            Console.WriteLine(buyer1.middlename);
            Console.WriteLine(buyer1.cardnum);
            Console.WriteLine(buyer1.bunknum);
            Console.WriteLine("");
            // Задание 1.

            subscriber sub1 = new subscriber();
            Console.WriteLine("Введите id абонента");
            sub1.id = Console.ReadLine();
            Console.WriteLine("Введите фамилию абонента");
            sub1.lastname = Console.ReadLine();
            Console.WriteLine("Введите имя абонента");
            sub1.firstname = Console.ReadLine();
            Console.WriteLine("Введите отчество абонента");
            sub1.middlename = Console.ReadLine();
            Console.WriteLine("Введите адрес абонента");
            sub1.address = Console.ReadLine();
            Console.WriteLine("Введите номер кредитной карточки абонента");
            sub1.cardnum = Console.ReadLine();
            Console.WriteLine("Введите время междугородных перговоров абонента");
            sub1.ldnegotiations = Console.ReadLine();
            Console.WriteLine("Введите время городских переговоров абонента");
            sub1.fcnegotiations = Console.ReadLine();

            Console.WriteLine(sub1.lastname);
            Console.WriteLine(sub1.firstname);
            Console.WriteLine(sub1.middlename);
            Console.WriteLine(sub1.address);
            Console.WriteLine(sub1.cardnum);
            Console.WriteLine(sub1.ldnegotiations);
            Console.WriteLine(sub1.fcnegotiations);
            Console.WriteLine("");
            //Задание 2

            petshop zoo1 = new petshop();
            Console.WriteLine("Введите животное");
            zoo1.pet = Console.ReadLine();
            Console.WriteLine("Введите пол животного");
            zoo1.sex = Console.ReadLine();
            Console.WriteLine("Введите имя животного");
            zoo1.name = Console.ReadLine();
            Console.WriteLine("Введите цену животного");
            zoo1.price = Console.ReadLine();
            Console.WriteLine("Введите кол-во животных");
            zoo1.quntity = Console.ReadLine();

            Console.WriteLine(zoo1.pet);
            Console.WriteLine(zoo1.sex);
            Console.WriteLine(zoo1.name);
            Console.WriteLine(zoo1.price);
            Console.WriteLine(zoo1.quntity);
            Console.ReadKey();
            //Задание 3.


        }
        
    }
}
