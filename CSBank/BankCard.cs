using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBank
{
	internal class BankCard : BankingService
	{
		double accountBalance;
		string cardNumber;

		public string CardNumber { get; }
		public double AccountBalance { get; }

		public BankCard(Owner owner, double accountBalance, string cardNumber) : base(owner)
		{
			this.cardNumber = cardNumber;
			this.accountBalance = accountBalance;
		}

		public bool Purchase(double amount)
		{
			if (accountBalance - amount >= 0)
			{
				accountBalance -= amount;
				return true;
			}
			return false;
		}	
	}
}
