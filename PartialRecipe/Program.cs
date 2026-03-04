using System;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Recipe recipe1 = new Recipe("비빔밥", 2, 6);

recipe1.AddIngredient("밥");
recipe1.AddIngredient("고추장");
recipe1.AddIngredient("계란");
recipe1.AddIngredient("시금치");
recipe1.AddIngredient("당근");

recipe1.PrintRecipe();
recipe1.HasIngredient("계란");
recipe1.HasIngredient("소고기");

Recipe recipe2 = new Recipe("샌드위치", 1, 5);
recipe2.AddIngredient("빵");
recipe2.AddIngredient("햄");
recipe2.AddIngredient("치즈");

recipe2.PrintRecipe();


partial class Recipe
{
    public string Name {  get; private set; }
    public int Servings { get; private set; }
    public string[] Namespace;
    public int count = 0;
    public int maxServings;

    public Recipe(string name, int serving, int maxcount)
    {
        Name = name;
        Servings = serving;
        Namespace = new string[maxcount];
        maxServings = maxcount;

    }
}
partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if(count< maxServings)
        {
            Namespace[count] = ingredient;
            count++;
        }
        else
        {
            Console.WriteLine("재료 수가 가득 찼습니다");
        }
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");
        for(int i = 0; i < Namespace.Length; i++)
        {
            if(Namespace[i] != null)
            {
                Console.WriteLine($"{i + 1}. {Namespace[i]}");
            }
        }
    }
    public void HasIngredient(string ingredient)
    {
        bool found = false;
        for (int i = 0; i < Namespace.Length; i++)
        {
            if (Namespace[i]  == ingredient)
            {
                found = true;
                break;
            }
        }
        Console.WriteLine($"{ingredient} 포함: {found}");
    }
}