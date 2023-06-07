using System.Data;
using System.Data.SQLite;

namespace Tetris
{
    internal class SQLiteHelper
    {
        private static SQLiteHelper instance;
        public static SQLiteHelper Instance => instance ??= new SQLiteHelper();

        public SQLiteConnection sqliteConn;

        public SQLiteHelper()
        {
            sqliteConn = new SQLiteConnection("data source=data.sqlite");
        }

        public void CreateTable()
        {
            if (sqliteConn.State == ConnectionState.Closed) sqliteConn.Open();
            SQLiteCommand cmd = new(sqliteConn)
            {
                CommandText = "create table if not exists user_info(name varchar(50),score INTEGER)"
            };
            cmd.ExecuteNonQuery();
            sqliteConn.Close();
        }

        public bool SaveOrUpdateUserScore(UserInfo userInfo)
        {
            if (sqliteConn.State == ConnectionState.Closed) sqliteConn.Open();
            SQLiteCommand cmd = new(sqliteConn);
            try
            {
                if (UserExist(userInfo.name))
                {
                    cmd.CommandText = "UPDATE user_info SET score = " + userInfo.score + " WHERE name = '" + userInfo.name + "' and score < " + userInfo.score + ";";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO user_info VALUES ('" + userInfo.name + "', " + userInfo.score + ");";
                }
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                sqliteConn.Close();
            }
            return false;
        }

        public List<UserInfo> QueryTopUserList(int topNum)
        {
            try
            {
                List<UserInfo> datas = new();
                using (SQLiteCommand cmd = new())
                {
                    if (sqliteConn.State != ConnectionState.Open) sqliteConn.Open();
                    cmd.Connection = sqliteConn;
                    cmd.CommandText = "SELECT * FROM user_info ORDER BY score DESC limit " + topNum + ";";
                    SQLiteDataAdapter da = new(cmd);
                    DataTable dt = new();
                    da.Fill(dt);
                    sqliteConn.Close();

                    foreach (DataRow dd in dt.Rows)
                    {
                        var model = new UserInfo
                        {
                            name = Convert.ToString(dd[0]),
                            score = Convert.ToInt32(dd[1])
                        };
                        datas.Add(model);
                    }
                }
                return datas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqliteConn.Close();
            }
            return new List<UserInfo>();
        }

        private bool UserExist(string name)
        {
            SQLiteCommand mDbCmd = sqliteConn.CreateCommand();
            mDbCmd.CommandText = "SELECT COUNT(*) FROM user_info where name='" + name + "';";
            int row = Convert.ToInt32(mDbCmd.ExecuteScalar());
            if (0 < row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
