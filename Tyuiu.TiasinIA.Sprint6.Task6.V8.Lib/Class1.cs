using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TiasinIA.Sprint6.Task6.V8.Lib
{
    public class Class1 : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
                StringBuilder result = new StringBuilder();

                try
                {
                    string input;
                    using (var reader = new StreamReader(path))
                    {
                        input = reader.ReadToEnd();
                    }


                    var words = input.Split(new[] { 'z' }, StringSplitOptions.RemoveEmptyEntries);
                    var wordsWithLowercaseB = new List<string>();


                    foreach (var word in words)
                    {
                        if (word.Contains(' '))
                        {
                            wordsWithLowercaseB.Add(word);
                        }
                    }
                    return string.Join(" ", wordsWithLowercaseB);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка: {ex.Message}", ex);
                }
        }
    }
}
