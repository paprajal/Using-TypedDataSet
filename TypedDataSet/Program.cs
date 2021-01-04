using System;

namespace TypedDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\tAssignment 2: Prajal Patel\n");

            CurdOperationsInTypedDataSet crud = new CurdOperationsInTypedDataSet();

            do
            {
                int choice = DisplayMenu();

                switch (choice)
                {
                    case 1: 
                        crud.GetAllEmployees();
                        
                        break;

                    case 2: 
                       Console.Write("\nEnter FirstName of Employee: \n");
                         Console.ReadLine();
                        crud.GetEmployeeByName();
                        
                        break;

                    

                    case 3: 
                        crud.GetEmployeesByAge();
                        break;
                    

                    case 4: 
                        crud.GetAllOrders();
                        break;
                    
                    case 5: 
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        static int DisplayMenu()
        {
            
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Get all Employees");
            Console.WriteLine("\t2 - Search Employee by Name");
            Console.WriteLine("\t3 - Sort Employees by Age");
            Console.WriteLine("\t4 - Get all orders");
            Console.WriteLine("\t5 - Exit");
            

            Console.Write("\nEnter your choice: \n");
            return int.Parse(Console.ReadLine());
        }
    }
}
