﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using Sportradar.OddsFeed.SDK.Entities.REST.Internal.DTO;
using Sportradar.OddsFeed.SDK.Messages.REST;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Internal.Mapping
{
    /// <summary>
    /// A factory used to create <see cref="ISingleTypeMapper{T}"/> instances used to map <see cref="tournamentsEndpoint"/> instances to
    /// <see cref="EntityList{SportDTO}"/> instances
    /// </summary>
    /// <seealso cref="ISingleTypeMapperFactory{TOut,TIn}" />
    internal class TournamentsMapperFactory : ISingleTypeMapperFactory<tournamentsEndpoint, EntityList<SportDTO>>
    {
        /// <summary>
        /// Creates and returns a <see cref="ISingleTypeMapper{T}" /> instance used to map <see cref="tournamentsEndpoint"/> instances to
        /// <see cref="EntityList{SportDTO}"/> instances
        /// </summary>
        /// <param name="data">A <see cref="tournamentsEndpoint" /> instance which the created <see cref="ISingleTypeMapper{T}" /> will map</param>
        /// <returns>The constructed <see cref="ISingleTypeMapper{T}" /> instance</returns>
        public ISingleTypeMapper<EntityList<SportDTO>> CreateMapper(tournamentsEndpoint data)
        {
            return TournamentsMapper.Create(data);
        }
    }
}
