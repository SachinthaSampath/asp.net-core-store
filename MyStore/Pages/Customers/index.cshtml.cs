using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyStore.Pages.Customers
{
	

	public class indexModel : PageModel
	{
		public List<CustomerInfo> customerList = new List<CustomerInfo>();

		public void OnGet()
		{
			try
			{
				String conString = "Data Source=DESKTOP-6EV1VUB;Initial Catalog=ecom-app;Integrated Security=True";
				using (SqlConnection con = new SqlConnection(conString))
				{
					con.Open();
					String sql = "SELECT * FROM customer";
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								CustomerInfo ci = new CustomerInfo();
								ci.id = "" + reader.GetInt32(0);
								ci.name = reader.GetString(1);
								ci.email = reader.GetString(2);
								ci.address = reader.GetString(3);
								ci.contaxt = reader.GetString(4);
								customerList.Add(ci);
							}
						}
					}
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}


class CustomerInfo
{
	public string id;
	public string name;
	public string email;
	public string address;
	public string contaxt;
}
