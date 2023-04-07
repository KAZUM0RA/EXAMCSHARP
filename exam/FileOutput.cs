namespace exam;

public class FileOutput
{
    public static void SaveTextToFile(string nameFail, string text) {
        File.WriteAllText(nameFail, text);
    }
}