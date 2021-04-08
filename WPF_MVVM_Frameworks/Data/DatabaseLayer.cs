using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Frameworks.Model;
using System.Configuration;
using Microsoft.SqlServer.Server;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using WPF_MVVM_Frameworks.ViewModel;

namespace WPF_MVVM_Frameworks.Data
{
    public class DatabaseLayer
    {
        //public static List<User> GetEmployeeFromDatabase()
        //{
        //    try
        //    {
        //        DataTable dt = SqlHelper.ExecuteDataTable(AppConstants.getConnectionString(), CommandType.StoredProcedure, "[dbo].[uspGetUser]");

        //        var Employee = new List<User>();

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            var obj = new User()
        //            {
        //                ID = (string)row["ID"],
        //                FirstName = (string)row["FirstName"],
        //                LastName = (string)row["LastName"],
        //                DOB = (string)row["DOB"],
        //                Gender = (string)row["Gender"],
        //                Nationality = (string)row["Nationality"],
        //                Language = (string)row["Language"],
        //                Address = (string)row["Address"],
        //                Male = (bool)row["Male"],
        //                Female = (bool)row["Female"],
        //                Hindi = (bool)row["Hindi"],
        //                English = (bool)row["English"],
        //                French = (bool)row["French"]
        //            };

        //            Employee.Add(obj);
        //        }

        //        return Employee;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
