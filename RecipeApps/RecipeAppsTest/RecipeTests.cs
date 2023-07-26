using CPUFramework;
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
        [TestCase(false, "Test New Recipe", 25)]
        [TestCase(true, "", 15)]
        public void SaveRecipeTest(bool isupdate, string recipename, int calories)
        {
            DataTable dt;
            DataRow r;
            int recipeid = 0;
            DateTime newtime = DateTime.Now;
            string oldrecipename = "";

            if (isupdate == false)
            {
                dt = SQLUtility.GetDataTable("select UsersID , CuisineID, RecipeName, Calories, DateDrafted from Recipe where recipeid = 0");
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
                recipename = oldrecipename + " " + newtime;
                TestContext.WriteLine("Ensure that Recipe " + oldrecipename
                    + " gets updated to the following: RecipeName = " + recipename + ", "
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

            DataTable newdt = SQLUtility.GetDataTable("select recipename from recipe where recipename = '" + recipename + "'");
            if (isupdate == false)
            {
                Assert.IsTrue(newdt.Rows[0][0].ToString() == recipename, "No recipe with a name of " + recipename + " was found in DB");
                TestContext.WriteLine("New recipe with name of " + recipename + " was inserted in the DB");
            }
            else
            {
                DataRow newr = newdt.Rows[0];
                Assert.IsTrue(newr["RecipeName"].ToString() == recipename && (int)newr["Calories"] == calories && (DateTime)newr["Datedrafted"] == newtime, "Not all values where updated.");
                TestContext.WriteLine("Recipe with name " + oldrecipename + " was updated with following info : RecipeName = " + recipename + ", "
                    + "Calories = " + calories + ", DateDrafted = " + newtime);
                //TODO check all values updated, and writeline
            }

            //When updating check all columns that can be updated and write new line with all updated values
        }


        //insert userid, cuisineid, (recipename // add time, calories, datedrafted)
        //Test both insert and Update

    }


    //    SaveRecipe(DataTable dt, DataRow row, int id)
    //    DeleteRecipe(DataRow row)

}
