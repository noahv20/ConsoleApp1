using System.ComponentModel.DataAnnotations;
using Console1.Models;

Product prod1 = new() { Id = 1, Price = 299.99 };

bool isSucceeded = prod1.SetName("Laptop");

if (isSucceeded)
{
    Console.WriteLine(prod1.ToString());
}
else
{
    Console.WriteLine("Name kon niet gezet worden");
}

prod1.Price = 279.99;

User user1 = new()
{
    Id = 1,
    Name = "Adolf",
    Toestand = "kapoet",
};

User user2 = new()
{
    Id = 2,
    Name = "Noah",
    Toestand = "skieje",
};
