using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("'''");
Person person = new Person();
person.name = "홍길동";
person.age = 25;
person.Print();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Hello hi = new Hello();
hi.HI();
hi.Bye();

Console.WriteLine("'''\n");


Console.WriteLine("'''");
Console.WriteLine($"덧셈: {Calculator.Add(10, 20)}");
Console.WriteLine($"뺄셈: {Calculator.Subtract(30, 20)}");
Console.WriteLine($"곱셈: {Calculator.Multiply(10, 3)}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine(StringHelper.CleanAndUpper(" hello world "));
Console.WriteLine(StringHelper.Reverse("hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty("hello"));

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
Console.WriteLine($"최솟값: {Math.Min(10, 20)}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
StringBuilder sb1 = new StringBuilder();
sb1.Append("hello");
sb1.Append(" ");
sb1.Append("world");
string result = sb1.ToString();
Console.WriteLine(sbresult1);

string sb2 = new StringBuilder()
    .Append("hello")
    .Append(" ")
    .Append("world")
    .ToString();
Console.WriteLine(sb2);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Build();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

Console.WriteLine(point);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
string str = "  Hello World  ";
str.Trim()
    .ToLower()
    .Replace(" ", "_");
Console.WriteLine(str);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.radius}");

circle.radius = 20;     
Console.WriteLine($"반지름: {circle.radius}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.radius}");

ImmutableCircle circle2 = circle1.WithRadius(20);  
Console.WriteLine($"새 원 반지름: {circle2.radius}");
Console.WriteLine($"원본 반지름: {circle1.radius}");  

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUP();

Console.WriteLine($"player1: {player1.name}, 레벨 {player1.level}");
Console.WriteLine($"player2: {player2.name}, 레벨 {player2.level}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
string str1 = "Hello";
string str2 = str1.ToUpper();
Console.WriteLine($"원본: {str1}");
Console.WriteLine($"수정본: {str2}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Character hero = new Character("용사");

hero.TakeDamage(30);
hero.Heal(10);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine($"계산된 데미지: {GameHelper.CalculateDamage(10, 5)}");
Console.WriteLine($"생존 여부: {50}");
Console.WriteLine($"체력 상태: {30, 100}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Vector2D result1 = new Vector2D(1, 1)
    .Add(2, 3)       
    .Multiply(2)     
    .Add(-1, -2);    

Console.WriteLine($"결과 벡터: {result}");

Console.WriteLine("'''\n");

partial class Person
{
    public string name;
    public int age;
}
partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{name}: {age}");
    }
}

partial class Hello
{
    public void HI()
    {
        Console.WriteLine($"안녕하세요!");
    }
}
partial class Hello
{
    public void Bye()
    {
        Console.WriteLine($"안녕히 가세요!");
    }
}

static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }
    public static string Reverse(string input)
    {
        char[] ary = input.ToCharArray();
        Array.Reverse(ary);
        return new string(ary);
    }
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}

public class MessageBuilder
{
    private string message="";
    public MessageBuilder AddText(string text)
    {
        message += text;
        return this;
    }
    public MessageBuilder AddSpace()
    {
        message += " ";
        return this;
    }
    public MessageBuilder AddNewLine()
    {
        message += "\n";
        return this;
    }
    public string Build()
    {
        return message;
    }
}

public class Point
{
    public readonly int x;
    public readonly int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point MoveBy(int dx, int dy)
    {
        return new Point(x + dx, y + dy);
    }

    public string Tostring(int x, int y)
    {
        return $"{x}, {y}";
    }

}

class MutableCircle
{
    public int radius {  get; set; }

    public MutableCircle(int radius)
    {
        this.radius = radius;
    }
}

class ImmutableCircle
{
    public int radius { get; }

    public ImmutableCircle(int radius)
    {
        this.radius = radius;
    }

    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

class Player
{
    public readonly string name;
    public readonly int level;

    public Player(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
    public Player LevelUP()
    {
        return new Player(name,level+1);
    }
}

partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 10;
    }
}
partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if( _health < 0 )
        {
            _health = 0;
        }
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }
    public void Heal(int amount)
    {
        _health += amount;
        Console.WriteLine($"{_name}이(가) {amount}만큼 회복함. 현재 체력: {_health}");
    }
}

static class GameHelper
{
    public static int CalculateDamage(int basedamage, int level)
    {
        return basedamage * (level + 5);
    }
    public static bool IsAlive(int health)
    {
        return health > 0; 
    }
    public static string GetHealthStatus(int health,int maxHealth)
    {
        if (maxHealth <= 0)
        {
            return health > 0 ? "오류" : "사망";
        }

        double ratio = (double)health / maxHealth;

        if (ratio > 0.7)
        {
            return "양호";
        }
        else if (ratio > 0.3)
        {
            return "주의";
        }
        else if (ratio > 0)
        {
            return "위험";
        }
        else
        {
            return "사망";
        }
    }
}

class Vector2D
{
    public readonly double x;
    public readonly double y;

    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(this.x + x, this.y + y);
    }
    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(scalar * x, scalar * y);
    }
    public string Tostring()
    {
        return $"({x}, {y})";
    }
}