using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class collctionPractice
    {
        public static void Main()
        {
            MyList l = new MyList();
            // Add some elements
            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Remove(20);
            l.display();

            Console.ReadLine();
        }

    }
}

public class MyList
{
    public int[] arr;
    public int capacity;
    public int size;

    public MyList()
    {
        capacity = 5;
        arr = new int[cap];
        size = 0;
    }

    public void Add(int item)
    {
        if (size == capacity)
        {
            capacity = capacity * 2;
            Array.Resize(ref arr, capacity);
        }
        arr[size] = item;
        size++;
    }
    public void RemoveAt(int ind)
    {
        if (ind < 0 || ind >= size)
        {
            Console.WriteLine("index not present in the list");
        }
        for (int j = ind; j < size - 1; j++)
        {
            arr[j] = arr[j + 1];
        }
        size--;
    }
    public void Remove(int val)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (arr[i] == val)
            {
                RemoveAt(i);
            }
        }
    }
    public void update(int ind, int val)
    {
        if (ind < 0 || ind >= size)
        {
            Console.WriteLine("index out of range");
        }
        arr[ind] = val;
    }

    public int count()
    {
        return size;
    }
    public void display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}




