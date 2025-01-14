public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it
        MyProperty = 10; 
        Console.WriteLine(MyProperty); // Corrected: MyProperty is now initialized
    }
}