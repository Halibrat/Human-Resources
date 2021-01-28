using DevFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ServiceAdapters;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.ComplexType;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IKpsService _kpsService;
        public UserManager(IUserDal userDal,IKpsService kpsService)
        {
            _userDal = userDal;
            _kpsService = kpsService;
        }
        [FluentValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            ChcekIfUserExists(user);
            CheckIfUserValidFromsKps(user);
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
           return _userDal.GetList();
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }
        [FluentValidationAspect(typeof(UserValidator))]
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }
        [FluentValidationAspect(typeof(UserValidator))]
        public User GetByUserRoleName(string roleName)
        {
            return _userDal.Get(u => u.RoleName == roleName);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        private void ChcekIfUserExists(User user)
        {
            if (_userDal.Get(u=>u.TckNo==user.TckNo)!=null)
            {
                throw new Exception("Bu kullanıcı daha önce kayıt olmuştur");
            }
        }
        private void CheckIfUserValidFromsKps(User user)
        {
            if (_kpsService.ValidateUser(user)==false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil");
            }
        }
    }
}
