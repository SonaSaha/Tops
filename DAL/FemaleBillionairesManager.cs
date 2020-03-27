using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class FemaleBillionairesManager
    {

        private femaleBillionairesFields constructorObj = new femaleBillionairesFields();
        private ConnectionManager obj = new ConnectionManager();
        public femaleBillionairesFields conditionObj = new femaleBillionairesFields();
        private string query = "null";
        public List<string> columnsList = new List<string>();
        public class femaleBillionairesFields
        {
            private int No;
            private string Name;
            private int Age;
            private decimal Net_worth;
            private string Citizenship;
            private int World_rank;
            private string field;
            private string column;
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
            public string No_
            {
                get
                {
                    return No.ToString();
                }
                set
                {
                    No = Int32.Parse(value);
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
            public string Age_
            {
                get
                {
                    return Age.ToString();
                }
                set
                {
                    Age = Int32.Parse(value);
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
            public string World_rank_
            {
                get
                {
                    return World_rank.ToString();
                }
                set
                {
                    World_rank = Int32.Parse(value);
                }
            }

        }
        public FemaleBillionairesManager()
        {

        }
        public FemaleBillionairesManager(List<string> list)
        {

            constructorObj.No_ = list[0];
            constructorObj.Name_ = list[1];
            constructorObj.Age_ = list[2];
            constructorObj.Net_worth_ = list[3];
            constructorObj.Citizenship_ = list[4];
            constructorObj.World_rank_ = list[5];
        }
        public FemaleBillionairesManager(string field, string column)
        {
            conditionObj.field_ = field;
            conditionObj.column_ = column;

        }
        public void insert()
        {
            try
            {
                obj.Open();
                query = "insert into  female_billionaires (No,Name,Age,Net_worth,Citizenship,World_rank)" +
                    " values ('" + @constructorObj.No_ + "','" + @constructorObj.Name_ + "','" + @constructorObj.Age_ + "','"
                    + @constructorObj.Net_worth_ + "','" + @constructorObj.Citizenship_ +
                    "','" + @constructorObj.World_rank_ + "');";

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
                query = "select *  from female_billionaires";
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
                if (columnsList[0] == "No")
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
                if (columnsList[5] == "World_rank")
                {
                    query += "," + columnsList[5];
                }
                query += "  from female_billionaires;";
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
                query = "delete from female_billionaires where No =" + conditionObj.field_ + ";";
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
                if (constructorObj.No_ != " ")
                {
                    query += "No =" + @constructorObj.No_;
                }
                else if (constructorObj.Name_ != " ")
                {
                    query += "," + "Name =" + @constructorObj.Name_;
                }
                else if (constructorObj.Age_ != " ")
                {
                    query += "," + "Age =" + @constructorObj.Age_;
                }
                else if (constructorObj.Net_worth_ != " ")
                {
                    query += "," + "Net_worth =" + @constructorObj.Net_worth_;
                }
                else if (constructorObj.Citizenship_ != " ")
                {
                    query += "," + "Citizenship =" + @constructorObj.Citizenship_;
                }
                else if (constructorObj.World_rank_ != " ")
                {
                    query += "," + "World_rank =" + @constructorObj.World_rank_;
                }
                query += " where " + conditionObj.column_ + "=" + conditionObj.field_ + ";";

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
                query = "select Name from female_billionaires  where Rank_='" + @conditionObj.field_ + "';";
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
