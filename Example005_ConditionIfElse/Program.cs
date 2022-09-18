Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // = оператор присваивания

if (username.ToLower() == "маша") // == оператор сравнения; ToLower переводит все символы в нижней регистр, при чем выражение в " " д.б. записано нижним регистром
{
   Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}