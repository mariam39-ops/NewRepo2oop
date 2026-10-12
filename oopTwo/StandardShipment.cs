using System;
using System.Collections.Generic;
using System.Text;

namespace oopTwo
{ 
    #region answer 4 StandardShipment
    internal class StandaredShipment:Shipment
    {
        public StandaredShipment(string t, string dec, decimal w, decimal df, DeliveryAddress d) : base(t, dec, w, df, d)
        {

        }
    #endregion
    }

}
