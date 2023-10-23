namespace vazifa21._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compiles.Run();

            /*   var items = Employee.GetEmployees().SelectMany(x => x.ProgrammingLanguages, 
                    (parent, child) => new
                    {
                        Name = parent.FirstName,
                        Language = child
                    }
           );




            foreach ( var item in items )
            {
                Console.WriteLine($"Name: {item.Name}, Language: {item.Language}");
            }
            

            var N7Persons = Persons.GetPersons().SelectMany(x =>x.ProgLang,(parent,child) => new
            {
                name = parent.FirstName,
                lang = child
            });


            foreach (var person in N7Persons)
            {
                Console.WriteLine($"Name: {person.name}, Language: {person.lang}");
            }*/

            /*var N7Persons = Persons.GetPersons().SelectMany( x=> x.Email, (parent, child) => new
            {
                ism = parent.FirstName + " " + parent.LastName,
                email = child
            });  */
            
            
            
            var N7Persons = Persons.GetPersons().SelectMany(x => x.Companies,
                (parent, child) => new {
                    emp = parent,
                    comany = child
                })
                .SelectMany(y => y.emp.ProgLang, (parent, child) => new
                {
                    ismi = parent.emp.FirstName,
                    comany = parent.comany,
                    tili = child
                });


            /*var colls = Persons.Sele(x => x.Companies,
                (parent, child) => new {
                    emp = parent,
                    comany = child
                })
                .SelectMany(y => y.emp.Languages, (parent, child) => new
                {
                    ismi = parent.emp.FirstName,
                    comany = parent.comany,
                    tili = child
                });*/

            foreach (var person in N7Persons)
            {
                Console.WriteLine($"{person.ismi}   {person.comany}      {person.tili}");
            }

        }
    }
}
