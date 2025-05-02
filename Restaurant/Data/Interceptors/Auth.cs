using Microsoft.AspNetCore.Authorization;

namespace Restaurant.Data.Interceptors
{
    public class Auth : Attribute, IAuthorizeData
    {
        ////////////// Action Filter:
        public string? Policy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Roles { get => "Admin"; set => Roles = ""; }
        public string? AuthenticationSchemes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
