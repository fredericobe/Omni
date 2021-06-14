
namespace Omni.Base
{
    public interface IClient
    {
        string Id { get; set; }
        string Name { get; set; }
        string InvestorId { get; set; }
        public ClientProfile? Profile { get; set; }
    }

}
