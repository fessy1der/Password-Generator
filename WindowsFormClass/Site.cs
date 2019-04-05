using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClass
{
    public class Site
    {
        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public string Password { get; set; }

        [NotMapped]

        public int ObjectState { get; set; }


    }
}
