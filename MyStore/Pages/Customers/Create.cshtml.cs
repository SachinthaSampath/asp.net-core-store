using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Data.SqlClient;

namespace MyStore.Pages.Customers
{
    public class CreateModel : PageModel
    {
		public CustomerInfo customerInfo = new CustomerInfo();
		public string errorMessage = "";
		public string successMessage = "";

        public void OnGet()
        {

        }
		public void OnPost()
		{
			customerInfo.address = Request.Form["address"];
			customerInfo.contaxt = Request.Form["contaxt"];
			customerInfo.email = Request.Form["email"];
			customerInfo.name = Request.Form["name"];

			if (customerInfo.name.Length == 0)
			{
				errorMessage = "All the fields are requred";
				return;
			}

			//save the client to the database

			try
			{
				String conString = "Data Source=DESKTOP-6EV1VUB;Initial Catalog=ecom-app;Integrated Security=True";
				using (SqlConnection con = new SqlConnection(conString))
				{
					con.Open();
					String sql = "INSERT INTO clients (name,email,address,contaxt) VALUES (@name,@email,@address,@contaxt);";
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@name", customerInfo.name);
						cmd.Parameters.AddWithValue("@email", customerInfo.email);
						cmd.Parameters.AddWithValue("@address", customerInfo.address);
						cmd.Parameters.AddWithValue("@contaxt", customerInfo.contaxt);

						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}

			customerInfo.name = "";
			customerInfo.address = "";
			customerInfo.contaxt = "";
			customerInfo.email = "";

			Response.Redirect("/Customers");
		}
    }

	public class CustomerInfo
	{
		public string id;
		public string name;
		public string email;
		public string address;
		public string contaxt;
	}

}