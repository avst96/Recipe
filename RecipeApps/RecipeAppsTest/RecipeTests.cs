namespace RecipeAppsTest
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true;TrustServerCertificate=True");
        }


        //Test 6 following procedures
        //GetCuisineList()
        //    GetUserList()
        //    LoadRecipe(int id)
        //    SaveRecipe(DataTable dt, DataRow row, int id)
        //    DeleteRecipe(DataRow row)
     
    }
}