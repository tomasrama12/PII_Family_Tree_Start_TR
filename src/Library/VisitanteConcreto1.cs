using System;
namespace Library
{

    public class VisitanteConcreto1: IVisitor
    {

        public int edadTotal;
        public void Visitar(Node node)
        {
            
            //Calculo de edades
            foreach (Node hijo in node.Children)
            {
                edadTotal += hijo.Persona.Edad;
            }
            edadTotal += node.Persona.Edad;
            Console.WriteLine($"La edad total es {edadTotal} years");
        }
    }

}