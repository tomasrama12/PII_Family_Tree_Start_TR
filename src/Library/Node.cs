using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private Person persona;

        public Person Persona
        {
            get
            {
                return this.persona;
            }
        }

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Person persona)
        {
            this.number = number;
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        
    }
}
