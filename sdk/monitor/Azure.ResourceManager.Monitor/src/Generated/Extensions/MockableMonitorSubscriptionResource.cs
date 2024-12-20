// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Monitor.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableMonitorSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _actionGroupClientDiagnostics;
        private ActionGroupsRestOperations _actionGroupRestClient;
        private ClientDiagnostics _scheduledQueryRuleClientDiagnostics;
        private ScheduledQueryRulesRestOperations _scheduledQueryRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMonitorSubscriptionResource"/> class for mocking. </summary>
        protected MockableMonitorSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMonitorSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMonitorSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ActionGroupClientDiagnostics => _actionGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Monitor", ActionGroupResource.ResourceType.Namespace, Diagnostics);
        private ActionGroupsRestOperations ActionGroupRestClient => _actionGroupRestClient ??= new ActionGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ActionGroupResource.ResourceType));
        private ClientDiagnostics ScheduledQueryRuleClientDiagnostics => _scheduledQueryRuleClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Monitor", ScheduledQueryRuleResource.ResourceType.Namespace, Diagnostics);
        private ScheduledQueryRulesRestOperations ScheduledQueryRuleRestClient => _scheduledQueryRuleRestClient ??= new ScheduledQueryRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ScheduledQueryRuleResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get a list of all action groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/actionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ActionGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ActionGroupResource> GetActionGroupsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ActionGroupRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ActionGroupResource(Client, ActionGroupData.DeserializeActionGroupData(e)), ActionGroupClientDiagnostics, Pipeline, "MockableMonitorSubscriptionResource.GetActionGroups", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a list of all action groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/actionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ActionGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ActionGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ActionGroupResource> GetActionGroups(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ActionGroupRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ActionGroupResource(Client, ActionGroupData.DeserializeActionGroupData(e)), ActionGroupClientDiagnostics, Pipeline, "MockableMonitorSubscriptionResource.GetActionGroups", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a scheduled query rule definitions in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/scheduledQueryRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScheduledQueryRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScheduledQueryRuleResource> GetScheduledQueryRulesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ScheduledQueryRuleRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ScheduledQueryRuleRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScheduledQueryRuleResource(Client, ScheduledQueryRuleData.DeserializeScheduledQueryRuleData(e)), ScheduledQueryRuleClientDiagnostics, Pipeline, "MockableMonitorSubscriptionResource.GetScheduledQueryRules", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a scheduled query rule definitions in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/scheduledQueryRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScheduledQueryRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScheduledQueryRuleResource> GetScheduledQueryRules(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ScheduledQueryRuleRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ScheduledQueryRuleRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScheduledQueryRuleResource(Client, ScheduledQueryRuleData.DeserializeScheduledQueryRuleData(e)), ScheduledQueryRuleClientDiagnostics, Pipeline, "MockableMonitorSubscriptionResource.GetScheduledQueryRules", "value", "nextLink", cancellationToken);
        }
    }
}
