//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the execution constraints for a job.
    /// </summary>
    public partial class JobConstraints : ITransportObjectProvider<Models.JobConstraints>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<int?> MaxTaskRetryCountProperty;
            public readonly PropertyAccessor<TimeSpan?> MaxWallClockTimeProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.MaxTaskRetryCountProperty = this.CreatePropertyAccessor<int?>("MaxTaskRetryCount", BindingAccess.Read | BindingAccess.Write);
                this.MaxWallClockTimeProperty = this.CreatePropertyAccessor<TimeSpan?>("MaxWallClockTime", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.JobConstraints protocolObject) : base(BindingState.Bound)
            {
                this.MaxTaskRetryCountProperty = this.CreatePropertyAccessor(
                    protocolObject.MaxTaskRetryCount,
                    "MaxTaskRetryCount",
                    BindingAccess.Read | BindingAccess.Write);
                this.MaxWallClockTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.MaxWallClockTime,
                    "MaxWallClockTime",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobConstraints"/> class.
        /// </summary>
        /// <param name='maxWallClockTime'>The maximum duration of time for which a job is allowed to run from the time it is created.</param>
        /// <param name='maxTaskRetryCount'>The max number of retries for a job.</param>
        public JobConstraints(
            TimeSpan? maxWallClockTime = default(TimeSpan?),
            int? maxTaskRetryCount = default(int?))
        {
            this.propertyContainer = new PropertyContainer();
            this.MaxWallClockTime = maxWallClockTime;
            this.MaxTaskRetryCount = maxTaskRetryCount;
        }

        internal JobConstraints(Models.JobConstraints protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region JobConstraints

        /// <summary>
        /// Gets or sets the max number of retries for a job.
        /// </summary>
        public int? MaxTaskRetryCount
        {
            get { return this.propertyContainer.MaxTaskRetryCountProperty.Value; }
            set { this.propertyContainer.MaxTaskRetryCountProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the maximum duration of time for which a job is allowed to run from the time it is created.
        /// </summary>
        public TimeSpan? MaxWallClockTime
        {
            get { return this.propertyContainer.MaxWallClockTimeProperty.Value; }
            set { this.propertyContainer.MaxWallClockTimeProperty.Value = value; }
        }

        #endregion // JobConstraints

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.JobConstraints ITransportObjectProvider<Models.JobConstraints>.GetTransportObject()
        {
            Models.JobConstraints result = new Models.JobConstraints()
            {
                MaxTaskRetryCount = this.MaxTaskRetryCount,
                MaxWallClockTime = this.MaxWallClockTime,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}