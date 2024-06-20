﻿using Grokking_Algorithm.Chapter_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm.Double_Linked_List
{
    internal class Node<T>
    {
        public T Val { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T val)
        {
            Val = val;
            // Pointer
            Next = null;
        }
    }
}
