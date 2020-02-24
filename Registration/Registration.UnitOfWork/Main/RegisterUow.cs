using RxWeb.Core.Data;
using Registration.BoundedContext.Main;

namespace Registration.UnitOfWork.Main
{
    public class RegisterUow : BaseUow, IRegisterUow
    {
        public RegisterUow(IRegisterContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IRegisterUow : ICoreUnitOfWork { }
}


