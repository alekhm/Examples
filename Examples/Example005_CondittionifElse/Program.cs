﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "егор")
{
    Console.WriteLine("Ура, это же Егор!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}