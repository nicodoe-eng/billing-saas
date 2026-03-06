namespace BillingSystem.Domain.Entities;

public class Tenant
{
    public Guid Id {get; private set;}
    public string Name {get; private set;}=string.Empty;
    public string Email {get; private set;} = string.Empty;
    public DateTime CreateAt {get; private set;}
    public bool IsActive {get; private set;}
    private Tenant() {}
    public Tenant(string name,string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        CreateAt = DateTime.UtcNow;
        IsActive = true;

    }

    public void Deactivate()
    {
        IsActive = false;
    }
}