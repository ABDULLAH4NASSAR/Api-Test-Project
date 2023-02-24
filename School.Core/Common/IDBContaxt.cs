using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace School.Core.Common
{
    public interface IDBContaxt
    {
        DbConnection Connection { get; }
    }
}
