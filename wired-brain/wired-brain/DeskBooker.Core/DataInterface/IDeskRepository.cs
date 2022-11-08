﻿using System;
using System.Collections.Generic;
using DeskBooker.Core.Domain;

namespace DeskBooker.Core.DataInterface
{
    public interface IDeskRepository
    {
        public IEnumerable<Desk> GetAvailableDesks(DateTime date);
    }
}

