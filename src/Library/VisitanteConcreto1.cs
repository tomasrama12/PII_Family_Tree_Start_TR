using System;
namespace Library
{

    public class VisitanteConcreto1: Visitor
    {

        public int edadTotalHijos;
        public int edadTotalNietos;

        public int edadTotal;
        
        public override void Visitar(Node node)
        {
            edadTotal = 0;
            edadTotalHijos = 0;
            edadTotalNietos = 0;
            
            //Calculo de edades
            foreach (Node hijo in node.Children)
            {
                edadTotalHijos += hijo.Persona.Edad;
                foreach (Node nieto in hijo.Children)
                {
                    edadTotalHijos += nieto.Persona.Edad;
                }
            }
            edadTotalHijos += node.Persona.Edad;
            edadTotal = edadTotalHijos + edadTotalNietos;
            
            Console.WriteLine($"La edad total es {edadTotal} years");
        }
    }

}