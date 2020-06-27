using System;
using System.Collections.Generic;
using System.Text;

namespace zCzosnkowym.Api.Enums
{
    public enum OrderState
    {
        None = 0,
        New = 1,
        Open = 2,
        InProgress = 3,
        Completed = 4,
        Cancelled = 5
    }
}
