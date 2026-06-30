using System;

// ====== 1. Базовый абстрактный класс Task (Prototype) ======
public abstract class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }

    // Метод клонирования (Prototype)
    public abstract Task Clone();

    public override string ToString()
    {
        return $"{GetType().Name,-15} | {Title,-20} | До: {DueDate.ToShortDateString()}";
    }
}

// ====== 2. Простая задача ======
public class SimpleTask : Task
{
    public SimpleTask(string title, string description, DateTime dueDate)
        : base(title, description, dueDate) { }

    public override Task Clone()
    {
        return new SimpleTask(this.Title, this.Description, this.DueDate);
    }
}

// ====== 3. Подзадача ======
public class Subtask : Task
{
    public Task ParentTask { get; set; }

    public Subtask(string title, string description, DateTime dueDate, Task parent)
        : base(title, description, dueDate)
    {
        ParentTask = parent;
    }

    public override Task Clone()
    {
        // Клонируем родительскую задачу (если есть)
        Task parentClone = ParentTask != null ? ParentTask.Clone() : null;
        return new Subtask(this.Title, this.Description, this.DueDate, parentClone);
    }
}

// ====== 4. Повторяющаяся задача ======
public class RecurringTask : Task
{
    public int RepeatIntervalDays { get; set; }
    public DateTime LastExecuted { get; set; }

    public RecurringTask(string title, string description, DateTime dueDate, int interval)
        : base(title, description, dueDate)
    {
        RepeatIntervalDays = interval;
        LastExecuted = DateTime.Now;
    }

    public override Task Clone()
    {
        return new RecurringTask(this.Title, this.Description, this.DueDate, this.RepeatIntervalDays)
        {
            LastExecuted = this.LastExecuted
        };
    }
}

// ====== 5. Главная программа ======
class Program
{
    static void Main()
    {
        Console.WriteLine("===== ПАТТЕРН PROTOTYPE (БЕЗ ICLONEABLE) =====\n");

        // --- Создаем оригиналы ---
        var simple = new SimpleTask("Купить продукты", "Молоко, хлеб, яйца", DateTime.Now.AddDays(1));
        var subtask = new Subtask("Написать отчет", "Глава 1", DateTime.Now.AddDays(2), simple);
        var recurring = new RecurringTask("Поливка цветов", "Каждые 3 дня", DateTime.Now.AddDays(3), 3);

        // --- Клонируем ---
        var simpleClone = simple.Clone();
        var subtaskClone = subtask.Clone();
        var recurringClone = recurring.Clone();

        // --- Изменяем клоны (чтобы показать независимость) ---
        simpleClone.Title = "[КЛОН] Купить продукты";
        subtaskClone.Title = "[КЛОН] Написать отчет";
        recurringClone.Title = "[КЛОН] Поливка цветов";

        // --- Вывод ---
        Console.WriteLine("ОРИГИНАЛЫ:");
        Console.WriteLine(simple);
        Console.WriteLine(subtask);
        Console.WriteLine(recurring);

        Console.WriteLine("\nКЛОНЫ (изменены):");
        Console.WriteLine(simpleClone);
        Console.WriteLine(subtaskClone);
        Console.WriteLine(recurringClone);

        // --- Дополнительная проверка: изменение ParentTask в Subtask ---
        Console.WriteLine("\n--- Проверка глубокого клонирования Subtask ---");
        var originalSubtask = (Subtask)subtask;
        var clonedSubtask = (Subtask)subtaskClone;

        Console.WriteLine($"Оригинал ParentTask: {originalSubtask.ParentTask?.Title ?? "null"}");
        Console.WriteLine($"Клон ParentTask:     {clonedSubtask.ParentTask?.Title ?? "null"}");
        Console.WriteLine($"Ссылки разные: {originalSubtask.ParentTask != clonedSubtask.ParentTask}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
