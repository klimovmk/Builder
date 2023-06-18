using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class BigMagMaker
	{

		private IBurgerBuilder _builder;

		public BigMagMaker(IBurgerBuilder builder)
		{
			_builder = builder;
		}

		public void Build()
		{
			_builder.WithName("BigMag").WithChease().WithOninon().WithTomate().WithSaltedCocumber().WithMeat(Meat.Chiken);
		}

	}

}
