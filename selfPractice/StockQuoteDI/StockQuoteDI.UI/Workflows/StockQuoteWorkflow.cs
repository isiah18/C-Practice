using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuoteDI.BLL;
using StockQuoteDI.Models;

namespace StockQuoteDI.UI.Workflows
{
    public class StockQuoteWorkflow
    {
        public void Execute()
        {
            string type = UserPrompts.PromptForType();

            StockQuoteOperations ops = new StockQuoteOperations(type);

            string symbols = UserPrompts.PromptForSymbols();

            List<StockQuote> quotes = ops.RetrieveQuotes(symbols);

            DisplayQuotes(quotes);
        }

        private void DisplayQuotes(List<StockQuote> quotes)
        {
            Console.Clear();
            Console.WriteLine("Stock Data");
            Console.WriteLine("-------------------------------------");
            foreach (var stockQuote in quotes)
            {
                Console.WriteLine("{0} {1} - {2}", stockQuote.Symbol, stockQuote.CompanyName, stockQuote.StockPrice);
            }
        }
    }
}
