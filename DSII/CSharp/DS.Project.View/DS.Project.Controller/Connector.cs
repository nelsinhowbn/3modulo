using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace DS.Project.Controller{

    public class Connector{
        
		private static SqlConnection _conn = null;
		private static string _connString =
                "Data Source=localhost;"
            + "Initial Catalog=bdAluno;"
            + "User id=sa;"
            + "Password=info211;";

		private static void connect() {
			if(Connector._conn == null) {
				Connector._conn = new SqlConnection(Connector._connString);
			}
			Connector._conn.Open();
		}

		public static void close() {
			if (Connector._conn != null) {
				Connector._conn.Close();
				Connector._conn = null;
			}
		}

		public static int execute(string command) {
			Connector.connect();
			SqlCommand statement = new SqlCommand(command, Connector._conn);
			int rowsAffected = statement.ExecuteNonQuery();
			Connector.close();
			return rowsAffected;
		}

		public static DataSet executeQuery(string command) {
			Connector.connect();
			SqlCommand statement = new SqlCommand(command, Connector._conn);
			SqlDataAdapter queryResults = new SqlDataAdapter(statement);
			DataSet resultSet = new DataSet();
			queryResults.Fill(resultSet);
			Connector.close();
			return resultSet;
		}
    }
}
