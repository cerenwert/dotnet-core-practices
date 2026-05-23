using VotingApp.Models;
using VotingApp.Services;

namespace VotingApp;
class Program
{
    static void Main()
    {
        UserService userService = new UserService();

        VotingService votingService = new VotingService();

        Console.WriteLine("Welcome to the Voting App!");

        User user = userService.GetUser();

        Console.WriteLine(
            $"Hello, {user.Name}! Let's start voting.");

        if (!userService.UserExists(user.Name))
        {
            Console.WriteLine(
                "It seems you are a new user. Adding you to the system...");

            userService.AddUser(user.Name);
        }
        else
        {
            Console.WriteLine(
                $"Welcome back, {user.Name}!");
        }

        votingService.ShowMainCategories();

        Console.Write("\nSelect main category: ");
        int mainChoice;

    while (!int.TryParse(Console.ReadLine(),out mainChoice)||mainChoice < 1||mainChoice > votingService.GetMainCategoryCount())
    {
        Console.WriteLine(
            "Invalid input. Please enter a valid number:");
    }
        mainChoice -= 1;
        votingService.ShowSubCategories(mainChoice);

        Console.Write("\nSelect sub category: ");
        Console.Write("Select sub category: ");
    int subChoice;

    while (!int.TryParse(Console.ReadLine(),out subChoice)||subChoice < 1||subChoice > votingService.GetSubCategoryCount(mainChoice))
    {
        Console.WriteLine(
            "Invalid input. Please enter a valid number:");
    }
        subChoice -= 1;

        votingService.Vote(mainChoice, subChoice);
        Console.WriteLine();
        Console.WriteLine("Would you like to see voting results? (yes/no): ");
        string showResults = Console.ReadLine() ?? "";
       if (showResults.Equals("yes",StringComparison.OrdinalIgnoreCase)||showResults.Equals("y",StringComparison.OrdinalIgnoreCase))
        {
            votingService.ShowResults();
        }
        else
        {
            Console.WriteLine("Thank you for voting!");
        }
    }
}