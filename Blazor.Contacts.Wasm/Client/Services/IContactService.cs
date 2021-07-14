using Blazor.Contacts.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Client.Services
{
    public interface IContactService
    {
        Task SaveContact (Contact contact);
        Task DeleteContact(int id);
       // Task UpdateContact(Contact contact);
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetDetails( int i);
    }
}
