using VotingApp.Models;
namespace VotingApp.Models;
public class Category
{
    public int VoteCount { get; set; }
    public required string Name { get; set; }
    public List<Category> SubCategories { get; set; } = new();
}