using System;

namespace Main{
    class Node{
        public int value;
        public Node? left;
        public Node? right;

        public Node() { }
        public Node(int value) {
             this.value = value;
        }
    }
}