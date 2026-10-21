using System;
using System.Collections.Generic;
using System.Text;

namespace Session02_AssignmentOOP
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        public ExpressShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination, decimal _extraFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            ExtraFee = _extraFee;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
    }
}
