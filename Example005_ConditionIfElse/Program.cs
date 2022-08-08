Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "эльмира")
{
    Console.WriteLine("Ура, это же Эльмира!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}
  