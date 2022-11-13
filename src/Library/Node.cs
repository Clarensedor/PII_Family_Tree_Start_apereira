using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {

        public T Value { get; set; }


        private List<Node<T>> children = new List<Node<T>>();



        public ReadOnlyCollection<Node<T>> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

    }
}
