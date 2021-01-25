using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pod.Core.Domain
{
  public  class test
    {
        
        [Key]
        public int testid { get; set; }
        public string testname { get; set; }
    }
}
