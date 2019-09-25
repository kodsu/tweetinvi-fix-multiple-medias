﻿using Tweetinvi.Models;
using Tweetinvi.Parameters.Optionals;

namespace Tweetinvi.Parameters
{
    public interface IGetFollowersParameters : IGetFollowerIdsParameters, IGetUsersOptionalParameters
    {
        /// <summary>
        /// Page size when retrieving the users objects from Twitter
        /// </summary>
        int GetUsersPageSize { get; set; }
    }

    public class GetFollowersParameters : GetFollowerIdsParameters, IGetFollowersParameters
    {
        public GetFollowersParameters(IUserIdentifier userIdentifier) : base(userIdentifier)
        {
            GetUsersPageSize = TweetinviConsts.GET_USERS_MAX_PAGE_SIZE;
        }

        public GetFollowersParameters(string username) : base(username)
        {
            GetUsersPageSize = TweetinviConsts.GET_USERS_MAX_PAGE_SIZE;
        }

        public GetFollowersParameters(long userId) : base(userId)
        {
            GetUsersPageSize = TweetinviConsts.GET_USERS_MAX_PAGE_SIZE;
        }

        public GetFollowersParameters(IGetFollowersParameters parameters) : base(parameters)
        {
            GetUsersPageSize = TweetinviConsts.GET_USERS_MAX_PAGE_SIZE;
            
            if (parameters == null) { return; }
            
            SkipStatus = parameters.SkipStatus;
            IncludeEntities = parameters.IncludeEntities;
            GetUsersPageSize = parameters.GetUsersPageSize;
        }

        public bool? SkipStatus { get; set; }
        public bool? IncludeEntities { get; set; }
        public int GetUsersPageSize { get; set; }
    }
}
