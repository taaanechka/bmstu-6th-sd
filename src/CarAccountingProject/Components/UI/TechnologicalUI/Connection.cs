using Microsoft.Extensions.Configuration;

namespace TechnologicalUI
{
    public static class Connection
    {
        // type == 0 - postgres
        // type == 1 - mysql
        public static string GetConnectionString(IConfiguration config, int type = 0, int permisson = 0)
        {
            switch (type)
            {
                case 1:
                    return config[$"ConnectionStringsMySQL:{permisson}"];
                default:
                    return config[$"ConnectionStringsPostgres:{permisson}"];
            }
            
        }
    }
}