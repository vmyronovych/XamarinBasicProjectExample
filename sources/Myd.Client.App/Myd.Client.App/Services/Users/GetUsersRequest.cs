namespace Myd.Client.App.Services.Users
{
    public class GetUsersRequest
    {
        public string SearchTerm { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
    }
}