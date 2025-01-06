using GptRecipeParser;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            (string result, decimal cout) = await DescriptionGenerator.GenerateDescription("");

            Console.WriteLine(result);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Cost : {cout}");

            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
