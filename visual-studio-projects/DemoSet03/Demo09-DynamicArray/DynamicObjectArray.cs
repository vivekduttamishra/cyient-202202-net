using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_DynamicArray
{
    class DynamicObjectArray
    {
        object[] array; //this is a normal array that we will dynamic
        int size;
        int initialSize;

        public int Length { get { return size; } }      //how much it is currently holding
        public int Capacity { get { return array.Length; } } //how much array can hold

        

        public DynamicObjectArray(int size)
        {
            array = new string[size];
            initialSize = size;
        }

        public DynamicObjectArray(params object [] values)
        {
            array = new object[values.Length];
            initialSize = values.Length;

            initialSize = values.Length;
            foreach (var value in values)
                Add(value);
        }

        public void Add(object value)
        {
            if (Length == Capacity) //array if full
                IncreaseSize();

            array[size++] = value; //add the item
        }

        private void IncreaseSize()
        {
            //You can't increase array size. Youc an only create new bigger array
            object[] newArray = new object[Capacity + initialSize];

            //You must copy your current value to the new array
            for (int i = 0; i < Capacity; i++)
                newArray[i] = array[i];

            //now forget the old array and use the array
            array = newArray;
        }

        public void Insert( int pos, object value)
        {
            if (Capacity == size) //array is Full
                IncreaseSize();

            //first move items to make space
            for(int i=size-1; i>=pos; i--)
            {
                array[i + 1] = array[i]; //move towards right
            }

            array[pos] = value;
            size++; 
        }

        public void Remove(int pos)
        {
            for (int i = pos; i < size ; i++)
            {
                
                array[i] = array[i + 1];
            }
                

            size--;
        }



        public object this [ int index]
        {
            get
            {
                if (index < 0 || index >= Length) //wrong index
                    return null; //what should I do here?

                return array[index];
            }

            set
            {
                if (index < 0 || index >= Length) //wrong index
                    return;

                array[index]=value;
            }


        }


        public override string ToString()
        {
            if (Length == 0)
                return "DynamicArray(empty)";

            var str = "DynamicArray" +  (Length==Capacity?"[\t":"(\t");

            for (int i = 0; i < Length; i++)
                str += $"{array[i]}\t";

            str += Length == Capacity ? "]" : ")";

            return str;
            

        }

    }
}





