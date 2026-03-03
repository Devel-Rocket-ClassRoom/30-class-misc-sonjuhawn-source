using System;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

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
        maxServings = maxcount;
    }
}
partial class Recipe
{
    public void AddIngredient(string ingredient)
    {

    }
}