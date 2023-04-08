using driver_sign_in.Models.Dtos;
using driver_sign_in.Models.Entities;
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
            var productId = _context.Products.Where(p => p.Name == model.ProductName).First().Id;
            if (productId != null)
            {

                InvoiceEntity invoice = new InvoiceEntity
                {
                    InvoiceId = model.InvoiceId,
                    CarNumber = model.CarNumber,
                    DriverFullName = model.DriverFullName,
                    productId = _context.Products.Where(p => p.Name == model.ProductName).First().Id,
                    //ProductId = 0,
                    ProductAmount = model.ProductAmount,
                    Status = StatusesEnum.CREATED,
                    MustBeOnCheckUtc = null,
                    StatusUpdatedUtc = DateTime.UtcNow,
                    From = model.From,
                    To = model.To,
                };
                Console.WriteLine(invoice);

                await _context.AddAsync(invoice);
                await _context.SaveChangesAsync();
            }
        }

        [HttpPost("set-arrival")]
        public async Task SetArrivalAsync(ArrivalSettingDto model)
        {
            var invoice = _context.Invoices.Where(p => p.InvoiceId == model.InvoiceId).First();
            if (invoice != null & model.IsArrived) 
            {
                invoice.Status = StatusesEnum.ARRIVED;
                invoice.StatusUpdatedUtc = DateTime.UtcNow;
                
                await _context.SaveChangesAsync();
            }
        }

        [HttpPost("set-passed")]
        public async Task SetPassedAsync(PassSettingDto model)
        {
            var invoice = _context.Invoices.Where(p => p.InvoiceId == model.InvoiceId).First();
            if (invoice != null & model.IsPassed)
            {
                invoice.Status = StatusesEnum.PASSED_INSPECTION;
                invoice.StatusUpdatedUtc = DateTime.UtcNow;
                invoice.MustBeOnCheckUtc = null;

                await _context.SaveChangesAsync();
            }
        }
    }
}
