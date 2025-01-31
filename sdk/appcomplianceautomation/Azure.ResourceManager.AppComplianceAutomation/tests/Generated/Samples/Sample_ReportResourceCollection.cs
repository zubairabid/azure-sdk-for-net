// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    public partial class Sample_ReportResourceCollection
    {
        // Reports_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ReportsList()
        {
            // Generated from example definition: specification/appcomplianceautomation/resource-manager/Microsoft.AppComplianceAutomation/preview/2022-11-16-preview/examples/Reports_List.json
            // this example is just showing the usage of "Reports_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ReportResource
            ReportResourceCollection collection = tenantResource.GetReportResources();

            // invoke the operation and iterate over the result
            string skipToken = "1";
            int? top = 100;
            string offerGuid = "00000000-0000-0000-0000-000000000000";
            string reportCreatorTenantId = "00000000-0000-0000-0000-000000000000";
            await foreach (ReportResource item in collection.GetAllAsync(skipToken: skipToken, top: top, offerGuid: offerGuid, reportCreatorTenantId: reportCreatorTenantId))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReportResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Report_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ReportGet()
        {
            // Generated from example definition: specification/appcomplianceautomation/resource-manager/Microsoft.AppComplianceAutomation/preview/2022-11-16-preview/examples/Report_Get.json
            // this example is just showing the usage of "Report_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ReportResource
            ReportResourceCollection collection = tenantResource.GetReportResources();

            // invoke the operation
            string reportName = "testReport";
            ReportResource result = await collection.GetAsync(reportName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReportResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Report_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ReportGet()
        {
            // Generated from example definition: specification/appcomplianceautomation/resource-manager/Microsoft.AppComplianceAutomation/preview/2022-11-16-preview/examples/Report_Get.json
            // this example is just showing the usage of "Report_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ReportResource
            ReportResourceCollection collection = tenantResource.GetReportResources();

            // invoke the operation
            string reportName = "testReport";
            bool result = await collection.ExistsAsync(reportName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Report_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ReportCreateOrUpdate()
        {
            // Generated from example definition: specification/appcomplianceautomation/resource-manager/Microsoft.AppComplianceAutomation/preview/2022-11-16-preview/examples/Report_CreateOrUpdate.json
            // this example is just showing the usage of "Report_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ReportResource
            ReportResourceCollection collection = tenantResource.GetReportResources();

            // invoke the operation
            string reportName = "testReportName";
            ReportResourceData data = new ReportResourceData(new ReportProperties("GMT Standard Time", DateTimeOffset.Parse("2022-03-04T05:11:56.197Z"), new ResourceMetadata[]
            {
new ResourceMetadata("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/Microsoft.Network/privateEndpoints/myPrivateEndpoint")
{
Tags =
{
["key1"] = "value1",
},
}
            })
            {
                OfferGuid = "0000",
            });
            ArmOperation<ReportResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, reportName, data);
            ReportResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReportResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
