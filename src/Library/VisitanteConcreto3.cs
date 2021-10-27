using System;
namespace Library
{

    public class VisitanteConcreto3: Visitor
    {

        public string nombreMasLargo;
        public override void Visitar(Node node)
        {
            nombreMasLargo = node.Persona.Name;
            
            //Compara nombres segun su largo, si el nombre 
            foreach (Node hijo in node.Children)
            {
                if (nombreMasLargo.Length < hijo.Persona.Name.Length)
                {
                    nombreMasLargo = hijo.Persona.Name;
                }
                foreach (Node nieto in hijo.Children)
                {
                    
                    if (nombreMasLargo.Length < nieto.Persona.Name.Length)
                    {
                    nombreMasLargo = nieto.Persona.Name;
                    }

                }
                
            }
            
            Console.WriteLine($"El hijo con nombre mas largo es {nombreMasLargo} ");
        }
    }

}