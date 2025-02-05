namespace Azure.DigitalTwins.Core
{
    public partial class DigitalTwinModelsAddOptions
    {
        public DigitalTwinModelsAddOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinModelsDeleteOptions
    {
        public DigitalTwinModelsDeleteOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinModelsGetByIdOptions
    {
        public DigitalTwinModelsGetByIdOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinModelsUpdateOptions
    {
        public DigitalTwinModelsUpdateOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsAddOptions
    {
        public DigitalTwinsAddOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsAddRelationshipOptions
    {
        public DigitalTwinsAddRelationshipOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsClient
    {
        protected DigitalTwinsClient() { }
        public DigitalTwinsClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public DigitalTwinsClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.DigitalTwins.Core.DigitalTwinsClientOptions options) { }
        public virtual Azure.Response<string> CreateDigitalTwin(string digitalTwinId, string digitalTwin, Azure.DigitalTwins.Core.DigitalTwinsAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> CreateDigitalTwinAsync(string digitalTwinId, string digitalTwin, Azure.DigitalTwins.Core.DigitalTwinsAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateEventRoute(string eventRouteId, Azure.DigitalTwins.Core.EventRoute eventRoute, Azure.DigitalTwins.Core.Models.EventRoutesAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.EventRoute eventRoute, Azure.DigitalTwins.Core.Models.EventRoutesAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData[]> CreateModels(System.Collections.Generic.IEnumerable<string> models, Azure.DigitalTwins.Core.DigitalTwinModelsAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData[]>> CreateModelsAsync(System.Collections.Generic.IEnumerable<string> models, Azure.DigitalTwins.Core.DigitalTwinModelsAddOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> CreateRelationship(string digitalTwinId, string relationshipId, string relationship, Azure.DigitalTwins.Core.DigitalTwinsAddRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> CreateRelationshipAsync(string digitalTwinId, string relationshipId, string relationship, Azure.DigitalTwins.Core.DigitalTwinsAddRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DecommissionModel(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsUpdateOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DecommissionModelAsync(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsUpdateOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteDigitalTwin(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteDigitalTwinAsync(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteEventRoute(string eventRouteId, Azure.DigitalTwins.Core.Models.EventRoutesDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.Models.EventRoutesDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteModel(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteModelAsync(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsDeleteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteRelationship(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DigitalTwinsDeleteRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteRelationshipAsync(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DigitalTwinsDeleteRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> GetComponent(string digitalTwinId, string componentPath, Azure.DigitalTwins.Core.DigitalTwinsGetComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> GetComponentAsync(string digitalTwinId, string componentPath, Azure.DigitalTwins.Core.DigitalTwinsGetComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> GetDigitalTwin(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> GetDigitalTwinAsync(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.DigitalTwins.Core.EventRoute> GetEventRoute(string eventRouteId, Azure.DigitalTwins.Core.EventRoutesGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.EventRoute>> GetEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.EventRoutesGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.EventRoute> GetEventRoutes(Azure.DigitalTwins.Core.EventRoutesListOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.EventRoute> GetEventRoutesAsync(Azure.DigitalTwins.Core.EventRoutesListOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.IncomingRelationship> GetIncomingRelationships(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsListIncomingRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.IncomingRelationship> GetIncomingRelationshipsAsync(string digitalTwinId, Azure.DigitalTwins.Core.DigitalTwinsListIncomingRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModel(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData>> GetModelAsync(string modelId, Azure.DigitalTwins.Core.DigitalTwinModelsGetByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModels(Azure.DigitalTwins.Core.GetModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModelsAsync(Azure.DigitalTwins.Core.GetModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> GetRelationship(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DigitalTwinsGetRelationshipByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> GetRelationshipAsync(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DigitalTwinsGetRelationshipByIdOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetRelationships(string digitalTwinId, string relationshipName = null, Azure.DigitalTwins.Core.DigitalTwinsListRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetRelationshipsAsync(string digitalTwinId, string relationshipName = null, Azure.DigitalTwins.Core.DigitalTwinsListRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PublishComponentTelemetry(string digitalTwinId, string componentName, string messageId, string payload, Azure.DigitalTwins.Core.DigitalTwinsSendComponentTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishComponentTelemetryAsync(string digitalTwinId, string componentName, string messageId, string payload, Azure.DigitalTwins.Core.DigitalTwinsSendComponentTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PublishTelemetry(string digitalTwinId, string messageId, string payload, Azure.DigitalTwins.Core.DigitalTwinsSendTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishTelemetryAsync(string digitalTwinId, string messageId, string payload, Azure.DigitalTwins.Core.DigitalTwinsSendTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> Query(string query, Azure.DigitalTwins.Core.QueryTwinsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> QueryAsync(string query, Azure.DigitalTwins.Core.QueryTwinsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateComponent(string digitalTwinId, string componentPath, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateComponentAsync(string digitalTwinId, string componentPath, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateDigitalTwin(string digitalTwinId, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateDigitalTwinAsync(string digitalTwinId, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateRelationship(string digitalTwinId, string relationshipId, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateRelationshipAsync(string digitalTwinId, string relationshipId, string jsonPatch, Azure.DigitalTwins.Core.DigitalTwinsUpdateRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DigitalTwinsClientOptions : Azure.Core.ClientOptions
    {
        public DigitalTwinsClientOptions(Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion version = Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion.V2020_10_31) { }
        public Azure.Core.Serialization.ObjectSerializer Serializer { get { throw null; } set { } }
        public Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion Version { get { throw null; } }
        public enum ServiceVersion
        {
            V2020_10_31 = 1,
        }
    }
    public partial class DigitalTwinsDeleteOptions
    {
        public DigitalTwinsDeleteOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsDeleteRelationshipOptions
    {
        public DigitalTwinsDeleteRelationshipOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsGetByIdOptions
    {
        public DigitalTwinsGetByIdOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsGetComponentOptions
    {
        public DigitalTwinsGetComponentOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsGetRelationshipByIdOptions
    {
        public DigitalTwinsGetRelationshipByIdOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsListIncomingRelationshipsOptions
    {
        public DigitalTwinsListIncomingRelationshipsOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsListRelationshipsOptions
    {
        public DigitalTwinsListRelationshipsOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsModelData
    {
        internal DigitalTwinsModelData() { }
        public bool? Decommissioned { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Model { get { throw null; } }
        public System.DateTimeOffset? UploadTime { get { throw null; } }
    }
    public partial class DigitalTwinsSendComponentTelemetryOptions
    {
        public DigitalTwinsSendComponentTelemetryOptions() { }
        public System.DateTimeOffset TimeStamp { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsSendTelemetryOptions
    {
        public DigitalTwinsSendTelemetryOptions() { }
        public System.DateTimeOffset TimeStamp { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsUpdateComponentOptions
    {
        public DigitalTwinsUpdateComponentOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsUpdateOptions
    {
        public DigitalTwinsUpdateOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class DigitalTwinsUpdateRelationshipOptions
    {
        public DigitalTwinsUpdateRelationshipOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class EventRoute
    {
        public EventRoute(string endpointName, string filter) { }
        public string EndpointName { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string Id { get { throw null; } }
    }
    public partial class EventRouteAddOptions
    {
        public EventRouteAddOptions() { }
    }
    public partial class EventRouteDeleteOptions
    {
        public EventRouteDeleteOptions() { }
    }
    public partial class EventRoutesGetByIdOptions
    {
        public EventRoutesGetByIdOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class EventRoutesListOptions
    {
        public EventRoutesListOptions() { }
        public int? MaxItemsPerPage { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class GetModelsOptions
    {
        public GetModelsOptions() { }
        public System.Collections.Generic.IEnumerable<string> DependenciesFor { get { throw null; } set { } }
        public bool IncludeModelDefinition { get { throw null; } set { } }
        public int? MaxItemsPerPage { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class IncomingRelationship
    {
        internal IncomingRelationship() { }
        public string RelationshipId { get { throw null; } }
        public string RelationshipLink { get { throw null; } }
        public string RelationshipName { get { throw null; } }
        public string SourceId { get { throw null; } }
    }
    public static partial class QueryChargeHelper
    {
        public static bool TryGetQueryCharge(Azure.Page<string> page, out float queryCharge) { throw null; }
    }
    public partial class QueryTwinsOptions
    {
        public QueryTwinsOptions() { }
        public int? MaxItemsPerPage { get { throw null; } set { } }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
}
namespace Azure.DigitalTwins.Core.Models
{
    public partial class EventRoutesAddOptions
    {
        public EventRoutesAddOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
    public partial class EventRoutesDeleteOptions
    {
        public EventRoutesDeleteOptions() { }
        public string Traceparent { get { throw null; } set { } }
        public string Tracestate { get { throw null; } set { } }
    }
}
namespace Azure.DigitalTwins.Core.Serialization
{
    public partial class BasicDigitalTwin
    {
        public BasicDigitalTwin() { }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> CustomProperties { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$etag")]
        public string ETag { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$dtId")]
        public string Id { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$metadata")]
        public Azure.DigitalTwins.Core.Serialization.DigitalTwinMetadata Metadata { get { throw null; } set { } }
    }
    public partial class BasicRelationship
    {
        public BasicRelationship() { }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> CustomProperties { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$relationshipId")]
        public string Id { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$relationshipName")]
        public string Name { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$sourceId")]
        public string SourceId { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$targetId")]
        public string TargetId { get { throw null; } set { } }
    }
    public partial class ComponentMetadata
    {
        public ComponentMetadata() { }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> WritableProperties { get { throw null; } }
    }
    public partial class DigitalTwinMetadata
    {
        public DigitalTwinMetadata() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$model")]
        public string ModelId { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> WritableProperties { get { throw null; } }
    }
    public partial class ModelProperties
    {
        public ModelProperties() { }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> CustomProperties { get { throw null; } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$metadata")]
        public Azure.DigitalTwins.Core.Serialization.ComponentMetadata Metadata { get { throw null; } }
    }
    public partial class UpdateOperationsUtility
    {
        public UpdateOperationsUtility() { }
        public void AppendAddOp(string path, object value) { }
        public void AppendRemoveOp(string path) { }
        public void AppendReplaceOp(string path, object value) { }
        public string Serialize() { throw null; }
    }
    public partial class WritableProperty
    {
        public WritableProperty() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ackCode")]
        public int AckCode { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ackDescription")]
        public string AckDescription { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ackVersion")]
        public int AckVersion { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("desiredValue")]
        public object DesiredValue { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("desiredVersion")]
        public int DesiredVersion { get { throw null; } set { } }
    }
}
