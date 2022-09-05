using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListNumber {
    public class BinaryTree {

        private int _count;
        public BinaryTreeNode _root;
        private IComparer<int> _comparer = Comparer<int>.Default;

        public BinaryTree () {
            _root = null;
            _count = 0;
        }

        public bool Add (int key) {
            if (_root == null) {
                _root = new BinaryTreeNode (key);
                _count++;
                return true;
            } else {
                return AddSubNode (_root, key);
            }
        }

        private bool AddSubNode (BinaryTreeNode Node, int key) {
            if (_comparer.Compare (Node.Key, key) < 0) {
                if (Node.right == null) {
                    Node.right = new BinaryTreeNode (key);
                    _count++;
                    return true;
                } else {
                    return AddSubNode (Node.right, key);
                }
            } else if (_comparer.Compare (Node.Key, key) > 0) {
                if (Node.left == null) {
                    Node.left = new BinaryTreeNode (key);
                    _count++;
                    return true;
                } else {
                    return AddSubNode (Node.left, key);
                }
            } else {
                return false;
            }
        }
    }
}