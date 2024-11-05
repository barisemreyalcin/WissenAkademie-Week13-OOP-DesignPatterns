// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AbstractFactoryPattern;

CustomDatabaseOperations dbSQL = new CustomDatabaseOperations(new MSSQLDatabaseFactory());
dbSQL.GetAll();
dbSQL.GetById(1);
dbSQL.RemoveById(5);

CustomDatabaseOperations dbOracle = new CustomDatabaseOperations(new OracleDatabaseFactory());
dbOracle.GetAll();
dbOracle.GetById(2);
dbOracle.RemoveById(3);