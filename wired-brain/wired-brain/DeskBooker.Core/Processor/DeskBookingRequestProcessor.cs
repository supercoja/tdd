﻿using System;
using DeskBooker.Core.Domain;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessor
    {

        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            if (request==null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return new DeskBookingResult
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                DateTime = request.DateTime
            };
        }
    }
}