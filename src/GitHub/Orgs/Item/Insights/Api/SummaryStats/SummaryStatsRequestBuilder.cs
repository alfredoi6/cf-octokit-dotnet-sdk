// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Orgs.Item.Insights.Api.SummaryStats.Item;
using GitHub.Orgs.Item.Insights.Api.SummaryStats.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Insights.Api.SummaryStats
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\insights\api\summary-stats
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class SummaryStatsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The users property</summary>
        public global::GitHub.Orgs.Item.Insights.Api.SummaryStats.Users.UsersRequestBuilder Users
        {
            get => new global::GitHub.Orgs.Item.Insights.Api.SummaryStats.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.insights.api.summaryStats.item collection</summary>
        /// <param name="position">The type of the actor</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Insights.Api.SummaryStats.Item.WithActor_typeItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Insights.Api.SummaryStats.Item.WithActor_typeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("actor_type", position);
                return new global::GitHub.Orgs.Item.Insights.Api.SummaryStats.Item.WithActor_typeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SummaryStatsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/summary-stats?max_timestamp={max_timestamp}&min_timestamp={min_timestamp}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SummaryStatsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/summary-stats?max_timestamp={max_timestamp}&min_timestamp={min_timestamp}", rawUrl)
        {
        }
        /// <summary>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/api-insights#get-summary-stats" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ApiInsightsSummaryStats"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ApiInsightsSummaryStats?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder.SummaryStatsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ApiInsightsSummaryStats> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder.SummaryStatsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.ApiInsightsSummaryStats>(requestInfo, global::GitHub.Models.ApiInsightsSummaryStats.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder.SummaryStatsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder.SummaryStatsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Insights.Api.SummaryStats.SummaryStatsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SummaryStatsRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum timestamp to query for stats</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("max_timestamp")]
            public string? MaxTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("max_timestamp")]
            public string MaxTimestamp { get; set; }
#endif
            /// <summary>The minimum timestamp to query for stats</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("min_timestamp")]
            public string? MinTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("min_timestamp")]
            public string MinTimestamp { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
