using System;

namespace CShop
{

    class Person
    {
        public int Age;
        public String Name;

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }

    delegate bool CompareDelegate(object arg1, object arg2);

    class SortObject
    {
        object[] things;

        public SortObject(object[] things)
        {
            this.things = things;
        }

        public void Sort(CompareDelegate compareMethod)
        {
            object temp;

            for (int i = 0; i < things.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < things.Length; j++)
                {
                    if (compareMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }

                }

                temp = things[lowPos];
                things[lowPos] = things[i];
                things[i] = temp;
            }
        }

        public void Display()
        {
            for(int i=0; i<things.Length; i++)
            {
                Console.WriteLine(things.GetValue(i));
            }
        }
    }

    class _4_08_Delegate_Sort
    {
        public _4_08_Delegate_Sort()
        {
            Person[] personArray = new Person[] 
            {new Person(19,"이신홍"), new Person(20,"김신홍"), new Person(31,"최신홍"),
            new Person(10, "이신롱"), new Person(20, "김신홍")};

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);

            so.Display();
        }

        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;
            Person person2 = arg2 as Person;

            return person1.Name.CompareTo(person2.Name) < 0;
        }
    }
}
