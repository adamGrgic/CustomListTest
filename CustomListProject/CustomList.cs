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
        string myString = "";

        // Indexer property for myArray
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
        //Remove item T from a list 
        public void Remove(T item)
        {

            // If the count falls below 0, it goes into a negative list item which we dont want / isnt possible. 
            if (count <= 0)
            {
                // system tells the user not to go below zero 
                throw new System.ArgumentException("You cannot go below zero items in your list.");
            }
            
            else
            {
                // Create new array to store the removed object 
                T[] newArray = new T[capacity];

                // run a for loop to match user input to list item 
                for (int i = 0; i < count; i++)
                {
                    // Conditional to check which item is equal to the list item
                    if (!(myArray[i].Equals(item)))
                    {
                        // Array item that doesn't fit the search is moved into a new array 
                        newArray[i] = myArray[i];
                        

                    }
                    else if (myArray[i].Equals(item)) 
                    {
                        
                    }

                }

            count--;
            myArray = newArray;  

            }
        }

        // ToString overrides ConverValuesToString() method 
        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++) {
                // The result of ConverValuesToString() is myString which is converted to newString 
                newString += ConvertValuesToString(); 
            }
            return newString;
        }
        // Convert list items into a fluid string 
        private string ConvertValuesToString()
        {
            // for loop that runs through values in our custom list (myArray)
            for (int i = 0; i < count; i++)
            {
                // each item of myArray is added to myString to create one string. 
                myString += myArray[i];
            }
            return myString;
        }


        // Overload plus operator 
        // Overload is when a method has more than one combination of parameters 
        public static CustomList<T> operator +(CustomList<T> oneArray, CustomList<T> twoArray)
        {
            // Create generic list, type T, titled combinedArray 
            CustomList<T> combinedArray = new CustomList<T>();

            for (int i = 0; i < oneArray.count; i++)
            {
                combinedArray.Add(oneArray[i]);
            }

            for (int i = 0; i < twoArray.count; i++)
            {
                combinedArray.Add(twoArray[i]);
            }

            return combinedArray;
        }

        public static CustomList<T> operator +(CustomList<T> oneArray, CustomList<T> twoArray, CustomList<T> threeArray)
        {
            // Create generic list, type T, titled combinedArray 
            CustomList<T> combinedArray = new CustomList<T>();

            for (int i = 0; i < oneArray.count; i++)
            {
                combinedArray.Add(oneArray[i]);
            }

            for (int i = 0; i < twoArray.count; i++)
            {
                combinedArray.Add(twoArray[i]);
            }

            for (int i = 0; i < threeArray.count; i++)
            {
                combinedArray.Add(threeArray[i]);
            }
            return combinedArray;
        }






    }

     
}
