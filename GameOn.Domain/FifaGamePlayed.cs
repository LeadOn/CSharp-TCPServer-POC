﻿// <copyright file="FifaGamePlayed.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace GameOn.Domain
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// FifaGamePlayed class.
    /// </summary>
    public class FifaGamePlayed
    {
        /// <summary>
        /// Gets or sets player's ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets game date.
        /// </summary>
        public DateTime PlayedOn { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets Team 1 ID.
        /// </summary>
        public int Team1Id { get; set; }

        /// <summary>
        /// Gets or sets Team 2 ID.
        /// </summary>
        public int Team2Id { get; set; }

        /// <summary>
        /// Gets or sets team 1 score.
        /// </summary>
        public int TeamScore1 { get; set; }

        /// <summary>
        /// Gets or sets team 2 score.
        /// </summary>
        public int TeamScore2 { get; set; }

        /// <summary>
        /// Gets or sets Platform ID.
        /// </summary>
        public int PlatformId { get; set; }

        /// <summary>
        /// Gets or sets Created By ID.
        /// </summary>
        public int CreatedById { get; set; }

        /// <summary>
        /// Gets or sets Season ID.
        /// </summary>
        public int SeasonId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether game is played or planned.
        /// </summary>
        public bool IsPlayed { get; set; }

        /// <summary>
        /// Gets or sets Tournament ID.
        /// </summary>
        public int? TournamentId { get; set; }

        /// <summary>
        /// Gets or sets phase.
        /// </summary>
        public int? Phase { get; set; }

        /// <summary>
        /// Gets or sets TeamPlayers.
        /// </summary>
        [JsonIgnore]
        public virtual List<FifaTeamPlayer> TeamPlayers { get; set; } = null!;

        /// <summary>
        /// Gets or sets CreatedBy.
        /// </summary>
        [JsonIgnore]
        public virtual Player CreatedBy { get; set; } = null!;

        /// <summary>
        /// Gets or sets Tournament.
        /// </summary>
        [JsonIgnore]
        public virtual Tournament? Tournament { get; set; } = null!;

        /// <summary>
        /// Gets or sets Platform.
        /// </summary>
        [JsonIgnore]
        public virtual Platform? Platform { get; set; } = null!;

        /// <summary>
        /// Gets or sets Team 1.
        /// </summary>
        [JsonIgnore]
        public virtual FifaTeam Team1 { get; set; } = null!;

        /// <summary>
        /// Gets or sets Team 2.
        /// </summary>
        [JsonIgnore]
        public virtual FifaTeam Team2 { get; set; } = null!;

        /// <summary>
        /// Gets or sets Highlights.
        /// </summary>
        [JsonIgnore]
        public virtual List<Highlight> Highlights { get; set; } = null!;

        /// <summary>
        /// Gets or sets Season.
        /// </summary>
        [JsonIgnore]
        public virtual Season Season { get; set; } = null!;
    }
}