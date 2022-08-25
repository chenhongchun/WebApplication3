namespace WebApplication3
{
    public class AUthod: IAUthod
    {
        private IConfiguration _Configuration = null;
        public AUthod(IConfiguration configuration)
        {
            this._Configuration = configuration;
        }

        public string Show()
        {
            string str = string.Empty;
            return _Configuration["names"];
        }
    }
}
