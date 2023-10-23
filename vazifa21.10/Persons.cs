using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace vazifa21._10_
{
    internal class Persons
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<string> Email { get; set; }
        public List<long> PhoneNumber { get; set; }
        public List<string> ProgLang { get; set; }
        public List<string> Companies { get; set; }
        public List<long> Salary { get; set; }
       



        public static  List<Persons> GetPersons()
        {
            List<Persons> persons = new List<Persons>()
            {
                new Persons { Id = 1, FirstName = "Nurmuhammad", LastName = "Sharobiddinov", Age = 20,
                    Email = new List<string>{"888legolas777@gamil.com","888nurmuhammad777@gmail.com","666legolas777@gmail.com" }, 
                    PhoneNumber = new List<long>{998889690910,998905751635,998911570207} , 
                    ProgLang = new List<string>{ "C","C++","C#","Python"},
                    Companies = new List<string>{ "Microsoft Corporation","Google", "Nikita Industries","Nill Consolidated"}, 
                    Salary = new List<long>{ 400000000000000, 40000000, 4000000000000000000, 400000000000000000 } },


                new Persons { Id = 2, FirstName = "Rustambek", LastName = "Jo'rayev", Age = 15,
                    Email = new List<string>{"Rustambek@gamil.com","khrustambek@gmail.com","khJurayev@gmail.com" },
                    PhoneNumber = new List<long>{998931230315,998904567548,998997893595} , 
                    ProgLang = new List<string>{ "C","C++","C#","JavaScript"},
                    Companies = new List<string>{ "Meta","Amazon", "Samsung","Yandex"},
                    Salary = new List<long>{ 45600, 23500, 65200, 51320 } },


                new Persons { Id = 3, FirstName = "Sevich", LastName = "Xayriddinova", Age = 19,
                    Email = new List<string>{"888legolas777@gamil.com","888nurmuhammad777@gmail.com","666legolas777@gmail.com" },
                    PhoneNumber = new List<long>{998939613663,998901236336,998992566336} , 
                    ProgLang = new List<string>{ "C","C++","C#","Python","Pascal"},
                    Companies = new List<string>{ "Microsoft Corporation","Space X", "Apple"},
                    Salary = new List<long>{ 456000, 476800, 780000,} }
            };


            return  persons;
        }

    }
}
