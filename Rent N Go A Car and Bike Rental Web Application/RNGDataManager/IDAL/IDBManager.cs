using System.Data;

namespace Rent_N_Go_A_Car_and_Bike_Rental_Web_Application.RNGDataManager.IDAL
{
    public interface IDBManager
    {
        RNGDataManager.DAL.DBManager InitDbCommand(string cmd);
        RNGDataManager.DAL.DBManager InitDbCommand(string cmd, CommandType cmdtype);
        RNGDataManager.DAL.DBManager AddCMDParam(string parametername, object value);
        RNGDataManager.DAL.DBManager AddCMDParam(string parametername, object value, DbType dbtype);
        RNGDataManager.DAL.DBManager AddCMDOutParam(string parametername, DbType dbtype, int iSize = 0);

        T GetOutParam<T>(string paramname);
        DataTable ExecuteDataTable();
        DataSet ExecuteDataSet();

        object? ExecuteScalar();

        Task<object?> ExecuteScalarAsync();
        int ExecuteNonQuery();
        Task<int> ExecuteNonQueryAsync();
        RNGDataManager.DAL.DBManager InitDbCommandText(string cmd);
    }
}
