using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Shared.Exceptions
{
  public  class CommonException:Exception
    {
        public string Message { get; set; }
    }
}
