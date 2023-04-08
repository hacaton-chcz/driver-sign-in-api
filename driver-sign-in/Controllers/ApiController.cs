using driver_sign_in.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace driver_sign_in.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("create-invoice")]
        public async Task CreateInvoiceAsync(InvoiceCreationDto model)
        {
            Console.WriteLine(model);

            CarCreationDto car = new CarCreationDto
            {
                Id = model.Id,
                Number = model.CarNumber,
                IsChecked = false,
            };


            await _context.AddAsync(model);
            await _context.AddAsync(car);

            await _context.SaveChangesAsync();

            //try
            //{
            //    await _accountCreationCommandHandler.HandleAsync(accountCreationCommand);
            //    return StatusCode(CreatedStatusCode);
            //}
            //catch (Exception ex)
            //{
            //    return Problem(ex.Message, null, InternalServerErrorCode);
            //}
        }

/*        [HttpPost("create-car")]
        public async Task CreateCarAsync(CarCreationDto model)
        {
            Console.WriteLine(model);
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
       
        }*/
    }
}
