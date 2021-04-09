using System;
using System.Collections.Generic;
using System.Text;

namespace ParraTestGFT
{
    public class Trade
    {
        public ClientSector ClientSector { get; set; }
        public double Value { get; set; }
        public TradeCategories TradeCategories { get; set; }

        public Trade(double value, ClientSector clientSector)
        {
            ClientSector = clientSector;
            Value = value;
        }
    }
}
