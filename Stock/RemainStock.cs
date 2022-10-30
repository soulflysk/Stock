using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class RemainStock
    {
            public delegate void StockHandler(string msgForCaller);
            public StockHandler listOfHandlers;
            // Just fire out the Exploded notification.
            public int Minus(int minus_value, int stock_accumulate)
            {
            int result = stock_accumulate - minus_value;
                if (result < 50)
                {
                    listOfHandlers("Stock ใกล้จะหมดแล้ว");
                    result = stock_accumulate;
                }
            return result;

        }
    }
}
