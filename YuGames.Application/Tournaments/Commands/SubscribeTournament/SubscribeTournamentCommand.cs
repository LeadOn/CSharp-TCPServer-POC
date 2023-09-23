﻿// <copyright file="SubscribeTournamentCommand.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace YuGames.Application.Tournaments.Commands.SubscribeTournament
{
    using MediatR;
    using YuGames.Common.DTOs;
    using YuGames.Domain;

    /// <summary>
    /// SubscribeTournamentCommand class.
    /// </summary>
    public class SubscribeTournamentCommand : IRequest<TournamentPlayer>
    {
        /// <summary>
        /// Gets or sets Tournament ID.
        /// </summary>
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets ConnectedPlayer.
        /// </summary>
        public ConnectedPlayerDto Player { get; set; } = new ConnectedPlayerDto();

        /// <summary>
        /// Gets or sets Fifa Team ID.
        /// </summary>
        public int FifaTeamId { get; set; }
    }
}
