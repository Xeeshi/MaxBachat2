using MaxBachat2.Model;
using MaxBachat21.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationDrawer_2010
{
 public   class Connection
    {
        public SqlConnection con = null;


        public Connection()
        {
            if (MaxBachat21.Properties.Settings.Default.isInternet.Trim() == "" || MaxBachat21.Properties.Settings.Default.isInternet == "0")
            {
                con = new SqlConnection(Credential.Local_ConnectionString);

            }
            else
            {
                con = new SqlConnection(Credential.Internet_ConnectionString);
            }

        }


      //  static  string dbstring = "Data Source=" + MaxBachat21.Properties.Settings.Default.ServerName + ";Initial Catalog=" + MaxBachat21.Properties.Settings.Default.Database + ";User ID=" + MaxBachat21.Properties.Settings.Default.Username + ";Password=" + MaxBachat21.Properties.Settings.Default.Password;
      // static string dbstring = @"Data Source=103.75.244.25;initial Catalog=BE-MAXBACHAT;User ID=Purchasingsystem;Password=Future987";
      

     

        public bool InsertInformation(String ss)
        {

            try
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
                con.Open();
                
                SqlCommand cmd = new SqlCommand(ss, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }


        Double TempDouble;
        public Double DoubleValueFromDb(string x)
        {

            try
            {
                TempDouble = 0;

                SqlDataAdapter sda = new SqlDataAdapter(x, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string tempstring = dt.Rows[0][0].ToString();
                if (tempstring == "")
                { tempstring = "0"; }
                TempDouble = Double.Parse(tempstring);
                return TempDouble;


            }

            catch (Exception)
            { }
            return TempDouble;

        }
      Int64 tempint;
        public Int64 IntValueFromDb(string x)
        {

            try
            {


                SqlDataAdapter sda = new SqlDataAdapter(x, this.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                tempint = Int64.Parse(dt.Rows[0][0].ToString());

                return tempint;


            }

            catch (Exception)
            { }
            return tempint;

        }
        string tempString;
        public String StringValueFromDb(string x)
        {
            tempString = "0";

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter sda = new SqlDataAdapter(x, this.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                tempString = (dt.Rows[0][0]).ToString();



                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return tempString;

            }

            catch (Exception)
            { }
            return tempString;

        }
        public Int32 InsertValuesIntoDataBase(string query)
        {
            Int32 insertedID = -1;
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                     insertedID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();

                   

                }
                return insertedID;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                return -1;
            }
            
            }
        public List<CategoryTree> GetChildNodes(string productid)
        {
            List<CategoryTree> rootlist = new List<CategoryTree>();
          
            try
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }

                System.Data.SqlClient.SqlDataReader sdr;
              
                SqlCommand cmd = new SqlCommand("SELECT [LongName],[ParentCategoryId],[ProductCategoryId]  FROM [dbo].[ProductCategory] where [ParentCategoryId]='" + productid + "'", con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    if (!sdr.IsDBNull(0))
                    {
                        CategoryTree ct = new CategoryTree()
                        {
                            name = sdr.GetString(0),
                            parentid = sdr.GetInt32(1),
                            categoryid=sdr.GetInt32(2),
                        };

                        rootlist.Add(ct);

                    }

                }
                con.Close();

                return rootlist;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }
        public List<CategoryTree> GetRootNodes()
        {
            List<CategoryTree> rootlist = new List<CategoryTree>();

            try
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }

                System.Data.SqlClient.SqlDataReader sdr;
          
                SqlCommand cmd = new SqlCommand("SELECT [LongName],[ProductCategoryId]  FROM [dbo].[ProductCategory] where [ParentCategoryId] is NULL", con);

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    if (!sdr.IsDBNull(0))
                    {
                        CategoryTree ct = new CategoryTree()
                        {
                            name = sdr.GetString(0),
                           
                            categoryid = sdr.GetInt32(1),
                        };

                        rootlist.Add(ct);

                    }

                }
                con.Close();

                return rootlist;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }



        public DataTable getDataTableFromDB(string x)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
                con.Open();
                SqlCommand cmd = new SqlCommand(x, con);
                cmd.ExecuteNonQuery();
                DataTable dtt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtt);

                con.Close();
                return dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }

        public bool UpdateProductRecord(string updateString)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
                con.Open();
                SqlCommand cmd = new SqlCommand(updateString, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
                return false ;
            }
            
        }

        public bool ValidateInformationDatabase(string ss)
        {
            try
            {
                DataTable dt = new DataTable();
                if (con.State == ConnectionState.Open)
                { con.Close(); }

                SqlDataAdapter sda = new SqlDataAdapter(ss, con);

                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return true;


        }

        public bool ValidateInformationDatabase_More_Than_1(string ss)
        {
            try
            {
                DataTable dt = new DataTable();
                if (con.State == ConnectionState.Open)
                { con.Close(); }

                SqlDataAdapter sda = new SqlDataAdapter(ss, con);

                sda.Fill(dt);
                if (double.Parse(dt.Rows[0][0].ToString()) >=1 )
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return true;


        }

      

        public bool Save_MY_LIST_ITEMS(List<string> list,string id)
        {
            try
            {
                var records = list;

              
                    con.Open();

                    SqlCommand cmd =
                        new SqlCommand(
                            "INSERT INTO [mbo].[PSMyListItems]([List_ID],[ProductItemID])" +
                            " VALUES (@param1, @param2)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@param1", SqlDbType.Int);
                    cmd.Parameters.Add("@param2", SqlDbType.Int);

                    foreach (var item in records)
                    {
                        cmd.Parameters[0].Value = id;
                        cmd.Parameters[1].Value = item;


                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                return true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool Insert_Order_Items(List<POMODEL> list,string orderid)
        {
            try
            {
                var records = list;


                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO [dbo].[PurchaseOrderItem]([PurchaseOrderId],[ProductItemId],[Quantity],[Price],[DiscountRate],[SystemStock],[ItemStatus])" +
                        " VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@param1", SqlDbType.Int);
                cmd.Parameters.Add("@param2", SqlDbType.Int);
                cmd.Parameters.Add("@param3", SqlDbType.Decimal);
                cmd.Parameters.Add("@param4", SqlDbType.Money);
                cmd.Parameters.Add("@param5", SqlDbType.Money);
                cmd.Parameters.Add("@param6", SqlDbType.Decimal);
                cmd.Parameters.Add("@param7", SqlDbType.Int);

                foreach (var item in records)
                {
                    cmd.Parameters[0].Value = orderid;
                    cmd.Parameters[1].Value = item.ProductItemID;
                    cmd.Parameters[2].Value = item.FinalPC;
                    cmd.Parameters[3].Value = item.Cost;
                    cmd.Parameters[4].Value = 0;
                    cmd.Parameters[5].Value = 0;
                    cmd.Parameters[6].Value = 1;
                   


                    cmd.ExecuteNonQuery();
                }

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
    
    
}

