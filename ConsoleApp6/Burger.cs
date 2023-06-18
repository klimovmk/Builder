using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Burger
	{
		public string Name { get; set; }

		public bool WithChees { get; set; }

		public bool WithTomato { get; set; }

		public bool WithOnion { get; set; }

		public Meat Meat { get; set; }

		public bool Bacoon { get; set; }

		public bool SaltedCocumber { get; set; }
	}

	public enum Meat: int
	{
		Chiken,
		Beef
	}
}
