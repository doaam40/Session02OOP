using System;
using System.Collections.Generic;
using System.Text;

namespace Session02_AssignmentOOP
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {

        }
    }
}
