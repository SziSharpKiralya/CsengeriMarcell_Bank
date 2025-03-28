using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBank
{
	internal sealed class Owner
	{
		string ownerName;

		public Owner(string ownerName)
		{
			OwnerName = ownerName;
		}

		public string OwnerName { get => ownerName; set => ownerName = value; }
	}
}
