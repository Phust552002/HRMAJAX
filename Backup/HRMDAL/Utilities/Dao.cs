using System;
using System.Collections.Generic;
using System.Text;

namespace HRMDAL.Utilities
{
    public class Dao : IDisposable
    {

        public StoreProcedure sproc = null;
        public Dao()
        {

        }
        public void Dispose()
        {
            if (sproc != null)
            {
                sproc.Dispose();
                sproc = null;
            }
        }

    }
}
