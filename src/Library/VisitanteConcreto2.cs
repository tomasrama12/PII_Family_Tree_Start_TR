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
                
                foreach (Node nieto in hijo.Children)
                {
                    if (mayor < nieto.Persona.Edad)
                    {
                    mayor = nieto.Persona.Edad;
                    number = nieto.Number;
                    }
                }
                
            }
            
            Console.WriteLine($"El nieto(nodos hojas) con mayor edad es el numro {number} con edad {mayor}");
        }
    }

}