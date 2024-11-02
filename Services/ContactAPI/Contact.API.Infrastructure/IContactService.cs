namespace Contact.API.Infrastructure;

public interface IContactService
{
    public Models.ContactModels.Contact GetContact();

    public Models.ContactModels.Contact GetContactById(Guid Id);
}
