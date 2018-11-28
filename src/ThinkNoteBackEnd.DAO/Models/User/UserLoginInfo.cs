﻿using System;
using System.Collections.Generic;

namespace ThinkNoteBackEnd.DAO.User
{
    public partial class UserLoginInfo
    {
        public UserLoginInfo()
        {
            UserJoinGroups = new HashSet<UserJoinGroups>();
        }
        public long Uid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }

        public UserProfileInfo UserProfileInfo { get; set; }
        public ICollection<UserJoinGroups> UserJoinGroups { get; set; }
    }
    public class UserLoginStatus
    {
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
