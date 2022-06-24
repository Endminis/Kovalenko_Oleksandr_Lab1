using Newtonsoft.Json;
    Console.WriteLine("Введіть перший рядок");
    string string1 = Console.ReadLine();
    Console.WriteLine("Введіть другий рядок");
    string string2 = Console.ReadLine();
if (string1 != null && string2 != null)
{
    String mainString = new()
    {
        Str = string1
    };

    var output = JsonConvert.SerializeObject(mainString);
    var deserializedProduct = JsonConvert.DeserializeObject<String>(output);
    if (deserializedProduct != null)
    {
        Console.WriteLine("Введіть:\n1 - конкатенація двох рядків\n2 - вирізання підрядка\n3 - порівняння двох рядків");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Результат:\n" + deserializedProduct.Concatenate(string2));
                break;
            case 2:
                Console.WriteLine("Результат:\n" + deserializedProduct.RemoveSubstring(string2));
                break;
            case 3:
                Console.WriteLine("Результат:\n" + deserializedProduct.Compare(string2));
                break;
            default:
                Console.WriteLine("Не можу розпізнати метод!");
                break;
        }
    }
}
else
{
    Console.WriteLine("Неправильно введений рядок!");
}