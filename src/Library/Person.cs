using System;

namespace Library
{
    public class Person
    {
        public Person(string name, int edad)
        {
            this.Name = name;
            this.Edad = edad;
        }

        private string name;

        public int edad;

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

        public int Edad
        {
            get
            {
                return this.Edad;
            }
            
            set
            {
                    this.Edad = value;
            }
        }

    }
}
