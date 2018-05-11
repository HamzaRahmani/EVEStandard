﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EVEStandard.Enumerations;
using EVEStandard.Models;
using EVEStandard.Models.API;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EVEStandard.API
{
    public class Fittings : APIBase
    {
        private ILogger Logger { get; } = LibraryLogging.CreateLogger<Fittings>();
        internal Fittings(string dataSource) : base(dataSource)
        {
        }

        public async Task DeleteFittingV1Async(AuthDTO auth, long fittingId)
        {
            checkAuth(auth, Scopes.ESI_FITTINGS_WRITE_FITTINGS_1);

            var responseModel = await DeleteAsync("/v1/characters/" + auth.Character.CharacterID + "/fittings/" + fittingId + "/", auth);

            checkResponse("DeleteFittingV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);
        }

        public async Task<List<CharacterFitting>> GetFittingsV1Async(AuthDTO auth)
        {
            checkAuth(auth, Scopes.ESI_FITTINGS_READ_FITTINGS_1);

            var responseModel = await GetAsync("/v1/characters/" + auth.Character.CharacterID + "/fittings/", auth);

            checkResponse("TrackCorporationMembersV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return JsonConvert.DeserializeObject<List<CharacterFitting>>(responseModel.JSONString);
        }

        public async Task<long> CreateFittingV1Async(AuthDTO auth, ShipFitting fitting)
        {
            checkAuth(auth, Scopes.ESI_FITTINGS_READ_FITTINGS_1);

            var responseModel = await PostAsync("/v1/characters/" + auth.Character.CharacterID + "/fittings/", auth, fitting);

            checkResponse("TrackCorporationMembersV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return JsonConvert.DeserializeObject<long>(responseModel.JSONString);
        }
    }
}
