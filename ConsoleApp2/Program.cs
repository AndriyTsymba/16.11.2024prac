//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 3, 4, 5, 6, 2, 3, 7, 8, 9, 10 };
//            int evenCount = 0;
//            int oddCount = 0;
//            int uniqueCount = 0;
//            bool[] checkedNumbers = new bool[101];
//            foreach (var number in array)
//            {
//                if (number % 2 == 0)
//                {
//                    evenCount++;
//                }
//                else
//                {
//                    oddCount++;
//                }

//                if (!checkedNumbers[number])
//                {
//                    checkedNumbers[number] = true;
//                    uniqueCount++;
//                }
//            }
//            Console.WriteLine("Кількість парних елементів: " + evenCount);
//            Console.WriteLine("Кількість непарних елементів: " + oddCount);
//            Console.WriteLine("Кількість унікальних елементів: " + uniqueCount);
//        }
//    }
//}

//2
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 3, 5, 7, 9, 11, 2, 6, 8, 4 };
//            Console.Write("Введіть число для порівняння: ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int count = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] < a)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine($"Кількість елементів, менших за {a}: {count}");
//        }
//    }

//}
//3
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
//            Console.WriteLine("Введіть три числа через пробіл:");
//            string a = Console.ReadLine();
//            string[] parts = a.Split(' ');
//            int num1 = int.Parse(parts[0]);
//            int num2 = int.Parse(parts[1]);
//            int num3 = int.Parse(parts[2]);
//            int count = 0;

//            for (int i = 0; i < array.Length - 2; i++)
//            {
//                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);

//        }
//    }
//}

//4
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array1 = { 1, 2, 5, 6, 10 };
//            int[] array2 = { 6, 10, 9, 7, 8 };
//            int[] resultArray = new int[array1.Length];
//            int resultIndex = 0;
//            for (int i = 0; i < array1.Length; i++)
//            {
//                for (int j = 0; j < array2.Length; j++)
//                {
//                    if (array1[i] == array2[j])
//                    {
//                        bool exists = false;
//                        for (int k = 0; k < resultIndex; k++)
//                        {
//                            if (resultArray[k] == array1[i])
//                            {
//                                exists = true;
//                                break;
//                            }
//                        }
//                        if (!exists)
//                        {
//                            resultArray[resultIndex++] = array1[i];
//                        }
//                    }
//                }
//            }
//            Console.WriteLine("Спільні елементи без повторень:");
//            for (int i = 0; i < resultIndex; i++)
//            {
//                Console.Write(resultArray[i] + " ");
//            }
//        }
//    }
//}


//5

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] array = {
//            { 12,5,8,3,17},
//            { 7,15,3,4,2 },

//        };
//            int min = array[0, 0];
//            int max = array[0, 0];
//            for (int i = 0; i < array.GetLength(0); i++)  
//            {
//                for (int j = 0; j < array.GetLength(1); j++)  
//                {
//                    if (array[i, j] < min)
//                    {
//                        min = array[i, j];  
//                    }
//                    if (array[i, j] > max)
//                    {
//                        max = array[i, j]; 
//                    }
//                }
//            }
//            Console.WriteLine($"Мінімальне значення: {min}");
//            Console.WriteLine($"Максимальне значення: {max}");
//        }
//    }
//}
//6

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Введіть речення:");
//            string input = Console.ReadLine();
//            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            int wordCount = words.Length;
//            Console.WriteLine($"Кількість слів у реченні: {wordCount}");
//        }

//    }

//}
//7
//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть речення:");
//            string input = Console.ReadLine();
//            string[] words = input.Split(' ');
//            string[] reversedWords = new string[words.Length];
//            for (int i = 0; i < words.Length; i++)
//            {
//                char[] wordArray = words[i].ToCharArray();  
//                Array.Reverse(wordArray);  
//                reversedWords[i] = new string(wordArray);  
//            }
//            string result = string.Join(" ", reversedWords);
//            Console.WriteLine("Після перевороту: ");
//            Console.WriteLine(result);

//        }
//    }
//}
//8

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть речення:");
//            string input = Console.ReadLine();
//            input = input.ToLower();
//            int vowelCount = 0;
//            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
//            foreach (char c in input)
//            {
//                if (Array.Exists(vowels, v => v == c))
//                {
//                    vowelCount++;
//                }
//            }
//            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");

//        }
//    }
//}

//9
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть вихідний рядок:");
            string inputString = Console.ReadLine();  
            Console.WriteLine("Введіть підрядок для пошуку:");
            string searchWord = Console.ReadLine();  
            int count = 0;
            int startIndex = 0;
            while ((startIndex = inputString.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                startIndex += searchWord.Length;
            }
            Console.WriteLine($"Результат пошуку: {count}");

        }
    }
}




