using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class BurgerBuilder : IBurgerBuilder
	{
		private Burger _burger;

        public BurgerBuilder()
        {
            _burger = new Burger();
        }

        public IBurgerBuilder WithBacon()
		{
			_burger.Bacoon = true;
			return this;
		}

		public IBurgerBuilder WithChease()
		{
			_burger.WithChees = true;
			return this;
		}

		public IBurgerBuilder WithSaltedCocumber()
		{
			_burger.SaltedCocumber = true;
			return this;
		}

		public IBurgerBuilder WithTomate()
		{
			_burger.WithTomato = true;
			return this;
		}

		public IBurgerBuilder WithOninon()
		{
			_burger.WithOnion = true;
			return this;
		}

		public IBurgerBuilder WithMeat(Meat meat)
		{
			_burger.Meat = meat;
			return this;
		}

		public Burger GetBurger()
		{
			var burger = _burger;

			_burger = new();

			return burger;
		}

		public IBurgerBuilder WithName(string name)
		{
			_burger.Name = name;
			return this;
		}
	}
}
