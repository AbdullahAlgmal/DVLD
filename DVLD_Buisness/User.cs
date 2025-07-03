namespace DVLD_Buisness
{   
    public class User
    {
        static public DataTable GetAll() => UserQuery.GetAll();
        static public UserModel? Find(int UserId) => UserQuery.Get(UserId);
        static public UserModel? FindForPersonId(int PersonId) => UserQuery.GetForPersonId(PersonId);
        static public UserModel? Find(string UserName, string Password) => UserQuery.Get(UserName, Password);
        static public bool Add(UserModel Model) => UserQuery.Add(Model);
        static public bool Update(UserModel Model) => UserQuery.Update(Model);
        static public bool Delete(int Id) => UserQuery.Delete(Id);
        public static bool Exist(int Id) => UserQuery.Exist(Id);
        public static bool Exist(string UserName) => UserQuery.Exist(UserName);
        public static bool ExistForPersonId(int PersonId) => UserQuery.ExistForPersonId(PersonId);
        public static bool ChangePassword(int UserId, string NewPassword) => UserQuery.ChangePassword(UserId, NewPassword);
    }
}
