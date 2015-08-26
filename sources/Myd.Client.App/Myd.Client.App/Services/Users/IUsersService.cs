﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Myd.Client.App.Services.Users
{
    public interface IUsersService
    {
        Task<List<User>> GetUsersAsync(GetUsersRequest request);
    }
}
