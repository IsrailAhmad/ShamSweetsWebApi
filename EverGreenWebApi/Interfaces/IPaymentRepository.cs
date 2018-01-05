﻿using EverGreenWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverGreenWebApi.Interfaces
{
    public interface IPaymentRepository : IDisposable
    {
        PaymentModel PaymentConfirm(PaymentModel model);
        PaymentModel PaymentConfirmforCOD(PaymentModel model);
    }
}