using Newtonsoft.Json;


        String string1 = new String();
        String string2 = new String();
        Console.WriteLine("Введіть перший рядок");
        string1.Str = Console.ReadLine();
        Console.WriteLine("Введіть другий рядок");
        string2.Str = Console.ReadLine();
        var output1 = JsonConvert.SerializeObject(string1);
        var output2 = JsonConvert.SerializeObject(string2);

        String deserializedProduct1 = JsonConvert.DeserializeObject<String>(output1);
        String deserializedProduct2 = JsonConvert.DeserializeObject<String>(output2);

        if (deserializedProduct1 != null && deserializedProduct2 != null)
        {
            Console.WriteLine("Введіть:\n1 - конкатенація двох рядків\n2 - вирізання підрядка\n3 - порівняння двох рядків");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Результат:\n" + deserializedProduct1.concatenate(deserializedProduct1.Str, deserializedProduct2.Str));
                    break;
                case 2:
                    Console.WriteLine("Результат:\n" + deserializedProduct1.removeSubstring(deserializedProduct1.Str, deserializedProduct2.Str));
                    break;
                case 3:
                    Console.WriteLine("Результат:\n" + deserializedProduct1.compare(deserializedProduct1.Str, deserializedProduct2.Str));
                    break;
                default:
                    Console.WriteLine("Не можу розпізнати метод!");
                    break;
            }

        }
        else
        {
            Console.WriteLine("Неправильно введений рядок!");
        }
    