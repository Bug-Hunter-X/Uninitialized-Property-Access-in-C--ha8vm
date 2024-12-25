public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized
        int value = MyProperty; // This could throw a NullReferenceException if MyProperty is a reference type and null
        // Do something with the value
    }
}