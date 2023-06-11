using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListMe.Domain.Entities;
using MediatR;

namespace ListMe.Application.CQRS.Commands
{
    public class CreateListItemCommand : IRequest<ListItemInfo>
    {
        public string ItemName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Quantity { get; set; }

        public CreateListItemCommand(string itemName, string? description, int quantity)
        {
            ItemName = itemName;
            Description = description;
            Quantity = quantity;
        }
    }
}
