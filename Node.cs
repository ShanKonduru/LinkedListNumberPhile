using System;
using System.Collections.Generic;

namespace LinkedListNumber {
    public class Node {
        public int Key;
        public List<Node> Children = new List<Node> ();

        // Utility function to create a new tree node
        public static Node newNode (int key) {
            Node temp = new Node ();
            temp.Key = key;
            return temp;
        }

        public void PrintPretty (string indent, bool last) {
            Console.Write (indent);
            if (last) {
                Console.Write ("\\-");
                indent += "  ";
            } else {
                Console.Write ("|-");
                indent += "| ";
            }

            Console.WriteLine (this.Key);

            for (int i = 0; i < this.Children.Count; i++)
                this.Children[i].PrintPretty (indent, i == this.Children.Count - 1);
        }

    }
}