using System;

namespace Library
{
    public class Person
    {
        public Person(string name, string edad)
        {
            this.Name = name;
            this.Edad = edad;
        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        public string Edad
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

    }
}
