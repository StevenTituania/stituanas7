using Capremci.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SqlCliente))]

namespace Capremci.Droid
{
    public class SqlCliente : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentosPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            var path = Path.Combine(documentosPath, "capremci.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}