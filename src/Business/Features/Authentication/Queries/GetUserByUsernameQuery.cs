﻿#region

using Core.Entities.DTOs.Authentication.Responses;
using Core.Utilities.Results;
using MediatR;

#endregion

namespace Business.Features.Authentication.Queries
{
    public class GetUserByUsernameQuery:IRequest<IDataResult<UserResponse>>
    {
        public string Username { get; set; }
    }
}