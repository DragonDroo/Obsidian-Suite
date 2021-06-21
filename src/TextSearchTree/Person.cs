using System;
using System.Collections.Generic;
using System.Text;

namespace TextSearchTree
{
    public class Person
    {
        readonly List<Person> _children = new List<Person>();
        public IList<Person> Children
        {
            get { return _children; }
        }

        public string Name { get; set; }
    }
}