namespace ForgeFusion.Web.Models.Entities.Account
{
    public class User
    {
        public string Id { get; set; } = new Guid().ToString();
        public string DisplayName { get; set; } = string.Empty;
    }
}