
# Soup

A delegate represents a type-safe object that contains a reference to a method that matches a signature (the return type and set of arguments are checked).

```csharp
delegate int IntOperation(int a, int b);

static void Main()
{
    IntOperation op;

    // op = new IntOperation(Divide);
    op = Divide;
    // Console.WriteLine(op.Invoke(15, 5)); // 3
    Console.WriteLine(op(15, 5)); // 3

    // op = new IntOperation(Multiply);
    op = Multiply;
    // Console.WriteLine(op.Invoke(15, 5)); // 75
    Console.WriteLine(op(15, 5)); // 75
}

static int Divide(int x, int y)
{
    return x / y;
}

static int Multiply(int x, int y)
{
    return x * y;
}
```

An example with anonymous functions:

```csharp
delegate int IntOperation(int a, int b);

static void Main()
{
    IntOperation op;

    op = delegate (int x, int y) { return x / y; };
    Console.WriteLine(op(15, 5)); // 3

    op = delegate (int x, int y) { return x * y; };
    Console.WriteLine(op(15, 5)); // 75
}
```

An example with lambdas:

```csharp
delegate int IntOperation(int a, int b);

static void Main()
{
    IntOperation op;

    // op = (int x, int y) => { return x / y; };
    op = (x, y) => x / y;
    Console.WriteLine(op(15, 5)); // 3

    // op = (int x, int y) => { return x * y; };
    op = (x, y) => x * y;
    Console.WriteLine(op(15, 5)); // 75
}
```

An example with invocation list:

```csharp
delegate int IntOperation(int a, int b);

static void Main()
{
    IntOperation op;

    op = (x, y) => x / y;
    op+= (x, y) => x * y;

    Console.WriteLine(op.GetInvocationList().Length); // 2
    Console.WriteLine(op.GetInvocationList()[0].DynamicInvoke(15, 5)); // 3
    Console.WriteLine(op.GetInvocationList()[1].DynamicInvoke(15, 5)); // 75
}
```
