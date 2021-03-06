﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevAssessment.Auth
{
    public class Constants
    {
        public const string EmailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


        #region Presisted Data's Keys

        public const string JwtToken = "JwtToken";
        public const string JwtTokenValidTime = "JwtTokenValidTime";
        public const string IsAdmin = "IsAdmin";

        #endregion
    }
}
