﻿using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.BusinessLogic.Entities.Interfaces
{
    /// <summary>
    /// IEntityChanger
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public interface IEntityChanger<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Cambiar
        /// </summary>
        /// <param name="entity"></param>
        void Cambiar(TBe entity);
    }
}
