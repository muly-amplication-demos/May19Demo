using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mydotnet.APIs;
using Mydotnet.APIs.Dtos;
using Mydotnet.APIs.Errors;

namespace Mydotnet.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class OrdersControllerBase : ControllerBase
{
    protected readonly IOrdersService _service;

    public OrdersControllerBase(IOrdersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Order
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Order>> CreateOrder(OrderCreateInput input)
    {
        var order = await _service.CreateOrder(input);

        return CreatedAtAction(nameof(Order), new { id = order.Id }, order);
    }

    /// <summary>
    /// Find many Orders
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Order>>> Orders([FromQuery()] OrderFindManyArgs filter)
    {
        return Ok(await _service.Orders(filter));
    }

    /// <summary>
    /// Get one Order
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Order>> Order([FromRoute()] OrderWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Order(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Order
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOrder(
        [FromRoute()] OrderWhereUniqueInput uniqueId,
        [FromQuery()] OrderUpdateInput orderUpdateDto
    )
    {
        try
        {
            await _service.UpdateOrder(uniqueId, orderUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a customer record for Order
    /// </summary>
    [HttpGet("{Id}/customers")]
    public async Task<ActionResult<List<Customer>>> GetCustomer(
        [FromRoute()] OrderWhereUniqueInput uniqueId
    )
    {
        var customer = await _service.GetCustomer(uniqueId);
        return Ok(customer);
    }

    [HttpGet("{Id}/order-custom-two")]
    [Authorize(Roles = "user")]
    public async Task<string> OrderCustomTwo([FromBody()] string data)
    {
        return await _service.OrderCustomTwo(data);
    }
}
