﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enexure.Sql.Dynamic
{
	public abstract class Aggregate : Select
	{
		public Aggregate(Expression expression)
			: base(expression)
		{
		}

		public abstract string Function { get; }
	}
}
