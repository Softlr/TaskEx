namespace Softlr.TaskEx.Tests;

[ExcludeFromCodeCoverage]
public class TaskExTests
{
    [Theory]
    [AutoData]
    public async Task Awaiting_2_tasks_should_complete_them(Task task1, Task task2)
    {
        await (task1, task2);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_2_tasks_should_return_their_results(Task<int> task1, Task<int> task2)
    {
        var (result1, result2) = await (task1, task2);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_3_tasks_should_complete_them(Task task1, Task task2, Task task3)
    {
        await (task1, task2, task3);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_3_tasks_should_return_their_results(Task<int> task1, Task<int> task2, Task<int> task3)
    {
        var (result1, result2, result3) = await (task1, task2, task3);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
        result3.Should().Be(await task3!);
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_4_tasks_should_complete_them(Task task1, Task task2, Task task3, Task task4)
    {
        await (task1, task2, task3, task4);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
        task3!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_4_tasks_should_return_their_results(
        Task<int> task1, Task<int> task2, Task<int> task3, Task<int> task4)
    {
        var (result1, result2, result3, result4) = await (task1, task2, task3, task4);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
        result3.Should().Be(await task3!);
        result4.Should().Be(await task4!);
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_5_tasks_should_complete_them(Task task1, Task task2, Task task3, Task task4, Task task5)
    {
        await (task1, task2, task3, task4, task5);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
        task3!.IsCompleted.Should().BeTrue();
        task4!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_5_tasks_should_return_their_results(
        Task<int> task1, Task<int> task2, Task<int> task3, Task<int> task4, Task<int> task5)
    {
        var (result1, result2, result3, result4, result5) = await (task1, task2, task3, task4, task5);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
        result3.Should().Be(await task3!);
        result4.Should().Be(await task4!);
        result5.Should().Be(await task5!);
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_6_tasks_should_complete_them(
        Task task1, Task task2, Task task3, Task task4, Task task5, Task task6)
    {
        await (task1, task2, task3, task4, task5, task6);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
        task3!.IsCompleted.Should().BeTrue();
        task4!.IsCompleted.Should().BeTrue();
        task5!.IsCompleted.Should().BeTrue();
        task6!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_6_tasks_should_return_their_results(
        Task<int> task1, Task<int> task2, Task<int> task3, Task<int> task4, Task<int> task5, Task<int> task6)
    {
        var (result1, result2, result3, result4, result5, result6) = await (task1, task2, task3, task4, task5, task6);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
        result3.Should().Be(await task3!);
        result4.Should().Be(await task4!);
        result5.Should().Be(await task5!);
        result6.Should().Be(await task6!);
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_7_tasks_should_complete_them(
        Task task1, Task task2, Task task3, Task task4, Task task5, Task task6, Task task7)
    {
        await (task1, task2, task3, task4, task5, task6, task7);

        task1!.IsCompleted.Should().BeTrue();
        task2!.IsCompleted.Should().BeTrue();
        task3!.IsCompleted.Should().BeTrue();
        task4!.IsCompleted.Should().BeTrue();
        task5!.IsCompleted.Should().BeTrue();
        task6!.IsCompleted.Should().BeTrue();
        task7!.IsCompleted.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public async Task Awaiting_7_tasks_should_return_their_results(
        Task<int> task1,
        Task<int> task2,
        Task<int> task3,
        Task<int> task4,
        Task<int> task5,
        Task<int> task6,
        Task<int> task7)
    {
        var (result1, result2, result3, result4, result5, result6, result7) =
            await (task1, task2, task3, task4, task5, task6, task7);

        result1.Should().Be(await task1!);
        result2.Should().Be(await task2!);
        result3.Should().Be(await task3!);
        result4.Should().Be(await task4!);
        result5.Should().Be(await task5!);
        result6.Should().Be(await task6!);
        result7.Should().Be(await task7!);
    }
}
