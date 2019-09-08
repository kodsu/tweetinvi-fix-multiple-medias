﻿using Tweetinvi.Core.Parameters;
using Tweetinvi.Models;
using Tweetinvi.Models.DTO;
using Tweetinvi.Parameters;

namespace Tweetinvi.Core.QueryGenerators
{
    public interface IUserQueryGenerator
    {
        string GetAuthenticatedUserQuery (IGetAuthenticatedUserParameters parameters);
        string GetUserQuery(IGetUserParameters parameters);
        string GetUsersQuery(IGetUsersParameters parameters, TweetMode? tweetMode);


        string GetFriendIdsQuery(IGetFriendIdsParameters parameters);

        string GetFollowerIdsQuery (IGetFollowerIdsParameters parameters);


        string GetFavoriteTweetsQuery (IGetUserFavoritesQueryParameters parameters);

        // Block User
        string GetBlockUserQuery (IBlockUserParameters parameters);

        string GetUnBlockUserQuery (IUserIdentifier user);

        string GetBlockedUserIdsQuery ();
        string GetBlockedUsersQuery ();

        // Download Profile Image
        string DownloadProfileImageURL (IUserDTO userDTO, ImageSize size = ImageSize.normal);
        string DownloadProfileImageInHttpURL (IUserDTO userDTO, ImageSize size = ImageSize.normal);

        // Spam
        string GetReportUserForSpamQuery (IUserIdentifier user);
    }
}