using System;
using System.Collections.Generic;
using System.Text;

namespace TypedDataSet
{
    class CurdOperationsInTypedDataSet
    {
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter _adpEmployees;
        private NorthwindDataSet.EmployeesDataTable _tblEmployees;

        private NorthwindDataSetTableAdapters.OrdersTableAdapter _adpOrders;
        private NorthwindDataSet.OrdersDataTable _tblOrders;

        private NorthwindDataSetTableAdapters.EmployeeAgeTableAdapter _adpEmployeeAge;
        private NorthwindDataSet.EmployeeAgeDataTable _tblEmployeeAge;


        internal CurdOperationsInTypedDataSet()
        {
            _adpEmployees = new NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            _tblEmployees = new NorthwindDataSet.EmployeesDataTable();

            _adpOrders = new NorthwindDataSetTableAdapters.OrdersTableAdapter();
            _tblOrders = new NorthwindDataSet.OrdersDataTable();

            _adpEmployeeAge = new NorthwindDataSetTableAdapters.EmployeeAgeTableAdapter();
            _tblEmployeeAge = new NorthwindDataSet.EmployeeAgeDataTable();
        }

        internal void GetAllEmployees()
        {
            
            _tblEmployees = _adpEmployees.GetAllEmployees();

            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine($"EmployeeID \tFirstName \tLastName \tTitle  \t\tBirthDate \n");
            foreach (var row in _tblEmployees)
            {
                Console.WriteLine($"{row.EmployeeID,5} {row.FirstName,-10} {row.LastName,-10} {row.Title,-10} {row.B_Date,25}");
            }


        }
        internal void GetEmployeeByName()
        {
            
            _tblEmployees = _adpEmployees.GetEmployeeByName();

            Console.WriteLine($"EmployeeID \tFirstName \tLastName \tTitle  \t\tBirthDate \n");
            foreach (var row in _tblEmployees)
            {
                
                Console.WriteLine($"{row.EmployeeID,-15} {row.FirstName,-10} {row.LastName,-10} {row.Title,-10} {row.B_Date,25}");
            }


        }
        internal void GetEmployeesByAge() 
        {
            _tblEmployeeAge = _adpEmployeeAge.GetEmployeesByAge();
            Console.WriteLine($"EmployeeID \tFirstName \tLastName \tTitle  \t\t\tBirthDate \t\t\t\tAge\n");
            foreach (var row in _tblEmployeeAge)
            {
                Console.WriteLine($"{row.EmployeeID,-5} {row.FirstName,-10} {row.LastName,-10} {row.Title,-30} {row.BirthDate,40} {row.Age,15}");
            }
        }
        internal void GetAllOrders() 
        {
            _tblOrders = _adpOrders.GetAllOrders();
            Console.WriteLine($"OrderID \tEmployeeName \t\t\tShipCity \t\t\t\tShipCountry \t\t\tOrderDate \t\tShippedDate  \n");
            foreach (var row in _tblOrders)
            {
                Console.WriteLine($"{row.OrderID,5} {row.EmployeeName,-40} {row.ShipCity,-40} {row.ShipCountry,-40} {row.OrderDate,0} {row.ShippedDate,10}");
            }
        }






        }

    }


