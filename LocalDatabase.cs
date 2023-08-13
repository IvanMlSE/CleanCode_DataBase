using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CleanCode_DataBase
{
    public class LocalDatabase
    {
        private string _commandText;
        private string _pathToDatabase;
        private string _dbName = "db.db";
        private SQLiteConnection _connection;
        private DataTable _dataTable;

        public LocalDatabase(string commandText)
        {
            _commandText = commandText;
            _pathToDatabase = $"Data Source={PathDB}\\{_dbName}";

            _connection = new SQLiteConnection(_pathToDatabase);
        }

        private string PathDB => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public DataTable SendReuqest()
        {
            try
            {
                _connection.Open();

                SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(new SQLiteCommand(_commandText, _connection));
                _dataTable = new DataTable();
                sqLiteDataAdapter.Fill(_dataTable);

                _connection.Close();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode != 1)
                    return null;

                int num2 = (int)MessageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");
            }

            //заглушка
            MessageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");

            return _dataTable;
        }
    }
}