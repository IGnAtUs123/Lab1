// See https://aka.ms/new-console-template for more information

using System;
namespace MyApp
{
    using Logic;
    using System.Text;

    internal class Program
    {
        static string HistogramToString(Dictionary<string, int> histogram)
        {
            int max = histogram.Values.Max();
            var keys = histogram.Keys.ToList();

            const int cellWidth = 7; // ширина ячейки под колонку
            var sb = new StringBuilder();
            sb.AppendLine(new string('-', keys.Count * cellWidth));

            // строим сверху вниз
            for (int level = max; level >= 1; level--)
            {
                foreach (var key in keys)
                {
                    if (histogram[key] >= level)
                        sb.Append("  *   ".PadLeft(cellWidth / 2 + 2).PadRight(cellWidth));
                    else
                        sb.Append("".PadLeft(cellWidth));
                }
                sb.AppendLine();
            }

            // разделитель
            sb.AppendLine(new string('-', keys.Count * cellWidth));

            // подписи под колонками (центрирование)
            foreach (var key in keys)
            {
                string label = key.Length > cellWidth ? key[..cellWidth] : key;
                int padLeft = (cellWidth - label.Length) / 2 + label.Length;
                sb.Append(label.PadLeft(padLeft).PadRight(cellWidth));
            }
            sb.AppendLine();

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            var logic = new Logic();
            
            while (true)
            {
                Console.WriteLine("Чтобы добавить студента введите 1\nЧтобы удалить студента введите 2\nЧтобы просмотреть список студентов введите 3\nЧтобы просмотреть гистограму введите 4\nЧтобы закончить работу нажмите любую кнопку\n");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Введите имя студена:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите специальность студена:");
                    string speciality = Console.ReadLine();

                    Console.WriteLine("Введите группу студена:");
                    string group = Console.ReadLine();

                    Console.WriteLine("Введите студенческий билет студена:");
                    string id = Console.ReadLine();

                    logic.AddStudent(name, speciality, group, id);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Введите студенческий билет студена:");
                    string id = Console.ReadLine();

                    logic.DeleteStudent(id);
                }
                else if (i == 3)
                {
                    foreach (var j in logic.ShowTheListOfStudents())
                    {
                        Console.WriteLine($"Имя: {j.Name}, Специальность: {j.Speciality}, Группа: {j.Group}, Студенческий билет: {j.Id}");
                    }
                }
                else if (i == 4)
                {
                    var studentData = logic.ShowTheHistogram().GroupBy(x => x.Speciality).ToDictionary(g => g.Key, g => g.Count());
                    Console.WriteLine(HistogramToString(studentData));
                }
                else
                {
                    break;
                }
            }
            string exit = Console.ReadLine();
        }
    }
}
