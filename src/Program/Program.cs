using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> n1 = new Node<Person>(1);
            Node<Person> n2 = new Node<Person>(2);
            Node<Person> n3 = new Node<Person>(3);
            Node<Person> n4 = new Node<Person>(4);
            Node<Person> n5 = new Node<Person>(5);
            Node<Person> n6 = new Node<Person>(6);
            Node<Person> n7 = new Node<Person>(7);

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
