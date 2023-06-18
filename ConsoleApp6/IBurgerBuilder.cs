using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public interface IBurgerBuilder
	{
		public IBurgerBuilder WithName(string name);
		public IBurgerBuilder WithChease();

		public IBurgerBuilder WithTomate();

		public IBurgerBuilder WithBacon();

		public IBurgerBuilder WithSaltedCocumber();

		public IBurgerBuilder WithOninon();

		public IBurgerBuilder WithMeat(Meat type);

		public Burger GetBurger();
	}
}
