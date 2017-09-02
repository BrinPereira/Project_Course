using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class IntegerSet
    {
        public static int setSize = 101;

        // Declaring boolean set to store true or false values.
        bool[] set;
        
        // default constructor.
        public IntegerSet()   
        {
            set = new bool[setSize];
            for (int i = 0; i < setSize; i++)
                set[i] = false;
        }

        // parametized construtor.
        public IntegerSet(int[] arrayinteger) : this()
        {
            for (int i = 0; i < arrayinteger.Length; i++)
            {
                if (arrayinteger[i] >= 0 && arrayinteger[i] < 101)
                    set[arrayinteger[i]] = true;
            }
        }

        // Union method assigns true if element is present in either or both the sets.
        public IntegerSet Union(IntegerSet set2)
        {
            IntegerSet set3 = new IntegerSet();

            for (int i = 0; i < setSize; i++)
            {
                if (set[i] || set2.set[i])
                    set3.set[i] = true;
            }

            return set3;
        }

        // Intersection method assigns false if element is not present in either or both the sets.
        public IntegerSet Intersection(IntegerSet set2)
        {
            IntegerSet set3 = new IntegerSet();

            for (int i = 0; i < setSize; i++)
            {
                if (set[i] && set2.set[i])
                    set3.set[i] = true;
            }

            return set3;
        }

        // InsertElement inserts a new integer into a existing set.
        public void InsertElement(int number)
        {
            set[number] = true;
        }

        // DeleteElement deletes an integer from set
        public void DeleteElement(int number)
        {
            set[number] = false;
        }

        // ToString returns a string containing a set of all existing numbers.  
        public override String ToString()
        {
            String output = "{";
            for (int i = 0;i < setSize; i++)
            {
                if (set[i] == true)
                    output = output + i + " ";
            }
            output = output + "}";

            return output;
        }

        // IsEqualTo determines whether two sets are equal.
        public Boolean IsEqualTo(IntegerSet set2)
        {
            IntegerSet set4 = new IntegerSet();
            Boolean flag = true;
            for (int i = 0; i < setSize; i++)
            {
                if (!set[i].Equals(set2.set[i]))
                {
                    flag = false;
                    break;
                }
                 
            }
            return flag;
            
          }
    }
}
