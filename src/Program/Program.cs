using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> n1 = new Node<Person>();
            Node<Person> n2 = new Node<Person>();
            Node<Person> n3 = new Node<Person>();
            Node<Person> n4 = new Node<Person>();
            Node<Person> n5 = new Node<Person>();
            Node<Person> n6 = new Node<Person>();
            Node<Person> n7 = new Node<Person>();

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7); 

            // visitar el árbol aquí
        }
    }
}
