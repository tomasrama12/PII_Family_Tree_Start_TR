
namespace Library
{

    public class Person
    {
        public Person(string name, int edad)
        {
            this.Name = name;
            this.Edad = edad;
            

        }

        private string name;

        private int edad;

        public string Name{get;set;}
        public int Edad{get;set;}
    }

}
