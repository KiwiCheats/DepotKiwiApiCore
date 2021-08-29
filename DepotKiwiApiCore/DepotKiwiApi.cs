using System;
using System.Collections.Generic;
using System.Net;

using DepotKiwiApiCore.Models;
using DepotKiwiApiCore.RequestModels;
using DepotKiwiApiCore.Utils;

namespace DepotKiwiApiCore {
    public class Api {
        public Api(string api) {
            _requestHelper = new RequestHelper(api);
        }
        
        public StatusResponse CreateRepository(string name) {
            return _requestHelper.Post<StatusResponse, DepotCreateRequest>("depot/create", new DepotCreateRequest {
                Name = name
            });
        }
        
        public StatusResponse DeleteRepository(string id) {
            return _requestHelper.Post<StatusResponse, DepotDeleteRequest>("depot/delete", new DepotDeleteRequest {
                Id = id
            });
        }

        public List<DepotListResponse> ListRepositories() {
            return _requestHelper.Get<List<DepotListResponse>>("depot/list", new());
        }

        public Depot GetDepot(string id) {
            var response = _requestHelper.Get<DepotInfoResponse>($"depot/info/{id}", new());

            return response.Success ? response.Depot : null;
        }

        public byte[] DownloadFile(string depotId, string file) {
            var buffer = _requestHelper.GetRaw($"depot/file/download/{depotId}/{file}", new(), out var status);

            return status == HttpStatusCode.OK ? buffer : null;
        }

        public StatusResponse DeleteFile(string depotId, string file) {
            return _requestHelper.Post<StatusResponse>($"depot/file/delete/{depotId}/{file}", new());
        }

        public StatusResponse UploadFile(string depotId, string name, byte[] buffer) {
            return _requestHelper.Post<StatusResponse, DepotFileUploadRequest>($"depot/file/upload/{depotId}/{name}", new() {
                Data = Convert.ToBase64String(buffer)
            });
        }

        private readonly RequestHelper _requestHelper;
    }
}