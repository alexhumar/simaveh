﻿using Microsoft.AspNetCore.Http;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Model.Interfaces
{
    /// <summary>
    /// Interfaz de RelatedEntityAdder
    /// </summary>
    public interface IRelatedEntityAdder
    {
        /// <summary>
        /// TryAddRelatedEntityAsync
        /// </summary>
        /// <typeparam name="TTargetBe"></typeparam>
        /// <typeparam name="TTargetBeId"></typeparam>
        /// <typeparam name="TRelatedBe"></typeparam>
        /// <typeparam name="TRelatedBeId"></typeparam>
        /// <param name="request"></param>
        /// <param name="link"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<HttpStatusCode> TryAddRelatedEntityAsync<TTargetBe, TTargetBeId, TRelatedBe, TRelatedBeId>(HttpRequest request, Uri link, TTargetBeId key)
            where TTargetBe : DomainMember<TTargetBeId>, ICollectionManager<TRelatedBe, TRelatedBeId, TTargetBe, TTargetBeId>
            where TRelatedBe : DomainMember<TRelatedBeId>;
    }
}