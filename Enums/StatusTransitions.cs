using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Enums   

{
    public enum StatusTransitions
    {
        
        Awaiting_Payment = 0, PaymentAccept = 1, SentToCarrier = 2,
        Delivered = 3, Canceled = 4
    }
    
}