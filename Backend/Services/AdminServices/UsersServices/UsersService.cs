﻿using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.UsersServices
{
    public interface UsersService
    {
        List<User> GetUsersList();

        void DownloadUserList();
    }
}