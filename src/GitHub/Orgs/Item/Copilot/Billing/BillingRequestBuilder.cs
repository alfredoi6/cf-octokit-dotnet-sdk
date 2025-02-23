// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Orgs.Item.Copilot.Billing.Seats;
using GitHub.Orgs.Item.Copilot.Billing.Selected_teams;
using GitHub.Orgs.Item.Copilot.Billing.Selected_users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Copilot.Billing
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class BillingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The seats property</summary>
        public global::GitHub.Orgs.Item.Copilot.Billing.Seats.SeatsRequestBuilder Seats
        {
            get => new global::GitHub.Orgs.Item.Copilot.Billing.Seats.SeatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The selected_teams property</summary>
        public global::GitHub.Orgs.Item.Copilot.Billing.Selected_teams.Selected_teamsRequestBuilder Selected_teams
        {
            get => new global::GitHub.Orgs.Item.Copilot.Billing.Selected_teams.Selected_teamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The selected_users property</summary>
        public global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder Selected_users
        {
            get => new global::GitHub.Orgs.Item.Copilot.Billing.Selected_users.Selected_usersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Copilot.Billing.BillingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Copilot.Billing.BillingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Gets information about an organization&apos;s Copilot subscription, including seat breakdownand feature policies. To configure these settings, go to your organization&apos;s settings on GitHub.com.For more information, see &quot;[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-copilot-business-in-your-organization)&quot;.Only organization owners can view details about the organization&apos;s Copilot Business or Copilot Enterprise subscription.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:org` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-user-management#get-copilot-seat-information-and-settings-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CopilotOrganizationDetails"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.CopilotOrganizationDetails?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.CopilotOrganizationDetails> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.CopilotOrganizationDetails>(requestInfo, global::GitHub.Models.CopilotOrganizationDetails.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; This endpoint is in public preview and is subject to change.Gets information about an organization&apos;s Copilot subscription, including seat breakdownand feature policies. To configure these settings, go to your organization&apos;s settings on GitHub.com.For more information, see &quot;[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-copilot-business-in-your-organization)&quot;.Only organization owners can view details about the organization&apos;s Copilot Business or Copilot Enterprise subscription.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:org` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Copilot.Billing.BillingRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Copilot.Billing.BillingRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Copilot.Billing.BillingRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
