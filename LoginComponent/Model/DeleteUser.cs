using LoginComponent.TechnicalService;

namespace LoginComponent.Model    
{
    internal class DeleteUser
    {
        private ILoginDataMapper dm;
        private string password;
        private string username;

        public DeleteUser(string username, string password, ILoginDataMapper dm)
        {
            this.username = username;
            this.password = password;
            this.dm = dm;
        }
        public bool Execute()
        {
            return dm.Delete(username, Helper.HashPassword(password));            
        }
    }
}