﻿// <copyright file="SearchTeamPlayerQuery.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace YuGames.Application.TeamPlayers.Queries.SearchTeamPlayer
{
    using System.Linq.Expressions;
    using MediatR;
    using YuGames.Common.DTOs;
    using YuGames.Domain;

    /// <summary>
    /// SearchTeamPlayerQuery class.
    /// </summary>
    public class SearchTeamPlayerQuery : IRequest<IEnumerable<FifaTeamPlayer>>
    {
        /// <summary>
        /// Gets or sets query.
        /// </summary>
        public Expression<Func<FifaTeamPlayer, bool>> Query { get; set; } = null!;

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        public int Limit { get; set; }
    }
}
