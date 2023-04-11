using System;

public class GenericClass<T>
{
    private T _data;

    public GenericClass(T data)
    {
        _data = data;
    }

    public T GetData()
    {
        return _data;
    }

    public void SetData(T data)
    {
        _data = data;
    }
}

class Program
{
    static void Main(string[] args)
    {

        GenericClass<int> myIntClass = new GenericClass<int>(42);


        int myIntData = myIntClass.GetData();
        Console.WriteLine("Data: " + myIntData); 


    }
}
