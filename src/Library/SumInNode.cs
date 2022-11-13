
namespace Library
{

    public class SumInNode : Visitor<Person>
    {
        public int suma;
        public override void Visit(Node<Person> node)
        {
            this.suma += node.Value.edad;
            
            foreach (Node<Person> n in node.Children)
            {
               n.Accept(this);
            }

        }

    }
}