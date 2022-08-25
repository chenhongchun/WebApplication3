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

            string ddddd = "";
            return _Configuration["names"];
        }
    }
}
