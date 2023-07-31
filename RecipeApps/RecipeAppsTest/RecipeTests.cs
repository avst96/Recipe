
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
        public void GetUsersListTest()
        {
            int usercount = SQLUtility.GetFirstColumnFirstRowValue("select count(*) from Users");
            Assert.That(usercount > 0, "No Users in DB, can't run test.");

            TestContext.WriteLine("Num of Users in DB is " + usercount);
            TestContext.WriteLine("Ensure num of Users returned by app = " + usercount);

            DataTable dt = RecipeSystem.GetUserList();
            Assert.IsTrue(dt.Rows.Count == usercount, "Rows returned by app (" + dt.Rows.Count + ") didn't match num of rows in DB (" + usercount + ")");

            TestContext.WriteLine("Num of Users returned by app match num of Users in DB");
        }

        [Test]
        public void GetCuisineListTest()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select count(*) from Cuisine");
            Assert.That(cuisinecount > 0, "No Cuisines in DB, can't run test.");

            TestContext.WriteLine("Num of Cuisine in DB is " + cuisinecount);
            TestContext.WriteLine("Ensure num of Cuisine returned by app = " + cuisinecount);

            DataTable dt = RecipeSystem.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Number of Cuisines returned by app (" + dt.Rows.Count + ") didn't match num of Cuisines in DB (" + cuisinecount + ")");

            TestContext.WriteLine("Num of Cuisines returned by app match num of Cuisines in DB");
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void LoadRecipeTest(int testcase)
        {
            int recipeid;
            if (testcase == 1)
            {
                recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by RecipeName desc");
            }
            else
            {
                recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by RecipeName");
            }
            Assume.That(recipeid > 0, "No recipies in DB, can't run test.");

            TestContext.WriteLine("Current RecipeID to be loaded = " + recipeid + ". Ensure app loades correct recipe.");

            DataTable dt = RecipeSystem.LoadRecipe(recipeid);
            int loadedid = (int)dt.Rows[0]["RecipeID"];

            Assert.IsTrue(recipeid == loadedid, "Wrong recipe was loaded. Recipe loaded has ID of (" + loadedid + ") and recipe to be loaded has ID of (" + recipeid + ").");
            TestContext.WriteLine("Recipe with ID (" + loadedid + ") was loaded.");
        }

        [Test]
        [TestCase(true, "Test New Recipe", 25)] //Tests for insert
        [TestCase(false, "", 20)] //Test for update
        public void SaveRecipeTest(bool isinsert, string recipename, int calories)
        {
            DataTable dt;
            DataRow r;
            int recipeid = 0;

            //I needed to remove the milisecond because the milisecond wasn't getting updated in the DB and was causing assert to fail
            string timeformat = "yyyy-MM-dd HH:mm:ss";
            DateTime newtime = DateTime.ParseExact(DateTime.Now.ToString(timeformat),timeformat,null);

            string oldrecipename = "";

            if (isinsert)
            {
                dt = SQLUtility.GetDataTable("select UsersID , CuisineID, RecipeName, Calories, DateDrafted from Recipe where recipeid = " + recipeid);
                Assume.That(dt.Rows.Count == 0);
                r = dt.Rows.Add();
                recipename += " " + newtime;
                TestContext.WriteLine("Add a new recipe to the table with recipe name of " + recipename);
            }

            else
            {
                recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
                dt = SQLUtility.GetDataTable("select RecipeID, UsersID , CuisineID, RecipeName, Calories, DateDrafted from Recipe where recipeid = " + recipeid);
                r = dt.Rows[0];
                oldrecipename = r["recipename"].ToString()!;
                // To remove any DateTime added in first update to ensure it doesn't get to long
                string dateTimePattern = @"\b\d{1,2}/\d{1,2}/\d{4} \d{1,2}:\d{2}:\d{2} (AM|PM)\b";
                recipename = Regex.Replace(oldrecipename, dateTimePattern, "").TrimEnd() + " " + newtime;

                TestContext.WriteLine("Ensure that Recipe '" + oldrecipename
                    + "' gets updated to the following: RecipeName = " + recipename + ", "
                    + "Calories = " + calories + ", DateDrafted = " + newtime);
            }

            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(userid > 0 && cuisineid > 0, "Users table or Cuisine table are empty, test can't run");



            r["UsersID"] = userid;
            r["CuisineID"] = cuisineid;
            r["RecipeName"] = recipename;
            r["Calories"] = calories;
            r["DateDrafted"] = newtime;

            RecipeSystem.SaveRecipe(dt, r, recipeid);

            DataTable newdt;
            if (isinsert)
            {
                newdt = SQLUtility.GetDataTable("select RecipeName, Calories, DateDrafted from recipe where recipename = '" + recipename + "'");
                Assert.IsTrue(newdt.Rows[0][0].ToString() == recipename, "No recipe with a name of " + recipename + " was found in DB");
                TestContext.WriteLine("New recipe with name of " + recipename + " was inserted in the DB");
            }
            else
            {
                newdt = SQLUtility.GetDataTable("select RecipeName, Calories, DateDrafted from recipe where recipeid = " + recipeid);
                DataRow newr = newdt.Rows[0];

                Assert.IsTrue(newr["RecipeName"].ToString() == recipename && (int)newr["Calories"] == calories && (DateTime)newr["Datedrafted"] == newtime, "Not all values where updated.");
                TestContext.WriteLine("Recipe with name " + oldrecipename + " was updated with following info : RecipeName = " + recipename + ", "
                    + "Calories = " + calories + ", DateDrafted = " + newtime);
            }

        }
            [Test]
            public void DeleteTest()
        {
            //I only checked for related record in the RecipeIngredient table with the assumption that if it doesn't have ingredients then it doesn't have any other foreign constraints.
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.RecipeID, r.RecipeName from Recipe r left join RecipeIngredient ri on  r.RecipeID = ri.RecipeID where ri.IngredientID is null ");
            Assume.That(dt.Rows.Count == 1, "DB is empty, cannot run test");
            DataRow r = dt.Rows[0];
            int recipeid = (int)r["RecipeID"];

            TestContext.WriteLine("Ensure that Recipe '" + r["RecipeName"] + "' with ID of " + recipeid + " is deleted from DB");

            RecipeSystem.DeleteRecipe(r);

            DataTable afterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(afterdelete.Rows.Count == 0, "Recipe with ID of " + recipeid + "has not deleted from DB");
            TestContext.WriteLine("Recipe with ID of " + recipeid + " has been deleted from DB");
        }
    }
}
