using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_CodeProjectV1.Models
	{
	public class Order
		{
		[Key]
		public int ID { get; set; }
		public virtual  Restaurant restauraunt { get; set; }
		public  virtual Customer customer { get; set; }
		public virtual List<FoodItem> FoodOrdered { get; set; }
		}
	}
