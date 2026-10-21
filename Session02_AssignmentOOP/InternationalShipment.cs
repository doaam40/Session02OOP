using System;
using System.Collections.Generic;
using System.Text;

namespace Session02_AssignmentOOP
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination, decimal _customsFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            CustomsFee = _customsFee;
        }

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
    }
}
