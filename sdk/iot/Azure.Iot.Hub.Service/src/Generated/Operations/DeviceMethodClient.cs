// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    /// <summary> The DeviceMethod service client. </summary>
    public partial class DeviceMethodClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeviceMethodRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DeviceMethodClient for mocking. </summary>
        protected DeviceMethodClient()
        {
        }
        /// <summary> Initializes a new instance of DeviceMethodClient. </summary>
        internal DeviceMethodClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://fully-qualified-iothubname.azure-devices.net", string apiVersion = "2020-03-13")
        {
            RestClient = new DeviceMethodRestClient(clientDiagnostics, pipeline, host, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Invoke a direct method on a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The String to use. </param>
        /// <param name="directMethodRequest"> The CloudToDeviceMethod to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CloudToDeviceMethodResult>> InvokeDeviceMethodAsync(string deviceId, CloudToDeviceMethod directMethodRequest, CancellationToken cancellationToken = default)
        {
            return await RestClient.InvokeDeviceMethodAsync(deviceId, directMethodRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Invoke a direct method on a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The String to use. </param>
        /// <param name="directMethodRequest"> The CloudToDeviceMethod to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudToDeviceMethodResult> InvokeDeviceMethod(string deviceId, CloudToDeviceMethod directMethodRequest, CancellationToken cancellationToken = default)
        {
            return RestClient.InvokeDeviceMethod(deviceId, directMethodRequest, cancellationToken);
        }

        /// <summary> Invoke a direct method on a module of a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The String to use. </param>
        /// <param name="moduleId"> The String to use. </param>
        /// <param name="directMethodRequest"> The CloudToDeviceMethod to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CloudToDeviceMethodResult>> InvokeModuleMethodAsync(string deviceId, string moduleId, CloudToDeviceMethod directMethodRequest, CancellationToken cancellationToken = default)
        {
            return await RestClient.InvokeModuleMethodAsync(deviceId, moduleId, directMethodRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Invoke a direct method on a module of a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The String to use. </param>
        /// <param name="moduleId"> The String to use. </param>
        /// <param name="directMethodRequest"> The CloudToDeviceMethod to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudToDeviceMethodResult> InvokeModuleMethod(string deviceId, string moduleId, CloudToDeviceMethod directMethodRequest, CancellationToken cancellationToken = default)
        {
            return RestClient.InvokeModuleMethod(deviceId, moduleId, directMethodRequest, cancellationToken);
        }
    }
}
