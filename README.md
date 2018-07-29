# TypedMethodBuilder

The IL MethodBuidler with typed callstack representation and automatic delegate type determination


## What's this

experimental project :)

```csharp
private IEnumerable<string> MyFunc()
    => new[] { "abc", "def", "ghi" };

static void Main()
{
    var instance = this;

    var f = IL<MyClass> // an instance type
        .MethodBuilder<int, string>() // define parameters. (int, string) => { ? }
        .Ldarg_2() // load parameter. stack: [ string ]
        .Call(int.Parse) // call static method. stack: [ string ] => [ int ]
        .Ldarg_1() // load parameter. stack: [ int, int ]
        .Add() // add two int. stack: [ int, int ] => [ int ]
        .Call((Action<int>)Console.WriteLine) // call static method, type annotation with cast expression. stack: [ int ] => []
        .Ldarg_0() // load 'this'. stack: [] => [ MyClass ]
        .CallInstance(instance.MyFunc) // call instance method. stack: [ MyClass ] => [ IEnumerable<string> ]

        // .Pop() // <- if you uncomment this, callstack is popped, the Build() result type is Action<int, string> !

        .Build(instance); // create delegate, the delegate type is Func<int, string, IEnumerable<string>>
}
```

# TODO
too many todos...
