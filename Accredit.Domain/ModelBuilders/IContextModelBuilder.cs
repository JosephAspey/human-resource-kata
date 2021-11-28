using Microsoft.EntityFrameworkCore;

namespace Accredit.Domain.ModelBuilders
{
    public interface IContextModelBuilder
    {
        void Construct(ModelBuilder builder);
    }
}
