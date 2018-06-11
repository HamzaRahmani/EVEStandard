﻿using EVEStandard.Models;
using EVEStandard.Models.API;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EVEStandard.API
{
    /// <summary>
    /// Alliance API
    /// </summary>
    /// <seealso cref="EVEStandard.API.APIBase" />
    public class Alliance : APIBase
    {
        private readonly ILogger logger = LibraryLogging.CreateLogger<Alliance>();

        internal Alliance(string dataSource) : base(dataSource)
        {
        }

        /// <summary>
        /// Public information about an alliance.
        /// <para>GET /alliances/{alliance_id}/</para>
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID.</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag.</param>
        /// <returns><see cref="ESIModelDTO{T}"/> containing public data about an alliance.</returns>
        public async Task<ESIModelDTO<Models.Alliance>> GetAllianceInfoV3Async(int allianceId, string ifNoneMatch = null)
        {
            var responseModel = await GetAsync($"/v3/alliances/{allianceId}/", ifNoneMatch);

            checkResponse("GetAllianceInfoV3Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, logger);

            return returnModelDTO<Models.Alliance>(responseModel);
        }

        /// <summary>
        /// List all current member corporations of an alliance.
        /// <para>GET /alliances/{alliance_id}/corporations/</para>
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID.</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag.</param>
        /// <returns><see cref="ESIModelDTO{T}"/> containing list of corporation IDs</returns>
        public async Task<ESIModelDTO<List<int>>> ListAllianceCorporationsV1Async(int allianceId, string ifNoneMatch = null)
        {
            var responseModel = await GetAsync($"/v1/alliances/{allianceId}/corporations/", ifNoneMatch);

            checkResponse("ListAllianceCorporationsV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, logger);

            return returnModelDTO<List<int>>(responseModel);
        }

        /// <summary>
        /// Resolve a set of alliance IDs to alliance names.
        /// <para>GET /alliances/names/</para>
        /// </summary>
        /// <param name="allianceIds">List of alliance IDs.</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag.</param>
        /// <returns><see cref="ESIModelDTO{T}"/> containing a list of id/name associations.</returns>
        public async Task<ESIModelDTO<List<AllianceName>>> GetAllianceNamesV2Async(List<int> allianceIds, string ifNoneMatch = null)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "alliance_ids", allianceIds == null || allianceIds.Count == 0 ? "" : string.Join(",", allianceIds) }
            };

            var responseModel = await GetAsync("/v2/alliances/names/", ifNoneMatch, queryParameters);

            checkResponse("GetAllianceNamesV2Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, logger);

            return returnModelDTO<List<AllianceName>>(responseModel);
        }

        /// <summary>
        /// Get the icon urls for a alliance.
        /// <para>GET /alliances/{alliance_id}/icons/</para>
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID.</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag.</param>
        /// <returns><see cref="ESIModelDTO{T}"/> containing icon URLs for the given alliance id.</returns>
        public async Task<ESIModelDTO<AllianceIcons>> GetAllianceIconV1Async(int allianceId, string ifNoneMatch = null)
        {
            var responseModel = await GetAsync($"/v1/alliances/{allianceId}/icons/", ifNoneMatch);

            checkResponse("GetAllianceIconV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, logger);

            return returnModelDTO<AllianceIcons>(responseModel);
        }

        /// <summary>
        /// List all active player alliances.
        /// <para>GET /alliances/</para>
        /// </summary>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag.</param>
        /// <returns><see cref="ESIModelDTO{T}"/> containing a list of alliance IDs.</returns>
        public async Task<ESIModelDTO<List<int>>> ListAllAlliancesV1Async(string ifNoneMatch = null)
        {
            var responseModel = await GetAsync("/v1/alliances/", ifNoneMatch);

            checkResponse("ListAllAlliancesV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, logger);

            return returnModelDTO<List<int>>(responseModel);
        }
    }
}
