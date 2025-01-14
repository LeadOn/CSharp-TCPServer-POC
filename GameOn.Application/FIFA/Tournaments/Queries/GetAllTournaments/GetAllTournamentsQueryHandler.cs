﻿// <copyright file="GetAllTournamentsQueryHandler.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace GameOn.Application.FIFA.Tournaments.Queries.GetAllTournaments
{
    using GameOn.Common.Interfaces;
    using GameOn.Domain;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// GetAllTournamentsQueryHandler class.
    /// </summary>
    public class GetAllTournamentsQueryHandler : IRequestHandler<GetAllTournamentsQuery, IEnumerable<Tournament>>
    {
        private readonly IApplicationDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllTournamentsQueryHandler"/> class.
        /// </summary>
        /// <param name="context">DbContext, injected.</param>
        public GetAllTournamentsQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Tournament>> Handle(GetAllTournamentsQuery request, CancellationToken cancellationToken)
        {
            return await this.context.Tournaments.OrderBy(x => x.State).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
