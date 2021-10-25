using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Adolfito1", "20");
            Person persona2 = new Person("Adolfito2", "20");
            Person persona3 = new Person("Adolfito3", "20");
            Person persona4 = new Person("Adolfito4", "20");
            Person persona5 = new Person("Adolfito5", "20");
            Person persona6 = new Person("Adolfito6", "20");
            Person persona7 = new Person("Adolfito7", "20");
            Person persona8 = new Person("Adolfito8", "20");


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

            // visitar el árbol aquí
        }
    }
}
