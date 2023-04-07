using exam;

Console.Write("Введите имя: ");
string? name = Console.ReadLine();
Console.Write("Введите фамилию: ");
string? surname = Console.ReadLine();
Console.Write("введите возраст: ");
string? age = Console.ReadLine();

string? html = HtmlGenerator.GenHtml(name, surname, age);

FileOutput.SaveTextToFile("HumanNew.html", html);

Console.WriteLine("Сработало");