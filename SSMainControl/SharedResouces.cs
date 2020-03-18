﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl
{
    public static class SharedResouces
    {
        private static ViewModelLocator instance;

        public static ViewModelLocator ViewModelLocator
        {
            get { return instance ?? (instance = new ViewModelLocator()); }
        }
    }
}
