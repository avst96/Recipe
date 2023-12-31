
using System.Configuration;

namespace RecipeAppsTest
{
    public class RecipeTests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string connfortest = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            DBManager.SetConnectionString(connfortest, false);
            int n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }
        private DataTable GetDataTable(string sql)
        {
            DBManager.SetConnectionString(connfortest, false);
            DataTable dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        [Test]
        [TestCase("")]
        [TestCase("a")]
        public void SearchRecipeTest(string criteria)
        {
            int num = GetFirstColumnFirstRowValue("select total = count(*) from recipe where RecipeName like '%" + criteria + "%'");
            if (num == 0 && criteria != "")
            {
                criteria = "e";
                num = GetFirstColumnFirstRowValue("select total = count(*) from recipe where RecipeName like '%" + criteria + "%'");
            }
            Assume.That(num > 0, "No recipes match search provided");

            TestContext.WriteLine("Assure that num of recipes returned by SearchRecipe match num of recipes with search parameters (" + criteria + "); num in DB that match (" + num + ")");
            bizRecipe rec = new();
            var lst = rec.SearchRecipe(criteria);

            Assert.IsTrue(lst.Count == num, "Rows returned by SearchRecipe (" + lst.Count + ") don't match num of recipes with matching criteria in DB (" + num + ")");
            TestContext.WriteLine("Num of rows returned by Search app (" + lst.Count + ") = rows matching in DB (" + num + ")");
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void GetAllRecipeTest(bool includeblank)
        {
            string msg = "";
            int num = GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(num > 0, "No recipies in DB, cannot run test.");
            if (includeblank) { num++; msg = " plus a blank"; }
            TestContext.WriteLine("Assure that num of recipes returned match the num of recipes in DB" + msg + ". (Num recipes in DB" + msg + " is " + num + ")");
            bizRecipe rec = new();
            var lst = rec.GetList(includeblank);
            Assert.IsTrue(lst.Count == num, "Num of recipes returned (" + lst.Count + ") doesn't match num of recipes in DB" + msg + " (" + num + ").");
            TestContext.WriteLine($"Num of recipes{msg} returned by app was {num}, matching the total num of recipes{msg} in the DB.");
        }
        [Test]
        public void GetUsersListTest()
        {
            int usercount = GetFirstColumnFirstRowValue("select count(*) from Users");
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
            int cuisinecount = GetFirstColumnFirstRowValue("select count(*) from Cuisine");
            Assert.That(cuisinecount > 0, "No Cuisines in DB, can't run test.");

            TestContext.WriteLine("Num of Cuisine in DB is " + cuisinecount);
            TestContext.WriteLine("Ensure num of Cuisine returned by app = " + cuisinecount);

            DataTable dt = RecipeSystem.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Number of Cuisines returned by app (" + dt.Rows.Count + ") didn't match num of Cuisines in DB (" + cuisinecount + ")");

            TestContext.WriteLine("Num of Cuisines returned by app match num of Cuisines in DB");
        }
        [Test]
        [TestCase(true)]
        [TestCase(false)]

        public void GetIngredientListTest(bool includeblank)
        {
            string msg = "";
            int num = GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            Assume.That(num > 0, "No ingredients in DB, cannot run test.");
            if (includeblank) { num++; msg = " plus a blank"; }
            TestContext.WriteLine("Assure that num of ingredients returned match the num of ingredients in DB" + msg + ". (Num ingredients in DB" + msg + " is " + num + ")");
            bizIngredient ing = new();
            var lst = ing.GetList(includeblank);
            Assert.IsTrue(lst.Count == num, "Num of ingredients returned (" + lst.Count + ") doesn't match num of ingredients in DB" + msg + " (" + num + ").");
            TestContext.WriteLine($"Num of ingredients{msg} returned by app was {num}, matching the total num of ingredients{msg} in the DB.");
        }
        [Test]
        [TestCase("e")]
        [TestCase("a")]
        public void SearchIngredientList(string search)
        {
            int num = GetFirstColumnFirstRowValue("select count(*) from Ingredient where IngredientName like '%" + search + "%'");
            Assume.That(num > 0, "No ingredient match the search criteria, can't run test");
            TestContext.WriteLine($"Assure the num of ingredients returned match the num of existing ingredients that match the search ({num})");
            bizIngredient ing = new();
            var lst = ing.SearchIngredient(search);
            Assert.IsTrue(lst.Count == num, $"Num of ingredients returned ({lst.Count}) doesn't match num of ingredients in DB that match search criteria ({num}).");
            TestContext.WriteLine($"Num of ingredients returned by app was {lst.Count}, matching the total num of ingredients with matching criteria in the DB {num}.");
        }

    

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void LoadRecipeTest(int testcase)
        {
            int recipeid;
            if (testcase == 1)
            {
                recipeid = GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by RecipeName desc");
            }
            else
            {
                recipeid = GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by RecipeName");
            }
            Assume.That(recipeid > 0, "No recipes in DB, can't run test.");

            TestContext.WriteLine("Current RecipeID to be loaded = " + recipeid + ". Ensure app loades correct recipe.");

            bizRecipe rec = new();
            rec.Load(recipeid);
            int loadedid = rec.RecipeId;

            Assert.IsTrue(recipeid == loadedid, "Wrong recipe was loaded. Recipe loaded has ID of (" + loadedid + ") and recipe to be loaded has ID of (" + recipeid + ").");
            TestContext.WriteLine("Recipe with ID (" + loadedid + ") and recipe name of '" + rec.RecipeName + "' was loaded.");
        }

        [Test]
        [TestCase(true, "Test New Recipe", 25)] //Tests for insert
        [TestCase(false, "", 20)] //Test for update
        public void SaveRecipeTest(bool isinsert, string recipename, int calories)
        {
            bizRecipe rec = new();

            int recipeid = 0;

            //I needed to remove the milisecond because the milisecond wasn't getting updated in the DB and was causing assert to fail
            string timeformat = "yyyy-MM-dd HH:mm:ss";
            DateTime newtime = DateTime.ParseExact(DateTime.Now.ToString(timeformat), timeformat, null);

            string oldrecipename = "";

            if (isinsert)
            {
                recipename += " " + newtime;
                TestContext.WriteLine("Add a new recipe to the table with recipe name of " + recipename + " and following amount of calories " + calories);
            }

            else
            {
                recipeid = GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
                rec.Load(recipeid);
                oldrecipename = rec.RecipeName;

                // To remove any DateTime added in first update to ensure it doesn't get to long
                string dateTimePattern = @"\b\d{1,2}/\d{1,2}/\d{4} \d{1,2}:\d{2}:\d{2} (AM|PM)\b";
                recipename = Regex.Replace(oldrecipename, dateTimePattern, "").TrimEnd() + " " + newtime;

                TestContext.WriteLine("Ensure that Recipe '" + oldrecipename
                    + "' gets updated to the following: RecipeName = " + recipename + ", "
                    + "Calories = " + calories);
            }

            int userid = GetFirstColumnFirstRowValue("select top 1 usersid from users");
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(userid > 0 && cuisineid > 0, "Users table or Cuisine table are empty, test can't run");


            rec.UsersId = userid;
            rec.CuisineId = cuisineid;
            rec.RecipeName = recipename;
            rec.Calories = calories;
            rec.DateDrafted = newtime;
            rec.DatePublished = DateTime.Now;
            rec.DateArchived = null;

            rec.Save();

            DataTable newdt;
            if (isinsert)
            {
                newdt = GetDataTable("select RecipeName, Calories, DateDrafted, RecipeId from recipe where recipeid = " + rec.RecipeId);
                Assert.IsTrue(newdt.Rows[0][0].ToString() == recipename, "No recipe with a name of " + recipename + " was found in DB");
                TestContext.WriteLine("New recipe with name of " + recipename + " and RecipeId of " + newdt.Rows[0][3] + " and calories count of " + newdt.Rows[0][1] + " was inserted in the DB");
            }
            else
            {
                newdt = GetDataTable("select RecipeName, Calories, DateDrafted from recipe where recipeid = " + recipeid);
                DataRow newr = newdt.Rows[0];

                Assert.IsTrue(newr["RecipeName"].ToString() == recipename && (int)newr["Calories"] == calories, "Not all values where updated.");
                TestContext.WriteLine("Recipe with name " + oldrecipename + " was updated with following info : RecipeName = " + recipename + ", "
                    + "Calories = " + calories);
            }

        }

        [Test]
        public void DeleteTest()
        {
            DataTable dt = GetDataTable(@"select top 1 r.RecipeID, r.RecipeName 
                                        from Recipe r 
                                        left join RecipeIngredient ri on r.RecipeID = ri.RecipeID
                                        left join Directions d on r.RecipeID = d.RecipeID
                                        left join CookbookRecipe cr on r.RecipeID = cr.RecipeID
                                        left join MealCourseRecipe mcr on r.RecipeID = mcr.RecipeID 
                                        where ri.IngredientID is null
                                        and d.DirectionsID is null 
                                        and cr.CookbookRecipeID is null
                                        and mcr.MealCourseRecipeID is null 
                                        and (r.RecipeStatus = 'draft' or datediff(day, r.DateArchived, getdate()) > 30) ");
            Assume.That(dt.Rows.Count == 1, "No unrelated recipe in DB that doesn't violate business rule, can't run test");

            int recipeid = (int)dt.Rows[0]["RecipeID"];

            TestContext.WriteLine("Ensure that Recipe '" + dt.Rows[0]["RecipeName"] + "' with ID of " + recipeid + " is deleted from DB");
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete();

            DataTable afterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(afterdelete.Rows.Count == 0, "Recipe with ID of " + recipeid + "has not deleted from DB");
            TestContext.WriteLine("Recipe with ID of " + recipeid + " has been deleted from DB");
        }
        [Test]
        public void DeleteTestWithAllowedRelatedRecord()
        {
            DataTable dt = GetDataTable("select top 1 r.RecipeID, r.RecipeName from Recipe r join RecipeIngredient ri on r.RecipeID = ri.RecipeID left join CookbookRecipe cr on r.RecipeID = cr.RecipeID where cr.CookbookRecipeID is null");
            Assume.That(dt.Rows.Count == 1, "No recipe in DB that have only related records that can be deleted, can't run test");
            DataRow r = dt.Rows[0];
            int recipeid = (int)r["RecipeID"];

            TestContext.WriteLine("Ensure that Recipe '" + r["RecipeName"] + "' with ID of " + recipeid + " with related records are deleted from DB" + Environment.NewLine);

            RecipeSystem.DeleteRecipe(r);

            DataTable afterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            DataTable relatedrecord = GetDataTable("select * from RecipeIngredient where recipeid = " + recipeid);
            Assert.IsTrue(afterdelete.Rows.Count == 0 && relatedrecord.Rows.Count == 0, "Recipe with ID of " + recipeid + " or related records have not been deleted from DB");
            TestContext.WriteLine("Recipe with ID of " + recipeid + " and related records have been deleted from DB");
        }



        [Test]
        public void InvalidDeleteDueToBusinessRule()
        {
            DataTable dt = GetDataTable(@"select top 1 r.recipeid, r.recipename from Recipe r 
left join CookbookRecipe cr on r.RecipeID = cr.RecipeID
left join MealCourseRecipe mcr on r.RecipeID = mcr.RecipeID
where mcr.MealCourseRecipeID is null
and cr.CookbookRecipeID is null
and r.RecipeStatus<> 'draft'
and isnull(datediff(day, r.DateArchived, getdate()), 0) < 30
");
            Assume.That(dt.Rows.Count == 1, "No recipe without related cookbook or meals violates business rule when deleted");
            int recipeid = (int)dt.Rows[0]["RecipeId"];
            string recipename = dt.Rows[0]["RecipeName"].ToString()!
                ;
            TestContext.WriteLine("Ensure that Recipe '" + recipename + "' with ID of " + recipeid + " throws business rule exception when delete is attempted");

            string msg = Assert.Throws<Exception>(() => RecipeSystem.DeleteRecipe(dt.Rows[0])).Message;

            TestContext.WriteLine("Exception throw with message '" + msg + "'");
        }
        [Test]
        public void InvalidSaveNotUnique()
        {
            DataTable dt = GetDataTable("select top 1 UsersID, CuisineID, RecipeName, Calories, DateDrafted from recipe");
            Assume.That(dt.Rows.Count > 0, "No unrelated recipe in DB, can't run test");
            DataRow row = dt.Rows[0];
            TestContext.WriteLine("Ensure an exception is thrown, with a formatted message");
            string msg = Assert.Throws<Exception>(() => RecipeSystem.SaveRecipe(dt, row)).Message;
            TestContext.WriteLine("Exception throw with message '" + msg + "'");
        }

        [Test]
        public void InvalidSaveCheckConstraint()
        {
            DataTable dt = GetDataTable("select top 1 RecipeID, UsersID, CuisineID, RecipeName, Calories, DateDrafted from recipe");
            Assume.That(dt.Rows.Count > 0, "No recipe in DB, can't run test");
            DataRow row = dt.Rows[0];

            row["RecipeName"] = " ";
            TestContext.WriteLine("Ensure an exception is thrown, with a formatted message");
            string msg = Assert.Throws<Exception>(() => RecipeSystem.SaveRecipe(dt, row)).Message;
            TestContext.WriteLine("Exception throw with message '" + msg + "'");
        }
    }
}
