using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");

Console.WriteLine("=== 초기 화폐 ===");
Money money = new Money(100, 50);
Console.Write("지갑: ");
Console.WriteLine(money.ToString());

Console.WriteLine("=== 화폐 추가 ===");
Money money2 = money.Add(50, 30);
Console.Write("추가 후: ");
Console.WriteLine(money2.ToString());
Console.Write("원본 지갑: ");
Console.WriteLine(money.ToString());

Console.WriteLine("=== 화폐 차감 ===");
Money money3 = money.Substract(70, 50);
Console.Write("차감 후: ");
Console.WriteLine(money3.ToString());
Console.Write("원본 지갑: ");
Console.WriteLine(money.ToString());

Console.WriteLine("=== 메서드 체이닝 ===");
Console.Write("결과: ");
Console.WriteLine(money3.ToString());

Console.WriteLine("'''");



