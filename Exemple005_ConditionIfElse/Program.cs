Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "andrew")
{
    Console.WriteLine("Ну здравствуй, брат");
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}
//Работает почему-то только если писать имя английскими буквами. 
