using System;

// Базовый класс-прототип
public abstract class Task : ICloneable
{
    public string Title { get; set; }
    public string Description { get; set; }

    public abstract Task Clone(); // глубокое клонирование

    object ICloneable.Clone() => Clone(); // явная реализация интерфейса

    public override string ToString() => $"{GetType().Name}: {Title}";
}

// Простая задача
public class SimpleTask : Task
{
    public override Task Clone() => new SimpleTask 
    { 
        Title = this.Title, 
        Description = this.Description 
    };
}

// Подзадача
public class Subtask : Task
{
    public Task ParentTask { get; set; }

    public override Task Clone() => new Subtask
    {
        Title = this.Title,
        Description = this.Description,
        ParentTask = this.ParentTask
    };
}

// Периодическая задача
public class RecurringTask : Task
{
    public int IntervalDays { get; set; }

    public override Task Clone() => new RecurringTask
    {
        Title = this.Title,
        Description = this.Description,
        IntervalDays = this.IntervalDays
    };
}

// ТЕСТИРОВАНИЕ
class Program
{
    static void Main()
    {
        var simple = new SimpleTask { Title = "Купить билеты", Description = "На поезд" };
        var clonedSimple = simple.Clone();

        var recurring = new RecurringTask { Title = "Отчёт", IntervalDays = 7 };
        var clonedRecurring = recurring.Clone();

        Console.WriteLine(simple);
        Console.WriteLine(clonedSimple);
        Console.WriteLine(recurring);
        Console.WriteLine(clonedRecurring);
    }
}
