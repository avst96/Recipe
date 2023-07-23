using System.Data;

namespace RecipeAppsTest
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true;TrustServerCertificate=True");
        }

        [Test]
        [TestCase("a")]
        [TestCase("z")]
        [TestCase("ab")]
        [TestCase("but")]
        public void SearchAndLoadRecipies(string search)
        {
            TestContext.WriteLine("Search for all recipes that contain '" + search + "' in the RecipeName.");
            
            DataTable dt = RecipeSystem.SearchRecipe(search);
            Assume.That(dt.Rows.Count > 0, "No recipes match search");

            Assert.IsTrue(CheckDataMatchesSearch(dt, search));
            TestContext.WriteLine("Only records that contain '" + search + "' in the RecipeName where loaded.");
        }



        private bool CheckDataMatchesSearch(DataTable dt, string search)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string s = dr["RecipeName"].ToString()!.ToLower();
                if (!s.Contains(search.ToLower()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}