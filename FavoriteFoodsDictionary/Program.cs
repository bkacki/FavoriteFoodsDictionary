namespace FavoriteFoodsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favoriteFoods = new Dictionary<string, string>();
            favoriteFoods["Alek"] = "hot dog";
            favoriteFoods["Asia"] = "pizza";
            favoriteFoods["Julek"] = "falafel";
            favoriteFoods["Natalka"] = "spaghetti";

            string name;

            while((name=Console.ReadLine()) != "")
            {
                if (favoriteFoods.ContainsKey(name))
                    Console.WriteLine($"Tym, co {name} lubi najbardziej, jest {favoriteFoods[name]}.");
                else
                    Console.WriteLine($"Nie wiem, co lubi {name}.");
            }
        }
    }
}
