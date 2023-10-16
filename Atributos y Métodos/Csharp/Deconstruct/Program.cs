using Deconstruct;

Person person = new("Claudia", 13);
(string name, int age) = person;
Console.WriteLine($"Nombre: {name}, Edad {age}");