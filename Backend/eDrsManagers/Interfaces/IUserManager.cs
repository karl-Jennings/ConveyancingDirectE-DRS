﻿using eDrsManagers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eDrsManagers.Interfaces
{
    public interface IUserManager
    {
        UserViewModel Login(UserViewModel viewModel);

    }
}