using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class BigMagMakerWithoutOnin
	{
		private IBurgerBuilder _builder;

		public BigMagMakerWithoutOnin(IBurgerBuilder builder)
		{
			_builder = builder;
		}

		public void Build()
		{
			_builder.WithName("BigMag").WithChease().WithTomate().WithSaltedCocumber().WithMeat(Meat.Chiken);
		}
	}
}
