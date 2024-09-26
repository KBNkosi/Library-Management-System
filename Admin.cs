using Newtonsoft.Json;

namespace LibrarySystemManagement;

public class Admin : User
{

    public Admin(int id, string name, string role, Library library) : base(id, name, role)
    {
        
    }
    
    
}
