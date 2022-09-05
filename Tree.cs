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

/*
        // Prints the n-ary tree level wise
        public void LevelOrderTraversal () {
                if (_root == null) {
                    return;
                }

                // Standard level order traversal code
                // using queue
                Queue<Node> q = new Queue<Node> (); // Create a queue
                q.Enqueue (_root); // Enqueue root
                while (q.Count != 0) {
                    int n = q.Count;

                    // If this node has children
                    while (n > 0) {
                        // Dequeue an item from queue
                        // and print it
                        Node p = q.Peek ();
                        q.Dequeue ();
                        Console.Write (p.Key + " ");

                        // Enqueue all children of
                        // the dequeued item
                        for (int i = 0; i < p.Children.Count; i++) {
                            q.Enqueue (p.Children[i]);
                        }
                        n--;
                    }

                    // Print new line between two levels
                    Console.WriteLine ();
                }
            }
            */
    }
}