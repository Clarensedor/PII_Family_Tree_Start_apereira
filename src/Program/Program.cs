using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Tony",33);
            Person p2 = new Person ("Maria",40);
            Person p3 = new Person ("Ernesto",50);
            Person p4 = new Person ("Pepe",60);
            Person p5 = new Person ("elisabet",5);
            Person p6 = new Person ("sande",20);
            Person p7 = new Person ("pedro",20);
            Person p8 = new Person ("tincho44",20);


            Node<Person> np1 = new Node <Person> (p1);
            Node<Person> np2 = new Node <Person> (p2);
            Node<Person> np3 = new Node <Person> (p3);
            Node<Person> np4 = new Node <Person> (p4);
            Node<Person> np5 = new Node <Person> (p5);
            Node<Person> np6 = new Node <Person> (p6);
            Node<Person> np7 = new Node <Person> (p7);
            Node<Person> np8 = new Node <Person> (p8);

            //en el nodo de Pepe agrego estos dos:
            np5.AddChildren(np2);
            np5.AddChildren(np3); 

            //el segundo:
            np2.AddChildren(np1); 
            np2.AddChildren(np8);
            np3.AddChildren(np6); 

            //el tercero:

            np6.AddChildren(np5); 



            //creo instancia de visits:
            SumVisitor v1 = new SumVisitor();
            VisitorName v2 = new VisitorName();
            VisitorOld v3 = new VisitorOld();

            v1.Visit (np2);
            v2.Visit (np2);
            v3.Visit (np2);

            Console.WriteLine($"Suma de edades:{v1.SumaEdades}");
            Console.WriteLine($"Nombre mas largo es {v2.LongestName}");
            Console.WriteLine($"El mas viejo es: {v3.OldestKid}");

        }
    }
}
