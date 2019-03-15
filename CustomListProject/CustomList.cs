using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        // Member Variables
        private int count = 0;
        private int capacity;
        private T[] myArray;

        // Indexer property for our 
        public T this[int i]
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
        }

        private int Capacity
        {
            get
            {
                return capacity;
            }

        }
        public int Count
        {
            // Makes count a read-only property 
            get
            {
                return count;
            }
        }


        // Constructors 
        public CustomList()
        {
            capacity = 10;
            count = 0;
            myArray = new T[capacity];

        }




        // Methods 
        // Adds item into list T. T item refers to the item being added into T list. 
        public void Add(T item)
        {
            if (count >= capacity)
            // if the capacity is reached, we must increase it. 
            {
                // Increases capacity by 10 when count of items is higher than the capacity of the list. 
                capacity += 10;
                // Setup temporary array to store overflow of items. the new capacity created above is the new "ceiling" for this temporary array.
                T[] newArray = new T[capacity];

                // Loops through the previous, smaller array and adds the items to the new array. 
                for (int i = 0; i < count; i++)
                {
                    // item from original array is equal to item of new array in the same index
                    newArray[i] = myArray[i];

                }
                // sets the new array equal to another array that has the same label as our old array. 
                // The carrying capacity of our new, temporary array is also transferred to this new array, since they are "equal"
                myArray = newArray;
                // Adds the new requested item into our newly formed array (labeled as the old array)
                myArray[count] = item;
                count++;

            }
            else
            // Normal path when capacity is not reached. 
            // Adds item based on the last available index (count). 
            // Count then increases by 1 to make room for next available index.
            {

                myArray[count] = item;
                count++;
            }

           

        }
        public void Remove(T item)
        {
            if (count <= 0)
            {
                throw new System.ArgumentException("You cannot go below zero items in your list.");
            }
            
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (i = myArray.)

                }
            
               
                
                

            }
        }
    }

     
}
