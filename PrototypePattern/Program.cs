// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Protoype design pattern nesne oluşturma maliyetli ve çok kaynak gerektiren bir iş olduğunda bir nesne yaratmak yerine benzer bir nesneyi kullanrak işlemlerin gerçekleiştirilmesi için kullanılır.
 * 
 */

//using PrototypePattern.Sample1;
//using System;

//Employee employee = new Employee();
//employee.LoadData();

//Employee employee1 = (Employee)employee.Clone();
//Employee employee2 = (Employee)employee1.Clone();

//List<string> list = employee2.GetEmployees();
//list.Add("Philip");

//Console.WriteLine("Employee");
//foreach (string item in employee.GetEmployees())
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(new string('*', 100));

//Console.WriteLine("Employee 1 Clone");
//foreach (var item in employee1.GetEmployees())
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(new string('*', 100));

//Console.WriteLine("Employee 2 Clone");
//foreach (var item in employee2.GetEmployees())
//{
//    Console.WriteLine(item);
//}

using PrototypePattern.Sample2;

Game g1 = new Game(1, "TempleRun", "Single", true);
Game g2 = (Game)g1.Clone();
Game g3 = g1;

Console.WriteLine($"g1 : {g1.GameName} - {g1.GameType}\n" +
    $"g2 : {g2.GameName} - {g2.GameType}\n" +
    $"g3 : {g3.GameName} - {g3.GameType}");

g1.GameName = "Call Of Duty";

Console.WriteLine(new string('*', 100));

Console.WriteLine($"g1 : {g1.GameName} - {g1.GameType}\n" +
    $"g2 : {g2.GameName} - {g2.GameType}\n" +
    $"g3 : {g3.GameName} - {g3.GameType}");

if (g1.Equals(g2))
    Console.WriteLine("Tipler Aynı");
else
    Console.WriteLine("Tipler Farklı");

