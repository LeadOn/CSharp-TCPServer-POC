﻿// <copyright file="IFifaTeamRepository.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace YuFoot.Repository.Contracts
{
    using System.Linq.Expressions;
    using YuFoot.Entities;

    /// <summary>
    /// Fifa Team repository.
    /// </summary>
    public interface IFifaTeamRepository
    {
        /// <summary>
        /// Get all teams in database.
        /// </summary>
        /// <returns>List of Teams.</returns>
        Task<IEnumerable<FifaTeam>> GetAll();
    }
}