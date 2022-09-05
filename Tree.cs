using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListNumber {
    public class Tree {

        public Node _root;

        public Tree (Node root) {
            _root = new Node ();
            _root.Key = root.Key;
            _root.Children = root.Children;
        }

        public Tree (int key) {
            _root = new Node ();
            _root.Key = key;
        }

        public Node AddChild (int key, Node parent) {
            Node childNode = Node.newNode (key);
            parent.Children.Add (childNode);
            return childNode;

        }

        public Node AddChild (Node childNode, Node parent) {
            parent.Children.Add (childNode);
            return childNode;

        }

        public Node AddChild (int key) {
            Node childNode = Node.newNode (key);
            _root.Children.Add (childNode);
            return childNode;
        }

        public Node AddChild (Node childNode) {
            _root.Children.Add (childNode);
            return childNode;
        }
        public void PrintPretty (string indent, bool last) {
            _root.PrintPretty (indent, last);
        }

        public static void PrintTree (Node tree, String indent, bool last) {
            Console.Write (indent + "+- " + tree.Key);
            indent += last ? "   " : "|  ";

            for (int i = 0; i < tree.Children.Count; i++) {
                PrintTree (tree.Children[i], indent, i == tree.Children.Count - 1);
            }
        }

    }
}