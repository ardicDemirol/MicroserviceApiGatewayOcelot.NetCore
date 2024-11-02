using Contact.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController(IContactService ContactService) : ControllerBase
{
    private readonly IContactService contactService = ContactService;

    [HttpGet]
    public Models.ContactModels.Contact Get()
    {
        return contactService.GetContact();
    }

    [HttpGet("{Id}")]
    public Models.ContactModels.Contact GetContactById(Guid Id)
    {
        return contactService.GetContactById(Id);
    }
}
