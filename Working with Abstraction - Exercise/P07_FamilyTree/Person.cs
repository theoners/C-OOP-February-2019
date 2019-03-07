﻿namespace P07_FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }


}
