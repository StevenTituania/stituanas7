using SQLite;

namespace Capremci
{
    public interface DataBase
    {

        SQLiteAsyncConnection GetConnection();
    }
}
