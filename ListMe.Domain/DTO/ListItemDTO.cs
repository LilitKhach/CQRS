using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMe.Domain.DTO
{
    public class ListItemDTO
    {
        public string ItemName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Quantity { get; set; }
    }
}
