
namespace Library
{

    public class Person
    {
        public Person(string name, string edad)
        {
            this.Name = name;
            this.Edad = edad;
            

        }

        private string name;

        private string edad;

        public string Name{get;set;}
        public string Edad{get;set;}
    }

}
