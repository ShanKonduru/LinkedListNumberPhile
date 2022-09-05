using System;

namespace LinkedListNumber {
    class Program {

        public static void PrintTree (Node tree, String indent, bool last) {
            Console.WriteLine (indent + "+- " + tree.Key);
            indent += last ? "   " : "|  ";

            for (int i = 0; i < tree.Children.Count; i++) {
                PrintTree (tree.Children[i], indent, i == tree.Children.Count - 1);
            }
        }

        static void Main (string[] args) {
            BinaryTree btr = new BinaryTree ();
            btr.Add (6);
            btr.Add (2);
            btr.Add (3);
            btr.Add (5);
            btr.Add (7);
            btr.Add (6);
            btr.Add (4);

            btr.Add (11);
            btr.Add (9);
            btr.Add (13);
            btr.Add (14);
            btr.Add (18);
            btr.Add (30);
            btr.Add (17);
            btr.Add (1);
            btr.Add (10);
            btr.Add (16);

            BinaryTreePrinter.PrintMe (btr._root);
            BinaryTreePrinter.Print (btr._root);

            /*
            Console.WriteLine ("Hello World!");
            Tree root = new Tree (50);
            Node node10 = Node.newNode (10);
            root.AddChild (1, node10);
            root.AddChild (5, node10);
            root.AddChild (8, node10);
            root.AddChild (9, node10);
            Node node20 = Node.newNode (20);
            root.AddChild (21, node20);
            Node node25 = root.AddChild (25, node20);
            root.AddChild (27, node20);
            Node node29 = root.AddChild (29, node20);

            Node node30 = Node.newNode (30);
            Node node31 = root.AddChild (31, node30);
            root.AddChild (32, node31);
            root.AddChild (33, node31);
            root.AddChild (34, node31);
            root.AddChild (35, node31);
            Node node40 = Node.newNode (40);
            root.AddChild (41, node40);
            root.AddChild (42, node40);
            root.AddChild (43, node40);

            Node node44 = Node.newNode (44);
            root.AddChild (46, node44);
            root.AddChild (47, node44);
            root.AddChild (48, node44);
            root.AddChild (49, node44);

            root.AddChild (node44, node40);

            root.AddChild (node10);
            root.AddChild (node20);
            root.AddChild (node30);
            root.AddChild (node40);

            // root.PrintPretty ("", true);

            PrintTree (root._root, " ", true);

            // root.LevelOrderTraversal ();
            */
        }
    }
}