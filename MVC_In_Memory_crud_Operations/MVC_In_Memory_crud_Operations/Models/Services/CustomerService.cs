using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_In_Memory_crud_Operations.Models.Services
{
	static public class CustomerService
	{
		public static List<Customer> CustomerList { get; }
		static CustomerService()
		{
			CustomerList = new List<Customer> { new Customer {
			CustomerID=101,
			Name="Giri",
			Address="Chittoor",
			DOB=Convert.ToDateTime("2001-5-6"),
			PAN_Number="GRHUHTT494L"
		},

            new Customer {
            CustomerID=102,
            Name="Mouni",
            Address="penumur",
            DOB=Convert.ToDateTime("2001-5-6"),
            PAN_Number="HGRJRGRG56L"
        },

            new Customer {
            CustomerID=103,
            Name="vamsi",
            Address="hyd",
            DOB=Convert.ToDateTime("2001-3-6"),
            PAN_Number="ABCDEF556L"
        },
            new Customer {
            CustomerID=104,
            Name="kika",
            Address="chennai",
            DOB=Convert.ToDateTime("2001-5-6"),
            PAN_Number="HFRGJG64tL"
        }};
		}// Get all customers
        public static List<Customer> GetCustomers()
        {
            return CustomerList;
        }
            //get single customer
        public static Customer GetCustomer(int GivenId)
        {
            //select *from customer
            return CustomerList.FirstOrDefault(cust => cust.CustomerID == GivenId);
        }


        public static void UpdateCustomer(int id ,Customer modifiedCustomerobj)
        {
            int objectIndexInsideTheList = CustomerList.FindIndex(c => c.CustomerID == modifiedCustomerobj.CustomerID);

            if (objectIndexInsideTheList is -1)
                return;
            else
                CustomerList[objectIndexInsideTheList] = modifiedCustomerobj;
        }
        static int nextid = 105;
        public static void AddCustomer(Customer NewCustomer)
        {
            NewCustomer.CustomerID = nextid;
            CustomerList.Add(NewCustomer);
            nextid++;
        }

        public static void DeleteCustomer(int id )
        {
            var customer=GetCustomer(id);
            if(customer!=null)
            {
                CustomerList.Remove(customer);
            }
            else
            {
                return;
            }
       

        }



	}
}
