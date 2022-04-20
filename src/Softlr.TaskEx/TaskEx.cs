namespace Softlr.TaskEx;

[SuppressMessage(SONARQUBE, S1172)]
[SuppressMessage(SONARQUBE, S2436)]
[SuppressMessage(SONARQUBE, S3242)]
[SuppressMessage(SONARQUBE, S4017)]
public static class TaskEx
{
    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2).GetAwaiter();

    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3).GetAwaiter();

    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task, Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4).GetAwaiter();

    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task, Task, Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5).GetAwaiter();

    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task, Task, Task, Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6).GetAwaiter();

    public static TaskAwaiter GetAwaiter(this ValueTuple<Task, Task, Task, Task, Task, Task, Task> tasks) =>
        Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6, tasks.Item7)
            .GetAwaiter();

    public static TaskAwaiter<(T1, T2)> GetAwaiter<T1, T2>(this ValueTuple<Task<T1>, Task<T2>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2).GetAwaiter();

    public static TaskAwaiter<(T1, T2, T3)> GetAwaiter<T1, T2, T3>(
        this ValueTuple<Task<T1>, Task<T2>, Task<T3>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2, tasks.Item3).GetAwaiter();

    public static TaskAwaiter<(T1, T2, T3, T4)> GetAwaiter<T1, T2, T3, T4>(
        this ValueTuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4).GetAwaiter();

    public static TaskAwaiter<(T1, T2, T3, T4, T5)> GetAwaiter<T1, T2, T3, T4, T5>(
        this ValueTuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5).GetAwaiter();

    public static TaskAwaiter<(T1, T2, T3, T4, T5, T6)> GetAwaiter<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6).GetAwaiter();

    public static TaskAwaiter<(T1, T2, T3, T4, T5, T6, T7)> GetAwaiter<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>> tasks) =>
        WhenAllAsync(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6, tasks.Item7)
            .GetAwaiter();

    private static async Task<(T1, T2)> WhenAllAsync<T1, T2>(Task<T1> task1, Task<T2> task2)
    {
        await Task.WhenAll(task1, task2);
        return (await task1, await task2);
    }

    private static async Task<(T1, T2, T3)> WhenAllAsync<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
    {
        await Task.WhenAll(task1, task2, task3);
        return (await task1, await task2, await task3);
    }

    private static async Task<(T1, T2, T3, T4)> WhenAllAsync<T1, T2, T3, T4>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
    {
        await Task.WhenAll(task1, task2, task3, task4);
        return (await task1, await task2, await task3, await task4);
    }

    private static async Task<(T1, T2, T3, T4, T5)> WhenAllAsync<T1, T2, T3, T4, T5>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
    {
        await Task.WhenAll(task1, task2, task3, task4, task5);
        return (await task1, await task2, await task3, await task4, await task5);
    }

    private static async Task<(T1, T2, T3, T4, T5, T6)> WhenAllAsync<T1, T2, T3, T4, T5, T6>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
    {
        await Task.WhenAll(task1, task2, task3, task4, task5, task6);
        return (await task1, await task2, await task3, await task4, await task5, await task6);
    }

    private static async Task<(T1, T2, T3, T4, T5, T6, T7)> WhenAllAsync<T1, T2, T3, T4, T5, T6, T7>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
    {
        await Task.WhenAll(task1, task2, task3, task4, task5, task6, task7);
        return (await task1, await task2, await task3, await task4, await task5, await task6, await task7);
    }
}
