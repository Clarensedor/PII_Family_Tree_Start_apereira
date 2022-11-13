namespace Library
{
    public abstract class Visitor<T>
    {
        public string visitor
        {
            get
            {
                return this.visitor;
            }
        }

        public abstract void Visit(Node<T> node);


    }
}