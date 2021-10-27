using System;
namespace Library
{

    public class VisitanteConcreto1: Visitor
    {

        public int edadTotal;
        public override void Visitar(Node node)
        {
            edadTotal = 0;
            
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