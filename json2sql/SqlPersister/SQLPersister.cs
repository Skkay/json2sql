using json2sql.converter;
using System.Text;

namespace json2sql.sqlpersister
{
    interface ISqlPersister
    {
        string GetSchema();
        StringBuilder ToSqlScript(JsonDataTable jsonDataTable, string file);
        string ToSqlScript(JsonDataTable jsonDataTable, FilePath filePath);
    }

    abstract class SQLPersister : ISqlPersister
    {
        public abstract string GetSchema();
        public abstract StringBuilder ToSqlScript(JsonDataTable jsonDataTable, string file);
        public abstract string ToSqlScript(JsonDataTable jsonDataTable, FilePath filePath);

    }

    
}
