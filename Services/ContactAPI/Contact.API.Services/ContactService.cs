using Contact.API.Infrastructure;

namespace Contact.API.Services;

public class ContactService : IContactService
{
    public Models.ContactModels.Contact GetContact()
    {
        return new Models.ContactModels.Contact()
        {
            Id = Guid.NewGuid(),
            FirstName = "Ardic",
            LastName = "Demirol"
        };
    }

    public Models.ContactModels.Contact GetContactById(Guid Id)
    {
        return new Models.ContactModels.Contact()
        {
            Id = Id,
            FirstName = "Ardic",
            LastName = "Demirol"
        };
    }
}
