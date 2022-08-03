Console.WriteLine("Введите имя пользователя:");
string user = Console.ReadLine();
// if(user == "Степан")
if(user.ToLower() == "степан") // .ToLower() позволяет все символы в строке перевести в нижний регистр
{
    Console.WriteLine("Ура! Привет Степан");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(user);
}
