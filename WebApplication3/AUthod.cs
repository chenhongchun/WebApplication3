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
            string ddd;
            return _Configuration["names"];
        }
    }
}
