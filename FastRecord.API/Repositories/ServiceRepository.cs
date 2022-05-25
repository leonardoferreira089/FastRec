using Dapper;
using FastRecord.API.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FastRecord.API.Repositories
{
    public class ServiceRepository
    {
        private string connectionString;

        public ServiceRepository()
        {
            connectionString = @"Data Source=DESKTOP-9J6501O\SQLEXPRESS;Initial Catalog=FastRecDb;Integrated Security=True";
        }

        public void CreateService(ServiceModel service)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                string script = @"INSERT INTO Products (ServiceName,TypeSerVice,Price) VALUES (@ServiceName,@TypeSerVice,@Price)";
                dbConnection.Execute(script, service);
            }
        }

        public IEnumerable<ServiceModel> GetAllServices()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                string script = @"Select * FROM Services";

                return dbConnection.Query<ServiceModel>(script);
            }
        }

        public ServiceModel GetServiceById(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                string script = @"Select * FROM Service Where Id=@Id";

                return dbConnection.Query<ServiceModel>(script, new { id }).FirstOrDefault();
            }
        }

        public void DeleteService(int id)
        {
            using(IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var script = @"DELETE * FROM Service Where Id=@Id";

                dbConnection.Query<ServiceModel>(script, new { id });
            }
        }

        public void UpdateService(ServiceModel service)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var script = @"UPDATE Services SET (ServiceName=@ServiceName,TypeService=@TypeService,Price=@Price) Where Id=Id";

                dbConnection.Query<ServiceModel>(script, service);
            }
        }
    }
}
