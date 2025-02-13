public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        try
        {
            // Some code here that might cause an exception
            // ...
            int result = 10 / 0; // This line will throw a DivideByZeroException
            // ...
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception gracefully
            Console.WriteLine("Error: Division by zero encountered.");
            Console.WriteLine(ex.Message);
        }
    }
}