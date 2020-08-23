using System;
using System.Collections.Generic;
using System.Text;

namespace Week8.Gus
{
    class Gus
    {
        private string name;
        private int weight;
        private int age;
        private string owner;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Owner
        {
            get => owner;
            set => owner = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public Gus( string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
    }
}
