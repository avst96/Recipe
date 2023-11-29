using RecipeAppSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
    public RecipeSearch()
    {
        InitializeComponent();
        this.Loaded += RecipeSearch_Loaded;
    }

    private void RecipeSearch_Loaded(object sender, EventArgs e)
    {
        DataTable dt = RecipeSystem.GetRecipeSummary();
        RecipeLst.ItemsSource = dt.Rows;
    }
}