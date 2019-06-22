namespace Firepuma.Auditing.Abstractions.Tenants
{
    public interface ITenantNameProviderHolder
    {
        ITenantNameProvider Provider { get; set; }
    }
}
