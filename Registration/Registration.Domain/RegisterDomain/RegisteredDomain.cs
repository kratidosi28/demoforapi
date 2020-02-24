using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using Registration.UnitOfWork.Main;
using Registration.Models.Main;

namespace Registration.Domain.RegisterModule
{
    public class RegisteredDomain : IRegisteredDomain
    {
        public RegisteredDomain(IRegisterUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(Registered parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<Registered>().AllAsync();
        }

        public async Task<object> GetBy( Registered parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository <Registered>().FindByAsync(t => t.FirstName == "krati");
        }
        

        public HashSet<string> AddValidation(Registered entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Registered entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Registered entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Registered entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation( Registered parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync( Registered parameters)
        {
            var register = Uow.Repository<Registered>().FindByKey(parameters.Id);
            await Uow.RegisterDeletedAsync(register);
            await Uow.CommitAsync();
        }

        public IRegisterUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IRegisteredDomain : ICoreDomain<Registered,Registered> { }
}
