﻿// <copyright file="PlatformController.cs" company="LeadOn's Corp'">
// Copyright (c) LeadOn's Corp'. All rights reserved.
// </copyright>

namespace GameOn.Presentation.Controllers.Common
{
    using GameOn.Application.Common.Platforms.Commands.CreatePlatform;
    using GameOn.Application.Common.Platforms.Commands.UpdatePlatform;
    using GameOn.Application.Common.Platforms.Queries.GetAllPlatforms;
    using GameOn.Application.Common.Platforms.Queries.GetPlatformById;
    using GameOn.Domain;
    using MediatR;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Platform Controller.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PlatformController : ControllerBase
    {
        private readonly ISender mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformController"/> class.
        /// </summary>
        /// <param name="mediator">MediatR interface, injected.</param>
        public PlatformController(ISender mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Get all platforms in database.
        /// </summary>
        /// <returns>200 OK with Platform list.</returns>
        [HttpGet]
        [Route("")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Get all gaming platforms in database.")]
        [SwaggerResponse(200, "Platform in database.", typeof(List<Player>))]
        [SwaggerResponse(500, "Unknown error happened.")]
        public async Task<IActionResult> GetAll()
        {
            return this.Ok(await this.mediator.Send(new GetAllPlatformsQuery()));
        }

        /// <summary>
        /// Get platform by ID.
        /// </summary>
        /// <param name="platformId">Platform ID.</param>
        /// <returns>IActionResult object.</returns>
        [HttpGet]
        [Route("{platformId:int}")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Get platform by ID.")]
        [SwaggerResponse(200, "Platform.", typeof(Platform))]
        [SwaggerResponse(404, "Platform not found.")]
        [SwaggerResponse(500, "Unknown error happened.")]
        public async Task<IActionResult> GetById(int platformId)
        {
            var platformInDb = await this.mediator.Send(new GetPlatformByIdQuery { PlatformId = platformId });

            if (platformInDb is null)
            {
                return this.NotFound();
            }

            return this.Ok(platformInDb);
        }

        /// <summary>
        /// Creates platform in database.
        /// </summary>
        /// <param name="platform"><see cref="Platform" />.</param>
        /// <returns>IActionResult object.</returns>
        [HttpPost]
        [Authorize(Roles = "gameon_admin")]
        [Route("")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Creates a platform in database.")]
        [SwaggerResponse(200, "Created platform.", typeof(Platform))]
        [SwaggerResponse(401, "User is not logged in.")]
        [SwaggerResponse(403, "User isn't admin.")]
        [SwaggerResponse(500, "Unknown error.")]
        public async Task<IActionResult> Create([FromBody] Platform platform)
        {
            return this.Ok(await this.mediator.Send(new CreatePlatformCommand { Name = platform.Name }));
        }

        /// <summary>
        /// Updates platform in database.
        /// </summary>
        /// <param name="platform"><see cref="Platform" />.</param>
        /// <returns>IActionResult object.</returns>
        [HttpPatch]
        [Authorize(Roles = "gameon_admin")]
        [Route("")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Updates a platform in database.")]
        [SwaggerResponse(200, "Updated platform.", typeof(Platform))]
        [SwaggerResponse(401, "User is not logged in.")]
        [SwaggerResponse(403, "User isn't admin.")]
        [SwaggerResponse(500, "Unknown error.")]
        public async Task<IActionResult> Update([FromBody] Platform platform)
        {
            return this.Ok(await this.mediator.Send(new UpdatePlatformCommand { PlatformId = platform.Id, Name = platform.Name }));
        }
    }
}
