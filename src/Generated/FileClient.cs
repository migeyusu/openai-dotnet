// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace OpenAI.Files
{
    // Data plane generated sub-client.
    public partial class FileClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        public virtual ClientPipeline Pipeline => _pipeline;

        protected FileClient()
        {
        }

        internal PipelineMessage CreateCreateFileRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", contentType);
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetFilesRequest(string purpose, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files", false);
            if (purpose != null)
            {
                uri.AppendQuery("purpose", purpose, true);
            }
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateRetrieveFileRequest(string fileId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateDeleteFileRequest(string fileId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "DELETE";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateDownloadFileRequest(string fileId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            uri.AppendPath("/content", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
