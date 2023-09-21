﻿// <copyright file="GetFifaTeamByIdQueryHandler.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace YuGames.Application.FifaTeams.Queries.GetFifaTeamById
{
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using YuGames.Application.Common.Interfaces;
    using YuGames.Domain;

    /// <summary>
    /// GetFifaTeamByIdQueryHandler class.
    /// </summary>
    public class GetFifaTeamByIdQueryHandler : IRequestHandler<GetFifaTeamByIdQuery, FifaTeam?>
    {
        private readonly IApplicationDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFifaTeamByIdQueryHandler"/> class.
        /// </summary>
        /// <param name="context">DbContext, injected.</param>
        public GetFifaTeamByIdQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        /// <inheritdoc />
        public async Task<FifaTeam?> Handle(GetFifaTeamByIdQuery request, CancellationToken cancellationToken)
        {
            return await this.context.FifaTeams.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
