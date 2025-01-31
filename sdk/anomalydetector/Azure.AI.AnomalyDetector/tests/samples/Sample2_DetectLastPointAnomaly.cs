// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Azure.AI.AnomalyDetector;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.AnomalyDetector.Tests.Samples
{
    public partial class AnomalyDetectorSamples : SamplesBase<AnomalyDetectorTestEnvironment>
    {
        [Test]
        public void DetectLastPointAnomaly()
        {
            //read endpoint and apiKey
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            var endpointUri = new Uri(endpoint);
            var credential = new AzureKeyCredential(apiKey);
            string apiVersion = "v1.1";

            //create client
            AnomalyDetectorClient client = new AnomalyDetectorClient(endpointUri, apiVersion, credential);

            //read data
            string datapath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "samples", "data", "request-data.csv");

            List<TimeSeriesPoint> list = File.ReadAllLines(datapath, Encoding.UTF8)
                .Where(e => e.Trim().Length != 0)
                .Select(e => e.Split(','))
                .Where(e => e.Length == 2)
                .Select(e => new TimeSeriesPoint(float.Parse(e[1])){ Timestamp = DateTime.Parse(e[0])}).ToList();

            //create request
            DetectRequest request = new DetectRequest(list)
            {
                Granularity = TimeGranularity.Daily
            };

            #region Snippet:DetectLastPointAnomaly

            //detect
            Console.WriteLine("Detecting the anomaly status of the latest point in the series.");

            try
            {
                LastDetectResponse result = client.DetectUnivariateLastPoint(request);

                if (result.IsAnomaly)
                {
                    Console.WriteLine("The latest point was detected as an anomaly.");
                }
                else
                {
                    Console.WriteLine("The latest point was not detected as an anomaly.");
                }
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(String.Format("Last detection failed: {0}", ex.Message));
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Detection error. {0}", ex.Message));
                throw;
            }
            #endregion
        }
    }
}
