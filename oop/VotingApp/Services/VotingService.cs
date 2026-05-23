using VotingApp.Models;
using VotingApp.Services;

namespace VotingApp.Services;

public class VotingService
{
    private List<Category> category = new List<Category>();

    public VotingService()
    {
        Category sanat = new Category { Name = "Sanat" };

        sanat.SubCategories.Add(new Category { Name = "Resim" });
        sanat.SubCategories.Add(new Category { Name = "Heykel" });
        sanat.SubCategories.Add(new Category { Name = "Müzik" });
        sanat.SubCategories.Add(new Category { Name = "Tiyatro" });
        sanat.SubCategories.Add(new Category { Name = "Sinema" });

        category.Add(sanat);

        Category spor = new Category { Name = "Spor" };

        spor.SubCategories.Add(new Category { Name = "Futbol" });
        spor.SubCategories.Add(new Category { Name = "Basketbol" });
        spor.SubCategories.Add(new Category { Name = "Voleybol" });
        spor.SubCategories.Add(new Category { Name = "Tenis" });
        spor.SubCategories.Add(new Category { Name = "Yüzme" });

        category.Add(spor);

        Category teknoloji = new Category { Name = "Teknoloji" };

        teknoloji.SubCategories.Add(new Category { Name = "Yazılım" });
        teknoloji.SubCategories.Add(new Category { Name = "Donanım" });
        teknoloji.SubCategories.Add(new Category { Name = "Yapay Zeka" });
        teknoloji.SubCategories.Add(new Category { Name = "Siber Güvenlik" });
        teknoloji.SubCategories.Add(new Category { Name = "Oyun Geliştirme" });

        category.Add(teknoloji);

        Category seyahat = new Category { Name = "Seyahat" };

        seyahat.SubCategories.Add(new Category { Name = "Doğa" });
        seyahat.SubCategories.Add(new Category { Name = "Kültür" });
        seyahat.SubCategories.Add(new Category { Name = "Macera" });
        seyahat.SubCategories.Add(new Category { Name = "Tatil" });
        seyahat.SubCategories.Add(new Category { Name = "Gezi Rehberi" });

        category.Add(seyahat);

        Category yemek = new Category { Name = "Yemek" };

        yemek.SubCategories.Add(new Category { Name = "Türk Mutfağı" });
        yemek.SubCategories.Add(new Category { Name = "Dünya Mutfağı" });
        yemek.SubCategories.Add(new Category { Name = "Vejetaryen" });
        yemek.SubCategories.Add(new Category { Name = "Vegan" });
        yemek.SubCategories.Add(new Category { Name = "Tatlı" });

        category.Add(yemek);

        Category moda = new Category { Name = "Moda" };

        moda.SubCategories.Add(new Category { Name = "Giyim" });
        moda.SubCategories.Add(new Category { Name = "Aksesuar" });
        moda.SubCategories.Add(new Category { Name = "Ayakkabı" });
        moda.SubCategories.Add(new Category { Name = "Çanta" });
        moda.SubCategories.Add(new Category { Name = "Takı" });

        category.Add(moda);

        Category sağlık = new Category { Name = "Sağlık" };

        sağlık.SubCategories.Add(new Category { Name = "Beslenme" });
        sağlık.SubCategories.Add(new Category { Name = "Egzersiz" });
        sağlık.SubCategories.Add(new Category { Name = "Zihinsel Sağlık" });
        sağlık.SubCategories.Add(new Category { Name = "Hastalıklar" });
        sağlık.SubCategories.Add(new Category { Name = "Sağlıklı Yaşam" });

        category.Add(sağlık);
    }

    public bool HasCategories()
    {
        return category.Count > 0;
    }

    public void ShowCategories()
    {
        Console.WriteLine("\n--- AVAILABLE CATEGORIES ---");

        foreach (var cat in category)
        {
            Console.WriteLine($"\n{cat.Name}");

            foreach (var sub in cat.SubCategories)
            {
                Console.WriteLine($" - {sub.Name}");
            }
        }
    }

    public void ShowMainCategories()
    {
        Console.WriteLine("\n--- MAIN CATEGORIES ---");

        for (int i = 0; i < category.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {category[i].Name}");
        }
    }
    
    
    public void ShowSubCategories(int index)
    {
        Console.WriteLine("\n--- SUB CATEGORIES ---");

        var selectedCategory = category[index];

        for (int i = 0;
            i < selectedCategory.SubCategories.Count;
            i++)
        {
            Console.WriteLine(
                $"{i + 1} - " +
                $"{selectedCategory.SubCategories[i].Name}");
        }
    }
    public void Vote(int mainIndex, int subIndex)
    {
        var selectedSubCategory = category[mainIndex].SubCategories[subIndex];

        selectedSubCategory.VoteCount++;

        Console.WriteLine( $"You voted for {selectedSubCategory.Name}");

        Console.WriteLine($"Total votes: {selectedSubCategory.VoteCount}");
    }
    public void ShowResults()
    {
        Console.WriteLine("\n--- VOTING RESULTS ---");

        int totalVotes = GetTotalVotes();

        foreach (var mainCategory in category)
        {
            Console.WriteLine($"\n{mainCategory.Name}");

            foreach (var sub in mainCategory.SubCategories)
            {
                double percentage =
                    totalVotes == 0
                    ? 0
                    : (double)sub.VoteCount /
                      totalVotes * 100;

                Console.WriteLine(
                    $" - {sub.Name}: " +
                    $"{sub.VoteCount} votes " +
                    $"(%{percentage:F1})");
            }
        }

        Console.WriteLine(
            $"\nTotal votes cast: {totalVotes}");
    }

    public int GetTotalVotes()
    {
        return category.Sum(main =>main.SubCategories.Sum(sub =>sub.VoteCount));
    }
    public int GetMainCategoryCount()
    {
        return category.Count;
    }
    public int GetSubCategoryCount(int mainIndex)
    {
        return category[mainIndex].SubCategories.Count;
    }
}