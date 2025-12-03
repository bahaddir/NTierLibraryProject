using Project.Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.Dtos
{
    public class BaseDto
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
