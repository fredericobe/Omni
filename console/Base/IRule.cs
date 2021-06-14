
using console.Base;

namespace console.Base
{
    public interface IRule
    {
        string Name { get; }
        string ErrorMassage { get; }
        bool Validate(IClient client, IProduct product);

    }
}
