using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_CodeProjectV1.Models
	{
	public class FoodItem
		{
		[Key]
		public int ID { get; set; }
		public string DishName { get; set; }
		public decimal DishPrice { get; set; }

		}
	}
