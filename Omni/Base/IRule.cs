
using Omni.Base;

namespace Omni.Base
{
    public interface IRule
    {
        string Name { get; }
        string ErrorMassage { get; }
        bool Validate(IClient client, IProduct product);

    }
}
