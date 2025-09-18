namespace Morozova_ISP_231_Lab4_ClassWork_15._09._25;

class Program
{
    static void Main(string[] args)
    {
        //шаг 6
        int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3];
        int result = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
                result++;

        }
        Console.WriteLine($"Количество чисел больше нуля: {result}");

        int n = numbers.Length;
        int k = n / 2;
        int temp;
        for (int i = 0; i < k; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[n - i - 1];
            numbers[n - i - 1] = temp;
        }

        foreach (int i in numbers)
        {
            Console.WriteLine($"{i} \t");
        }

        int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; i < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        Console.WriteLine("Вывод отсортированного массива");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
        
        //шаг 7
        List<string> people1 = new List<string>();
        List<string> people2 = [];
        List<string> student1 = new List<string>() {"Иван", "Игорь", "Александр"};
        List<string> student2 = ["Иван", "Игорь", "Александр"];
        var yourStudent = new List<string>(student1);
        List<string> student3 = new List<string>(10);
        List<string> student4 = new (10);
        string firstStudent = student1[0];
        Console.WriteLine(firstStudent);
        student1[0] = "Богдан";
        Console.WriteLine(student1[0]);

        Console.WriteLine(student2.Count);

        foreach (var person in student2)
        {
            Console.WriteLine(person);
        }
        
        student3.Add("Van");
        student3.AddRange(["Anton", "Denis"]);
        student3.Insert(1, "Tom");
        student3.InsertRange(1,["Mike", "Kate"]);
        student3.Insert(7, "Min");
        foreach (var person in student3)
        {
            Console.WriteLine(person);
        }

        var people3 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };
        people3.RemoveAt(1);
        people3.Remove("Tom");
        people3.RemoveRange(1, 2);
        people3.Clear();
    }
}