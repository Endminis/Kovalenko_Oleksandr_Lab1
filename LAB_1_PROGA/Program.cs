using Newtonsoft.Json;

public class String
{
    private string str1 = "";
    private string str2 = "";

    public string Str1
    {
    get
        {
            return str1;
        }
        set
        {
            str1 = value;
        }
        }   public string Str2
    {
    get
        {
            return str2;
        }
        set
        {
            str2 = value;
        }
        }

    public string concatenate(string str1, string str2)
    {
        return str1 + str2;
    }
    public string removeSubstring(string str1, string str2)
    {
        if (str1.IndexOf(str2) != -1)
        {
            return str1.Remove(str1.IndexOf(str2), str2.Length);
        } else
        {
            return "Другого рядка немає в першому!";
        }
    }
    public string compare(string str1, string str2)
    {
        if (str1.Equals(str2))
        {
            return "Рядки однакові";
        } else 
        {
              if(str1.Length == str2.Length)
            {
                return "Однакова довжина, але рядки не рівні";
            } else if(str1.Length > str2.Length)
            {
                return "Перший рядок більший за другий";
            } else {
                return "Перший рядок менший за другий";
                    }
        }
    }
    static void Main(string[] args)
    {  
        
        String s = new String();
        Console.WriteLine("Введіть перший рядок");
        s.str1 = Console.ReadLine();
        Console.WriteLine("Введіть другий рядок");
         s.str2 = Console.ReadLine();
        string output = JsonConvert.SerializeObject(s);

        String deserializedProduct = JsonConvert.DeserializeObject<String>(output);

        if (deserializedProduct != null)
        {
            Console.WriteLine("Введіть:\n1 - конкатенація двох рядків\n2 - вирізання підрядка\n3 - порівняння двох рядків");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Результат:\n" + deserializedProduct.concatenate(deserializedProduct.str1, deserializedProduct.str2));
                    break;
                case 2:
                    Console.WriteLine("Результат:\n" + deserializedProduct.removeSubstring(deserializedProduct.str1, deserializedProduct.str2));
                    break;
                case 3:
                    Console.WriteLine("Результат:\n" + deserializedProduct.compare(deserializedProduct.str1, deserializedProduct.str2));
                    break;
                default:
                    Console.WriteLine("Не можу розпізнати метод!");
                    break;
            }

        } else
        {
            Console.WriteLine("Неправильно введений рядок!");
        }
    }
}
