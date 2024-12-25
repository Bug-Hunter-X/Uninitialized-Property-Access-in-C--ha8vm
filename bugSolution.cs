public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it
        MyProperty = 10;
        int value = MyProperty; 
        // Do something with the value
    }
}