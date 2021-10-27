using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Adolfito1", 31);
            Person persona2 = new Person("AdolfitoJulio", 98);
            Person persona3 = new Person("AdolfitoErnestoSegundo", 2);
            Person persona4 = new Person("AdolfitoA", 21);
            Person persona5 = new Person("AdolfitoJulioRios", 20);
            Person persona6 = new Person("AdolfitoRomeoSantosNoSeQueMasPonerParaQueSeaLargo", 24);
            Person persona7 = new Person("AdolfitoJrJuanLuisGuerraDoBrasil", 10);
            


            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí parte 3
            Visitor visitante = new VisitanteConcreto1();
            
            n1.Aceptar(visitante);
            

            //parte 4
            Visitor visitanteA = new VisitanteConcreto2();
            n1.Aceptar(visitanteA);
            

            Visitor visitanteB = new VisitanteConcreto3();
            n1.Aceptar(visitanteB);
           


            
        }
    }
}
