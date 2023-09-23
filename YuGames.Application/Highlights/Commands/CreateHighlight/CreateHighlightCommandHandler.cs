﻿// <copyright file="CreateHighlightCommandHandler.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace YuGames.Application.Highlights.Commands.CreateHighlight
{
    using MediatR;
    using YuGames.Application.Common.Interfaces;
    using YuGames.Application.FifaGamePlayed.Queries.GetFifaGamePlayedById;
    using YuGames.Application.Players.Queries.GetPlayerById;
    using YuGames.Domain;

    /// <summary>
    /// CreateHighlightCommandHandler class.
    /// </summary>
    public class CreateHighlightCommandHandler : IRequestHandler<CreateHighlightCommand, Highlight>
    {
        private readonly IApplicationDbContext context;
        private readonly ISender mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHighlightCommandHandler"/> class.
        /// </summary>
        /// <param name="context">DbContext, injected.</param>
        /// <param name="mediator">Mediator, injected.</param>
        public CreateHighlightCommandHandler(IApplicationDbContext context, ISender mediator)
        {
            this.context = context;
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public async Task<Highlight> Handle(CreateHighlightCommand request, CancellationToken cancellationToken)
        {
            var playerInDb = await this.mediator.Send(
                new GetPlayerByIdQuery
                { PlayerId = request.Highlight.CreatedById }, cancellationToken);

            if (playerInDb is null)
            {
                throw new NotImplementedException();
            }

            var gameInDb = await this.mediator.Send(new GetFifaGamePlayedByIdQuery { FifaGamePlayedId = request.Highlight.FifaGameId }, cancellationToken);

            if (gameInDb is null)
            {
                throw new NotImplementedException();
            }

            this.context.Highlights.Add(request.Highlight);
            await this.context.SaveChangesAsync(cancellationToken);
            return request.Highlight;
        }
    }
}
