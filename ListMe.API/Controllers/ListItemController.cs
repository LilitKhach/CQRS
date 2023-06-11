using ListMe.Application.CQRS.Commands;
using ListMe.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ListMe.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ListItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ListItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ListItemInfo> AddListItemAsync(ListItemInfo listItem)
        {
            return await _mediator.Send(new CreateListItemCommand(listItem.ItemName, listItem.Description, listItem.Quantity));
        }

    }
}
