// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var hoje = DateTime.Today;
var agora = DateTime.Now;

var data1 = new DateTime(2023, 07, 28);
var data2 = new DateTime(2023, 07, 28, 15, 55, 30);

var data3 = DateTime.Parse("25/05/1974 08:20:33");

Console.WriteLine(hoje);
Console.WriteLine(agora);
Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);

Console.WriteLine(data3.Day);
Console.WriteLine(data3.Month);
Console.WriteLine(data3.Year);
Console.WriteLine(data3.Hour);
Console.WriteLine(data3.Minute);
Console.WriteLine(data3.Second);
Console.WriteLine(data3.Microsecond);

Console.WriteLine(data3.AddDays(5));
Console.WriteLine(data3.AddMonths(-2));

Console.WriteLine(data3.ToLongDateString());
Console.WriteLine(data3.ToLongTimeString());

Console.WriteLine(data3.ToShortDateString());
Console.WriteLine(data3.ToShortTimeString());