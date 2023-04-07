namespace exam;

public class HtmlGenerator
{
    public static string? GenHtml(string name, string surname, string age) { 
        string template = File.ReadAllText("Human.html");

        template = template.Replace("%name%", name);
        template = template.Replace("%surname%", surname);
        template = template.Replace("%age%", age);

        return template;
    }
}