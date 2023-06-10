using System.Data;
using System.Data.SQLite;

namespace Tetris
{
    internal class SQLiteHelper
    {
        private static SQLiteHelper instance;
        public static SQLiteHelper Instance => instance ??= new SQLiteHelper();

        public SQLiteConnection connection;

        public SQLiteHelper()
        {
            connection = new SQLiteConnection("data source=data.sqlite");
        }

        public void CreateTable()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SQLiteCommand cmd = new(connection)
            {
                CommandText = "create table if not exists user_info(name varchar(50),score INTEGER)"
            };
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public bool SaveOrUpdateUserScore(UserInfo userInfo)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SQLiteCommand cmd = new(connection);
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
                connection.Close();
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
                    if (connection.State != ConnectionState.Open) connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM user_info ORDER BY score DESC limit " + topNum + ";";
                    SQLiteDataAdapter da = new(cmd);
                    DataTable dt = new();
                    da.Fill(dt);
                    connection.Close();

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
                connection.Close();
            }
            return new List<UserInfo>();
        }

        private bool UserExist(string name)
        {
            SQLiteCommand mDbCmd = connection.CreateCommand();
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
