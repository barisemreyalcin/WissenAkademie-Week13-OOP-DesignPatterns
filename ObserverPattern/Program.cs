// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Observer Pattern nesnenşn durumu/davranışını inceler ve ona göre operasyon(lar) yürütür.
 * Örneğin bir borsa app yapısını ele alalım X bir firmanın hissesinin düşüş ya da yükselişine göre kullanıcıları otomatik olarak uyaracak, kullanıcı da gelen işel alım/satım yapacak
 */

using ObserverPattern;

Subject topic = new Subject();

IObserve obj1 = new SubjectSubscribe("obj1");
IObserve obj2 = new SubjectSubscribe("obj2");
IObserve obj3 = new SubjectSubscribe("obj3");

topic.register(obj1);
topic.register(obj2);
topic.register(obj3);

//topic.unregister(obj3);

obj1.setSubject(topic);
obj2.setSubject(topic);
obj3.setSubject(topic);

obj1.Update();

topic.postMessage("New Message");
