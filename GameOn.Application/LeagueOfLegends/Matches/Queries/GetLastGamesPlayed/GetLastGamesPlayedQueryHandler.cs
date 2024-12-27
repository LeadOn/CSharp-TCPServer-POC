﻿// <copyright file="GetLastGamesPlayedQueryHandler.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace GameOn.Application.LeagueOfLegends.Matches.Queries.GetLastGamesPlayed
{
    using GameOn.Application.Common.Interfaces;
    using GameOn.Application.LeagueOfLegends.Matches.Commands.ImportLoLGames;
    using GameOn.External.RiotGames.Interfaces;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// GetLastGamesPlayedQueryHandler class.
    /// </summary>
    public class GetLastGamesPlayedQueryHandler : IRequestHandler<GetLastGamesPlayedQuery, IEnumerable<string>?>
    {
        private readonly IApplicationDbContext context;
        private readonly IMatchService matchService;
        private readonly ISender mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastGamesPlayedQueryHandler"/> class.
        /// </summary>
        /// <param name="context">DbContext, injected.</param>
        /// <param name="matchService">IMatchService, injected.</param>
        /// <param name="mediator">Mediator, injected.</param>
        public GetLastGamesPlayedQueryHandler(IApplicationDbContext context, IMatchService matchService, ISender mediator)
        {
            this.context = context;
            this.matchService = matchService;
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>?> Handle(GetLastGamesPlayedQuery request, CancellationToken cancellationToken)
        {
            // Getting player in database
            var playerInDb = await this.context.Players.FirstOrDefaultAsync(x => x.Id == request.PlayerId && x.RiotGamesPUUID != null);

            if (playerInDb == null)
            {
                return null;
            }
            else
            {
                // Getting IDs from Riot Games API
                var matchesFromRiot = await this.matchService.GetLastGamesPlayed(playerInDb.RiotGamesPUUID ?? throw new NotImplementedException(), cancellationToken);

                // Updating those games in database
                await this.mediator.Send(new ImportLoLGamesCommand { MatchIDs = matchesFromRiot.ToList() });

                return matchesFromRiot;
            }
        }
    }
}