using System;
namespace Library
{

    public class VisitanteConcreto2: Visitor
    {

        public int mayor;
        public int number;
        public override void Visitar(Node node)
        {
            mayor = 0;
            number = 0;
            
            //Compara edades
            foreach (Node hijo in node.Children)
            {
                if (mayor < hijo.Persona.Edad)
                {
                    mayor = hijo.Persona.Edad;
                    number = hijo.Number;
                }
                
            }
            
            Console.WriteLine($"El hijo con mayor edad es el numro {number} con edad {mayor}");
        }
    }

}