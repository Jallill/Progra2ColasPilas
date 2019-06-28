using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Node
    {
        public Node greaterNode { get; private set; }
        public Node lesserNode { get; private set; }

        public int value { get; private set; }


        public Node(int value, Node lesserNode = null, Node greaterNode = null)
        {
            this.value = value;
            this.lesserNode = lesserNode;
            this.greaterNode = greaterNode;
        }

        public Node AddNode(int value, Node node)
        {
            if (node == null)
            {
                node = new Node(value);
            }
            else if (value < node.value)
            {
                node.lesserNode = AddNode(value, node.lesserNode);
            }
            else if (value > node.value)
            {
                node.greaterNode = AddNode(value, node.greaterNode);
            }
            else
            {
                Console.WriteLine("Dato ya existente");
            }

            return node;
        }

        public Node SearchNode(int value, Node node)
        {
            if (node != null)
            {
                if (value == node.value)
                {
                    Console.WriteLine("Se encontro el valor");
                }
                else if (value < node.value)
                {
                    node.SearchNode(value, node.lesserNode);
                }
                else if (value > node.value)
                {
                    node.SearchNode(value, node.greaterNode);
                }
            }
            else
            {
                Console.WriteLine("No se encontro el valor");
                return null;
            }

            return node;
        }

        public static bool CheckIgualForma(Node n1, Node n2)
        {
            if (n1 != null && n2 != null)
            {
                if (n1.greaterNode != null && n2.greaterNode != null || n1.greaterNode == null)
                {
                    return CheckIgualForma(n1.greaterNode, n2.greaterNode);
                }
                else return false;
                //if()
            }
            else return false;
        }
    }
}
