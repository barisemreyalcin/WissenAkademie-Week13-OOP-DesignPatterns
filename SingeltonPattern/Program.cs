// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Singleton Design Pattern
 * Bir sınıfın nesnesinin sadece bir instance yaratılmas ve sürekli olarak aynı instance ile kullanılmnasını istediğimiz aman kullanımı tercihe edilir.
 * 
 * Bir sınıftan bir tane nesne alınmasından kastımız, her yazılımcının istediği zaman bu sınıfın bir nesnesini oluşturmaya çalışmaması ve oluşturamaması , var olan bir nseneyi kullanması.
 * 
 * Basic Singleton
 * Lazy Sİngleton
 * Multi Thread Singleton
 */

using SingeltonPattern;

//SystemManager systemManager = SystemManager.GetSystemManager();
//SystemManager systemManager_1 = SystemManager.GetSystemManager();
//SystemManager systemManager_2 = SystemManager.GetSystemManager();
//systemManager.CreateLog();
//Console.WriteLine(systemManager.GetHashCode());
//Console.WriteLine(systemManager_1.GetHashCode());
//Console.WriteLine(systemManager_2.GetHashCode());

SampleSingleton sample1 = SampleSingleton.GetInstance();
sample1.Data = "First Instance";

SampleSingleton sample2 = SampleSingleton.GetInstance();
SampleSingleton sample3 = SampleSingleton.GetInstance();

sample3.Data = "New Instance";

Console.WriteLine($"Object--sample1 : {sample1.Data}");
Console.WriteLine($"Object--sample2 : {sample2.Data}");
Console.WriteLine($"Object--sample3 : {sample3.Data}");


