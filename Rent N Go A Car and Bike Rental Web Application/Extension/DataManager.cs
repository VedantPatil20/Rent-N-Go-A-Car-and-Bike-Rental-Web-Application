using MySql.Data.MySqlClient;
using Rent_N_Go_A_Car_and_Bike_Rental_Web_Application.RNGDataManager.DAL;
using Rent_N_Go_A_Car_and_Bike_Rental_Web_Application.RNGDataManager.IDAL;
using System.Data.Common;

namespace Rent_N_Go_A_Car_and_Bike_Rental_Web_Application.Extension
{
    public static class DataManager
    {
        public static IServiceCollection AddAppSetting(this IServiceCollection services)
        {
            services.AddScoped<IDBManager>(AddDBManager);

            return services;
        }

        internal static IDBManager AddDBManager(IServiceProvider serviceProvider)
        {

            IConfiguration Configuration = serviceProvider.GetRequiredService<IConfiguration>();

            string dbconstr = Configuration.GetConnectionString("DefaultConnection");
            return GetDBManager(dbconstr);

        }

        public static IDBManager GetDBManager(string connectionString)
        {
            DbConnection dbconn = new MySqlConnection(connectionString);
            return new DBManager(dbconn);
        }
    }
}
