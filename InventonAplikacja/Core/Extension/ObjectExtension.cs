using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventonAplikacja.Core.Extension
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}