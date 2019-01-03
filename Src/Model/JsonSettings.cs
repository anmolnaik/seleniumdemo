using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SeleniumDemoApplication.Src.Model
{
    class JsonSettings
    {
        public int Id { get; set; }
        public string UUID { get; set; }
        public int SSN { get; set; }
        public string Message { get; set; }
        public string PriceRange { get; set; }
        public string Color { get; set; }
        public string SearchText { get; set; }
    }

}
