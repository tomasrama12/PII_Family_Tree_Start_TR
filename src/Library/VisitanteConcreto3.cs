using System;
namespace Library
{

    public class VisitanteConcreto3: Visitor
    {

        public string nombreMasLargo;
        public override void Visitar(Node node)
        {
            nombreMasLargo = "";
            
            //Compara edades
            foreach (Node hijo in node.Children)
            {
                if (nombreMasLargo.Length < hijo.Persona.Name.Length)
                {
                    nombreMasLargo = hijo.Persona.Name;
                }
                
            }
            
            Console.WriteLine($"El hijo con nombre mas largo es {nombreMasLargo} ");
        }
    }

}