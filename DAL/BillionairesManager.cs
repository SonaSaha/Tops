using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BillionairesManager
    {
        private  billionairesFields constructorObj = new billionairesFields();
        private ConnectionManager obj = new ConnectionManager();
        public billionairesFields conditionObj = new billionairesFields();
        public List<string> columnsList = new List<string>();
        private string query = "null";

        public class billionairesFields
        {
            private int Rank_;
            private string Name;
            private int Age;
            private decimal Net_worth;
            private string Citizenship;
            private string Main_source_of_wealth;
            private string field;
            private string  column;

            public string field_
            {
                get
                {
                    return field;
                }
                set
                {
                    field = value;
                   
                }
            }
            public string column_
            {
                get
                {
                    return column;
                }
                set
                {
                    column = value;

                }
            }
            public string Rank
            {
                get
                {
                    return Rank_.ToString();
                }
                set
                {
                    Rank_ = Int32.Parse(value);
                }
            }
            public string Name_
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
            public string  Age_
            {
                get
                {
                    return Age.ToString();
                }
                set
                {
                    Age =Int32.Parse(value);
                }
            }
            public string Net_worth_
            {
                get
                {
                    return Net_worth.ToString();
                }
                set
                {
                    Net_worth = decimal.Parse(value);
                }
            }
            public string Citizenship_
            {
                get
                {
                    return Citizenship;
                }
                set
                {
                    Citizenship = value;
                }
            }
            public string  Main_source_of_wealth_
            {
                get
                {
                    return Main_source_of_wealth;
                }
                set
                {
                    Main_source_of_wealth = value;
                }
            }
           
        }
        public BillionairesManager()
        {

        }
        public BillionairesManager(List<string> list)
        {

            constructorObj.Rank = list[0];
            constructorObj.Name_ = list[1];
            constructorObj.Age_ = list[2];
            constructorObj.Net_worth_ = list[3];
            constructorObj.Citizenship_ = list[4];
            constructorObj.Main_source_of_wealth_ = list[5];
        }
       
        public BillionairesManager(string field,string column)
        {
            conditionObj.field_ = field;
           conditionObj.column_ = column;
            
        }
        public void insert()
        {
            try
            {
                obj.Open();
                query = "insert into  billionaires (Rank_, Name, Age, Net_worth, Citizenship , Main_source_of_wealth ) values ('" +
                    @constructorObj.Rank + "','" + constructorObj.Name_ + "','" + @constructorObj.Age_ +  "','" +
                     @constructorObj.Net_worth_ +  "','" + @constructorObj.Citizenship_ +
                    "','" + @constructorObj.Main_source_of_wealth_ + "');";
              
                obj.Query(query);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }
        }
        public DataTable selectAllTable()
        {
            try
            {
                obj.Open();
                query = "select *  from billionaires";
                return obj.MultiSelect(query);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }

        }
        public DataTable select()
        {
            try
            {
                obj.Open();
                query = "select ";
                if (columnsList[0] == "Rank_")
                {
                    query += columnsList[0];
                }
                if (columnsList[1] == "Name")
                {
                    query += "," + columnsList[1];
                }
                 if (columnsList[2] == "Age")
                {
                    query += "," + columnsList[2];
                }
                 if (columnsList[3] == "Net_worth")
                {
                    query += "," + columnsList[3];
                }
                 if (columnsList[4] == "Citizenship")
                {
                    query += "," + columnsList[4];
                }
                 if (columnsList[5] == "Main_source_of_wealth")
                {
                    query += "," + columnsList[5];
                }
                query += "  from billionaires;";
                return obj.MultiSelect(query);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }

        }
        public void delete()
        {

            try
            {
                obj.Open();
                query = "delete from billionaires where Rank_ = " + conditionObj.field_ + ";";
                obj.Query(query);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }
        }
        public void update()
        {
            try
            {
                obj.Open();
                query = "update billionaires set ";
                if (constructorObj.Rank != " ")
                {
                    query += "Rank_ =" + @constructorObj.Rank ;
                }
                 if(constructorObj.Name_!=" ")
                {
                    query += "," + "Name ='" + @constructorObj.Name_ +"'";
                }
                if(constructorObj.Age_!=" ")
                {
                    query += ","+"Age =" + @constructorObj.Age_ ;
                }
                if(constructorObj.Net_worth_!=" ")
                {
                    query += ","+"Net_worth =" + @constructorObj.Net_worth_ ;
                }
                 if (constructorObj.Citizenship_ != " ")
                {
                    query += ","+"Citizenship ='" + @constructorObj.Citizenship_ +"'";
                }
                if (constructorObj.Main_source_of_wealth_!= " ")
                {
                    query += ","+"Main_source_of_wealth ='" + @constructorObj.Main_source_of_wealth_+"'";
                }
                query += " where Rank_ =" + conditionObj.field_ + ";";

            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }
        }
        public string GetName()
        {
            try
            {
                obj.Open();
                query = "select Name from billionaires  where Rank_='" + @conditionObj.field_ + "';";
                return obj.GetName(query);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj.Close();
            }
           
        }
    }
}
