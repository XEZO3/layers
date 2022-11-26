using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int duration { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
