﻿namespace Twitter_backend.Contract
{
    public class ApiRoutes
    {
        public const string Root = "api/";
        public const string Auth = "auth/";

        public static class Tweets
        {
            public const string GetAll = Root + "tweets";
            public const string Get = Root + "tweets/{tweetId}";
            public const string Create = Root + "tweets";
            public const string Update = Root + "tweets/{tweetId}";
            public const string Delete = Root + "tweets/{tweetId}";
        }

        public static class Accounts
        {
            public const string Authenticate = Root + Auth + "login";
            public const string Register = Root + Auth + "register";
            public const string LogOut = Root + Auth + "logout";
            public const string ConfirmEmail = Root + Auth + "confirmemail";
        }

        public static class Comments
        {
            public const string GetAll = Root + "comments";
            public const string Get = Root + "comments/{commentId}";
            public const string Create = Root + "comments";
            public const string Update = Root + "comments/{commentId}";
            public const string Delete = Root + "comments/{commentId}";
        }
    }
}
