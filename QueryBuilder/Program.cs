using System;
using System.Net.Http;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 기본 쿼리 ===");
QueryBuilder query1 = new QueryBuilder()
    .Select("*")
    .From("Users");
Console.WriteLine(query1.Build());
Console.WriteLine("=== 조건 쿼리 ===");
QueryBuilder query2 = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18");
Console.WriteLine(query2.Build());
Console.WriteLine("=== 정렬 쿼리 ===");
QueryBuilder query3 = new QueryBuilder()
    .Select("*")
    .From("Products")
    .Where("Price > 1000")
    .OrderBy("Price");
Console.WriteLine(query3.Build());  

