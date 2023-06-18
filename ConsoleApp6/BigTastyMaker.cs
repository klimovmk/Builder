using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class BigTastyMaker
	{

		public IBurgerBuilder _builder;

		public BigTastyMaker(IBurgerBuilder builder)
		{
			_builder = builder;
		}

		public void Build()
		{
			_builder.WithChease().WithName("BigTasty").WithOninon().WithTomate().WithSaltedCocumber().WithMeat(Meat.Beef).WithBacon();
		}
	}
}
