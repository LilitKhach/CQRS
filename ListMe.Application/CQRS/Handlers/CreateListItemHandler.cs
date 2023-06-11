using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListMe.Application.CQRS.Commands;
using ListMe.Domain.Entities;
using ListMe.Domain.Repositories;
using MediatR;

namespace ListMe.Application.CQRS.Handlers
{
    public class CreateListItemHandler : IRequestHandler<CreateListItemCommand, ListItemInfo>
    {
        private readonly IListItemRepository _listItemRepository;

        public CreateListItemHandler(IListItemRepository listItemRepository)
        {
            _listItemRepository = listItemRepository;
        }

        public async Task<ListItemInfo> Handle(CreateListItemCommand request, CancellationToken cancellationToken)
        {
            var listItemInfo = new ListItemInfo
            {
                ItemName = request.ItemName,
                Description = request.Description,
                Quantity = request.Quantity
            };

            return await _listItemRepository.AddAsync(listItemInfo);
        }
    }
}
