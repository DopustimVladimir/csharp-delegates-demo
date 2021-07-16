
# Soup

Делегат представляет собой безопасный в отношении типов объект, который содержит ссылку на метод, подходящий по условию (проверяется возвращаемый тип и набор аргументов).

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

Пример с анонимными функциями:

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

Пример с лямбдами:

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

Пример со списком извлечения:

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
