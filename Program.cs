using System.ComponentModel.DataAnnotations;
using Console1.Models;

Product prod1 = new()
{
    Id = 1,
    Name = "Laptop",
    Price = 299.99,
};

prod1.Price = 279.99;

Console.WriteLine(prod1.Price);

User user1 = new()
{
    Id = 1,
    Name = "Adolf",
    Age = "kapoet",
};

User user2 = new()
{
    Id = 2,
    Name = "Noah",
    Age = "oud",
};
Console.WriteLine(user2.Age);
