﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Message
{
    public class Metadata
    {
        public string Culture { get; private set; }
        public Guid? UserId { get; private set; }

        public Metadata(string culture, Guid? userId)
        {
            Culture = culture;
            UserId = userId;
        }
    }
}