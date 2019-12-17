using System;
using System.Collections.Generic;
using System.Text;

namespace Testability
{

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    class ShippingCalculator
    {
        if (order.TotalPrice < 30f)
            return order.TotalPrice * 0.1f;

        return 0;
    }
}
