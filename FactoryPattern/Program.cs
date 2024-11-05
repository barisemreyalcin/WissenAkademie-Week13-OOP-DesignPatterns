// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Birden fazla sub-class(alt sınıf) sahip olduğumuz bir super-class(üst sınıf) olduğu senaryolarda bir parametreye bağlı olarak alt sınıfların hangisinin örneğinin alınmasına karar verilmesi gerektiğinde Factory Pattern Kullanılır
 * 
 * 
 */

using FactoryPattern.Sample1;
using FactoryPattern.Sample2;
//CreatorComputer gamePC = FactoryCreator.FactoryComputer("gamePC", "64GB", "256GB", "100TB", ".5 Ghz");

//CreatorComputer developerPC = FactoryCreator.FactoryComputer("developerPC", "64GB", "128GB", "5TB", "4.3 Ghz");

//Console.WriteLine(gamePC.ToString());
//Console.WriteLine(developerPC.ToString());

ICreatorMobileApp appWindows = FactoryMobilApp.CreateMobilApp("windows");
ICreatorMobileApp appIos = FactoryMobilApp.CreateMobilApp("ios");
ICreatorMobileApp appAndroid = FactoryMobilApp.CreateMobilApp("android");

appWindows.Platform();
appIos.Platform();
appAndroid.Platform();

