using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GAP.Models
{
    public class Client
    {
        public int Id { get; set; }     
        public int Document { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Insurance> Insurance { get; set; }
    }
}
