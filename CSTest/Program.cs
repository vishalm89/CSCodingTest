using System;
using System.Collections.Generic;

namespace CSTest
{
	public class Trade : ITrade
	{
		public double Value { get; set; }
		public string ClientSectore { get; set; }
        
    }
	class Program
    {

        static void Main(string[] args)
        {
			var Trade1 = new Trade { Value = 2000000, ClientSectore = "Private" };
			var Trade2 = new Trade { Value = 400000, ClientSectore = "Public" };
			var Trade3 = new Trade { Value = 500000, ClientSectore = "Public" };
			var Trade4 = new Trade { Value = 3000000, ClientSectore = "Public" };
			var portfolio = new List<ITrade> { Trade1, Trade2, Trade3, Trade4 };
			var tradeCategories = GetRiskType(portfolio);

			tradeCategories.ForEach(tradeCategory => Console.WriteLine(tradeCategory));
        }
		public static List<string> GetRiskType(List<ITrade> trades)
		{
			var result = new List<string>();

			foreach (var trade in trades)
			{
				foreach (var rule in Constants.ruleList)
				{
					switch (rule.operatorType)
					{
						case "Greater Than":
							if (trade.Value > rule.threshold && trade.ClientSectore == rule.sector)
							{
								result.Add(rule.riskType);
							}
							break;
						case "Less Than":
							if (trade.Value < rule.threshold && trade.ClientSectore == rule.sector)
							{
								result.Add(rule.riskType);
							}
							break;
					}
				}
			}
			return result;
		}
	}
}
