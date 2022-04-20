![.NET](https://github.com/Softlr/TaskEx/actions/workflows/dotnet.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=taskex&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=taskex)

# Description
This library contains extensions for tasks.

## Awaiting multiple tasks
The library provides a simple way of awaiting multiple task results with as little code as possible.

Typically when you want to await multiple tasks you will be doing something like
```csharp
await Task.WhenAll(task1, task2);
```

With this library you can simplify this to
```csharp
await (task1, task2);
```

## Awaiting multiple tasks with results
But the real improvement is if you need to await multiple tasks that return some values.
Typically you'd do something like
```csharp
task1.Start();
task2.Start();
var result1 = await task1;
var result2 = await task2;
```

This can be simplified using this library to
```csharp
var (result1, result2) = await (task1, task2);
```

The results can be of completely different types, the tasks will run simultanously but the code will wait until all of the tasks finish processing.
This method can be used to await results for up to 7 tasks at the same time (7 is the limit of generic parameters of the `TaskAwaiter` class on which this code depends).