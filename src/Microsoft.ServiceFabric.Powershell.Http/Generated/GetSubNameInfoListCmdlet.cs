// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Powershell.Http
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.ServiceFabric.Common;

    /// <summary>
    /// Enumerates all the Service Fabric names under a given name.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "SFSubNameInfoList")]
    public partial class GetSubNameInfoListCmdlet : CommonCmdletBase
    {
        /// <summary>
        /// Gets or sets NameId. The Service Fabric name, without the 'fabric:' URI scheme.
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, Position = 0)]
        public string NameId { get; set; }

        /// <summary>
        /// Gets or sets Recursive. Allows specifying that the search performed should be recursive.
        /// </summary>
        [Parameter(Mandatory = false, Position = 1)]
        public bool? Recursive { get; set; }

        /// <summary>
        /// Gets or sets ServerTimeout. The server timeout for performing the operation in seconds. This timeout specifies the
        /// time duration that the client is willing to wait for the requested operation to complete. The default value for
        /// this parameter is 60 seconds.
        /// </summary>
        [Parameter(Mandatory = false, Position = 2)]
        public long? ServerTimeout { get; set; }

        /// <inheritdoc/>
        protected override void ProcessRecordInternal()
        {
            var continuationToken = default(ContinuationToken);
            do
            {
                var result = this.ServiceFabricClient.Properties.GetSubNameInfoListAsync(
                    nameId: this.NameId,
                    recursive: this.Recursive,
                    continuationToken: continuationToken,
                    serverTimeout: this.ServerTimeout,
                    cancellationToken: this.CancellationToken).GetAwaiter().GetResult();

                if (result == null)
                {
                    break;
                }

                var count = 0;
                foreach (var item in result.Data)
                {
                    count++;
                    this.WriteObject(this.FormatOutput(item));
                }

                continuationToken = result.ContinuationToken;
                this.WriteDebug(string.Format(Resource.MsgCountAndContinuationToken, count, continuationToken));
            }
            while (continuationToken.Next);
        }
    }
}
