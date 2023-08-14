
using System.Data.SQLite;

class MyException : System.Exception {

}
public class Program{

    public static void Main(){

        // throw new MyException();
        var conn = new SQLiteConnection("data source=data.db");

        conn.Open();

        // var query = new SQLiteCommand("select * from users where id = " + 1.ToString() , conn);

        var query = new SQLiteCommand("select * from user where id = ?");
        query.Parameters.Add(new SQLiteParameter("@id", System.Data.DbType.Boolean){
            Value = 100
        })

        // var reader = query.ExecuteReader(); // select <- to read
        // query.ExecuteNonQuery(); 
        // query.ExecuteScalar();

        while(reader.Read()){
            
            Console.WriteLine(reader["id"].ToString() + reader["name"].ToString());

        }
    }
}