namespace Azure.AI.AnomalyDetector
{
    public enum AlignMode
    {
        Inner = 0,
        Outer = 1,
    }
    public partial class AlignPolicy
    {
        public AlignPolicy() { }
        public Azure.AI.AnomalyDetector.AlignMode? AlignMode { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.FillNAMethod? FillNAMethod { get { throw null; } set { } }
        public float? PaddingValue { get { throw null; } set { } }
    }
    public partial class AnomalyDetectorClient
    {
        protected AnomalyDetectorClient() { }
        public AnomalyDetectorClient(System.Uri endpoint, string apiVersion, Azure.AzureKeyCredential credential) { }
        public AnomalyDetectorClient(System.Uri endpoint, string apiVersion, Azure.AzureKeyCredential credential, Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.Model> CreateAndTrainMultivariateModel(Azure.AI.AnomalyDetector.ModelInfo body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateAndTrainMultivariateModel(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.Model>> CreateAndTrainMultivariateModelAsync(Azure.AI.AnomalyDetector.ModelInfo body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateAndTrainMultivariateModelAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteMultivariateModel(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteMultivariateModelAsync(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.DetectionResult> DetectMultivariateBatchAnomaly(string modelId, Azure.AI.AnomalyDetector.DetectionRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectMultivariateBatchAnomaly(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.DetectionResult>> DetectMultivariateBatchAnomalyAsync(string modelId, Azure.AI.AnomalyDetector.DetectionRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectMultivariateBatchAnomalyAsync(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.LastDetectionResult> DetectMultivariateLastAnomaly(string modelId, Azure.AI.AnomalyDetector.LastDetectionRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectMultivariateLastAnomaly(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.LastDetectionResult>> DetectMultivariateLastAnomalyAsync(string modelId, Azure.AI.AnomalyDetector.LastDetectionRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectMultivariateLastAnomalyAsync(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.ChangePointDetectResponse> DetectUnivariateChangePoint(Azure.AI.AnomalyDetector.ChangePointDetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectUnivariateChangePoint(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.ChangePointDetectResponse>> DetectUnivariateChangePointAsync(Azure.AI.AnomalyDetector.ChangePointDetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateChangePointAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.EntireDetectResponse> DetectUnivariateEntireSeries(Azure.AI.AnomalyDetector.DetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectUnivariateEntireSeries(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.EntireDetectResponse>> DetectUnivariateEntireSeriesAsync(Azure.AI.AnomalyDetector.DetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateEntireSeriesAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.LastDetectResponse> DetectUnivariateLastPoint(Azure.AI.AnomalyDetector.DetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectUnivariateLastPoint(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.LastDetectResponse>> DetectUnivariateLastPointAsync(Azure.AI.AnomalyDetector.DetectRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateLastPointAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetMultivariateBatchDetectionResult(string resultId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetMultivariateBatchDetectionResultAsync(string resultId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.DetectionResult> GetMultivariateBatchDetectionResultValue(string resultId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.DetectionResult>> GetMultivariateBatchDetectionResultValueAsync(string resultId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetMultivariateModel(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetMultivariateModelAsync(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetMultivariateModels(int? skip = default(int?), int? maxCount = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetMultivariateModelsAsync(int? skip = default(int?), int? maxCount = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.Model> GetMultivariateModelValue(string modelId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.Model>> GetMultivariateModelValueAsync(string modelId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.AnomalyDetector.Model> GetMultivariateModelValues(int? skip = default(int?), int? maxCount = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.AnomalyDetector.Model> GetMultivariateModelValuesAsync(int? skip = default(int?), int? maxCount = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AnomalyDetectorClientOptions : Azure.Core.ClientOptions
    {
        public AnomalyDetectorClientOptions(Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions.ServiceVersion version = Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions.ServiceVersion.V1_1) { }
        public enum ServiceVersion
        {
            V1_1 = 1,
        }
    }
    public partial class AnomalyInterpretation
    {
        internal AnomalyInterpretation() { }
        public float? ContributionScore { get { throw null; } }
        public Azure.AI.AnomalyDetector.CorrelationChanges CorrelationChanges { get { throw null; } }
        public string Variable { get { throw null; } }
    }
    public partial class AnomalyState
    {
        internal AnomalyState() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public System.DateTimeOffset Timestamp { get { throw null; } }
        public Azure.AI.AnomalyDetector.AnomalyValue Value { get { throw null; } }
    }
    public partial class AnomalyValue
    {
        internal AnomalyValue() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyInterpretation> Interpretation { get { throw null; } }
        public bool IsAnomaly { get { throw null; } }
        public float Score { get { throw null; } }
        public float Severity { get { throw null; } }
    }
    public partial class ChangePointDetectRequest
    {
        public ChangePointDetectRequest(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.TimeSeriesPoint> series, Azure.AI.AnomalyDetector.TimeGranularity granularity) { }
        public int? CustomInterval { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.TimeGranularity Granularity { get { throw null; } }
        public int? Period { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.TimeSeriesPoint> Series { get { throw null; } }
        public int? StableTrendWindow { get { throw null; } set { } }
        public float? Threshold { get { throw null; } set { } }
    }
    public partial class ChangePointDetectResponse
    {
        internal ChangePointDetectResponse() { }
        public System.Collections.Generic.IReadOnlyList<float> ConfidenceScores { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsChangePoint { get { throw null; } }
        public int? Period { get { throw null; } }
    }
    public partial class CorrelationChanges
    {
        internal CorrelationChanges() { }
        public System.Collections.Generic.IReadOnlyList<string> ChangedVariables { get { throw null; } }
    }
    public enum DataSchema
    {
        OneTable = 0,
        MultiTable = 1,
    }
    public partial class DetectionRequest
    {
        public DetectionRequest(string dataSource, int topContributorCount, System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public string DataSource { get { throw null; } set { } }
        public System.DateTimeOffset EndTime { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
        public int TopContributorCount { get { throw null; } set { } }
    }
    public partial class DetectionResult
    {
        internal DetectionResult() { }
        public string ResultId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyState> Results { get { throw null; } }
        public Azure.AI.AnomalyDetector.DetectionResultSummary Summary { get { throw null; } }
    }
    public partial class DetectionResultSummary
    {
        internal DetectionResultSummary() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public Azure.AI.AnomalyDetector.DetectionRequest SetupInfo { get { throw null; } }
        public Azure.AI.AnomalyDetector.DetectionStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.VariableState> VariableStates { get { throw null; } }
    }
    public enum DetectionStatus
    {
        Created = 0,
        Running = 1,
        Ready = 2,
        Failed = 3,
    }
    public partial class DetectRequest
    {
        public DetectRequest(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.TimeSeriesPoint> series) { }
        public int? CustomInterval { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.TimeGranularity? Granularity { get { throw null; } set { } }
        public float? ImputeFixedValue { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.ImputeMode? ImputeMode { get { throw null; } set { } }
        public float? MaxAnomalyRatio { get { throw null; } set { } }
        public int? Period { get { throw null; } set { } }
        public int? Sensitivity { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.TimeSeriesPoint> Series { get { throw null; } }
    }
    public partial class DiagnosticsInfo
    {
        public DiagnosticsInfo() { }
        public Azure.AI.AnomalyDetector.ModelState ModelState { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.VariableState> VariableStates { get { throw null; } }
    }
    public partial class EntireDetectResponse
    {
        internal EntireDetectResponse() { }
        public System.Collections.Generic.IReadOnlyList<float> ExpectedValues { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsAnomaly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsNegativeAnomaly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsPositiveAnomaly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<float> LowerMargins { get { throw null; } }
        public int Period { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<float> Severity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<float> UpperMargins { get { throw null; } }
    }
    public partial class ErrorResponse
    {
        public ErrorResponse(string code, string message) { }
        public string Code { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FillNAMethod : System.IEquatable<Azure.AI.AnomalyDetector.FillNAMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FillNAMethod(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.FillNAMethod Fixed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.FillNAMethod Linear { get { throw null; } }
        public static Azure.AI.AnomalyDetector.FillNAMethod Previous { get { throw null; } }
        public static Azure.AI.AnomalyDetector.FillNAMethod Subsequent { get { throw null; } }
        public static Azure.AI.AnomalyDetector.FillNAMethod Zero { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.FillNAMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.FillNAMethod left, Azure.AI.AnomalyDetector.FillNAMethod right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.FillNAMethod (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.FillNAMethod left, Azure.AI.AnomalyDetector.FillNAMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ImputeMode : System.IEquatable<Azure.AI.AnomalyDetector.ImputeMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ImputeMode(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.ImputeMode Auto { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Fixed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Linear { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode NotFill { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Previous { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Zero { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.ImputeMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.ImputeMode left, Azure.AI.AnomalyDetector.ImputeMode right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.ImputeMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.ImputeMode left, Azure.AI.AnomalyDetector.ImputeMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LastDetectionRequest
    {
        public LastDetectionRequest(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.VariableValues> variables, int topContributorCount) { }
        public int TopContributorCount { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.VariableValues> Variables { get { throw null; } }
    }
    public partial class LastDetectionResult
    {
        internal LastDetectionResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyState> Results { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.VariableState> VariableStates { get { throw null; } }
    }
    public partial class LastDetectResponse
    {
        internal LastDetectResponse() { }
        public float ExpectedValue { get { throw null; } }
        public bool IsAnomaly { get { throw null; } }
        public bool IsNegativeAnomaly { get { throw null; } }
        public bool IsPositiveAnomaly { get { throw null; } }
        public float LowerMargin { get { throw null; } }
        public int Period { get { throw null; } }
        public float? Severity { get { throw null; } }
        public int SuggestedWindow { get { throw null; } }
        public float UpperMargin { get { throw null; } }
    }
    public partial class Model
    {
        internal Model() { }
        public System.DateTimeOffset CreatedTime { get { throw null; } }
        public System.DateTimeOffset LastUpdatedTime { get { throw null; } }
        public string ModelId { get { throw null; } }
        public Azure.AI.AnomalyDetector.ModelInfo ModelInfo { get { throw null; } }
    }
    public partial class ModelInfo
    {
        public ModelInfo(string dataSource, System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public Azure.AI.AnomalyDetector.AlignPolicy AlignPolicy { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.DataSchema? DataSchema { get { throw null; } set { } }
        public string DataSource { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.DiagnosticsInfo DiagnosticsInfo { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset EndTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public int? SlidingWindow { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.ModelStatus? Status { get { throw null; } set { } }
    }
    public partial class ModelState
    {
        public ModelState() { }
        public System.Collections.Generic.IList<int> EpochIds { get { throw null; } }
        public System.Collections.Generic.IList<float> LatenciesInSeconds { get { throw null; } }
        public System.Collections.Generic.IList<float> TrainLosses { get { throw null; } }
        public System.Collections.Generic.IList<float> ValidationLosses { get { throw null; } }
    }
    public enum ModelStatus
    {
        Created = 0,
        Running = 1,
        Ready = 2,
        Failed = 3,
    }
    public enum TimeGranularity
    {
        Yearly = 0,
        Monthly = 1,
        Weekly = 2,
        Daily = 3,
        Hourly = 4,
        PerMinute = 5,
        PerSecond = 6,
        Microsecond = 7,
        None = 8,
    }
    public partial class TimeSeriesPoint
    {
        public TimeSeriesPoint(float value) { }
        public System.DateTimeOffset? Timestamp { get { throw null; } set { } }
        public float Value { get { throw null; } }
    }
    public partial class VariableState
    {
        public VariableState() { }
        public int? EffectiveCount { get { throw null; } set { } }
        public float? FilledNARatio { get { throw null; } set { } }
        public System.DateTimeOffset? FirstTimestamp { get { throw null; } set { } }
        public System.DateTimeOffset? LastTimestamp { get { throw null; } set { } }
        public string Variable { get { throw null; } set { } }
    }
    public partial class VariableValues
    {
        public VariableValues(string variable, System.Collections.Generic.IEnumerable<string> timestamps, System.Collections.Generic.IEnumerable<float> values) { }
        public System.Collections.Generic.IList<string> Timestamps { get { throw null; } }
        public System.Collections.Generic.IList<float> Values { get { throw null; } }
        public string Variable { get { throw null; } }
    }
}
