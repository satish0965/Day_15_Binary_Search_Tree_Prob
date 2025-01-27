﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTreeNode<K>
    {
        public K Key;                           //Created One Key the values going to add passing it on both right and left
        public BinarySearchTreeNode<K> Right;   //create variable for right side node
        public BinarySearchTreeNode<K> Left;    //creates varibale for left side node

        public BinarySearchTreeNode(K Key)
        {
            this.Key = Key;
            Right = null;
            Left = null;
        }
    }
}