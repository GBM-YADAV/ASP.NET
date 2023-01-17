using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_In_Memory_crud_Operations.Models;
using MVC_In_Memory_crud_Operations.Models.Services;

namespace MVC_In_Memory_crud_Operations.Controllers
{
	public class CustomerController : Controller
	{
		public IActionResult Index()
		{
			List<Customer> customers = CustomerService.GetCustomers();
			return View(customers);
		}
		public ActionResult Details(int id)
		{
			Customer customer = CustomerService.GetCustomer(id);
			return View(customer);
		}


		////edit single record
		//[HttpGet("{id}")]
		//public ActionResult Edit(int id)
		//{
		//	Customer customer = CustomerService.GetCustomer(id);

		//	return View(customer);
		//}
		//[HttpPost("{id}")]
		//public ActionResult Edit(int id, Customer ModifiedCustomer)
		//{

			
		
		//		CustomerService.AddCustomer( ModifiedCustomer);
		//	   return RedirectToAction(nameof(Index));
		
		//}

		//// Add new customer 

		[HttpGet]
		public ActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Add(Customer newCostomer)
		{
			try
			{


			   CustomerService.AddCustomer(newCostomer);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}

		}

		public ActionResult Delete(int id)
		{
			CustomerService.DeleteCustomer(id);
			return RedirectToAction(nameof(Index));
		}
		//[HttpGet]
		//public ActionResult Delete(int id)
		//{
		//	return View(CustomerService.GetCustomer(id));
		//}

		//[HttpPost]
  //      public ActionResult Delete(int id,Customer delObj)
  //      {
		//	try
		//	{
		//		CustomerService.DeleteCustomer(id);
		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch
		//	{
		//		return View();
		//	}
  //      }
    }
}
