// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Farklı nesne gruplarının iletişim kurma şeklini özetleyerek gevşek bağlantıya izin verir. Her nesne kümesinin birbirinden bağımsız olarak değişmesine izin verir.
 * 
 * 
 */

using MediatrPattern;

IChatMediator mediator = new ChatMediator();
User user1 = new UserImplement(mediator, "John Doe");
User user2 = new UserImplement(mediator, "Jeyn Doe");
User user3 = new UserImplement(mediator, "Tom Doe");
User user4 = new UserImplement(mediator, "Ted Doe");

mediator.addUser(user1);
mediator.addUser(user2);
mediator.addUser(user3);
mediator.addUser(user4);

user1.Send("Dünya Barışı");
