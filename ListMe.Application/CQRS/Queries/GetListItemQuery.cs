using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListMe.Domain.DTO;
using MediatR;

namespace ListMe.Application.CQRS.Queries
{
    public class GetListItemQuery : IRequest<ListItemDTO>
    {
        public string ItemName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Quantity { get; set; }

        public GetListItemQuery(string itemName, string? description, int quantity)
        {
            ItemName = itemName;
            Description = description;
            Quantity = quantity;
        }
    }
}
