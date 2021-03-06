namespace Humidifier.IoTAnalytics
{
    using System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTAnalytics::Dataset";
            }
        }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        public List<Action> Actions
        {
            get;
            set;
        }

        /// <summary>
        /// DatasetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-datasetname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatasetName
        {
            get;
            set;
        }

        /// <summary>
        /// ContentDeliveryRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-contentdeliveryrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetContentDeliveryRule
        /// </summary>
        public List<DatasetContentDeliveryRule> ContentDeliveryRules
        {
            get;
            set;
        }

        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Trigger
        /// </summary>
        public List<Trigger> Triggers
        {
            get;
            set;
        }

        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-versioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public VersioningConfiguration VersioningConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }

    namespace DatasetTypes
    {
        public class DatasetContentVersionValue
        {
            /// <summary>
            /// DatasetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-datasetcontentversionvalue.html#cfn-iotanalytics-dataset-variable-datasetcontentversionvalue-datasetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatasetName
            {
                get;
                set;
            }
        }

        public class GlueConfiguration
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName
            {
                get;
                set;
            }

            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName
            {
                get;
                set;
            }
        }

        public class OutputFileUriValue
        {
            /// <summary>
            /// FileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-outputfileurivalue.html#cfn-iotanalytics-dataset-variable-outputfileurivalue-filename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileName
            {
                get;
                set;
            }
        }

        public class Variable
        {
            /// <summary>
            /// DatasetContentVersionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-datasetcontentversionvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetContentVersionValue
            /// </summary>
            public DatasetContentVersionValue DatasetContentVersionValue
            {
                get;
                set;
            }

            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue
            {
                get;
                set;
            }

            /// <summary>
            /// OutputFileUriValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-outputfileurivalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFileUriValue
            /// </summary>
            public OutputFileUriValue OutputFileUriValue
            {
                get;
                set;
            }

            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariableName
            {
                get;
                set;
            }

            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue
            {
                get;
                set;
            }
        }

        public class Filter
        {
            /// <summary>
            /// DeltaTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-filter.html#cfn-iotanalytics-dataset-filter-deltatime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaTime
            /// </summary>
            public DeltaTime DeltaTime
            {
                get;
                set;
            }
        }

        public class DeltaTime
        {
            /// <summary>
            /// TimeExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-timeexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeExpression
            {
                get;
                set;
            }

            /// <summary>
            /// OffsetSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-offsetseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OffsetSeconds
            {
                get;
                set;
            }
        }

        public class DatasetContentDeliveryRule
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetContentDeliveryRuleDestination
            /// </summary>
            public DatasetContentDeliveryRuleDestination Destination
            {
                get;
                set;
            }

            /// <summary>
            /// EntryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-entryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryName
            {
                get;
                set;
            }
        }

        public class Trigger
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Schedule Schedule
            {
                get;
                set;
            }

            /// <summary>
            /// TriggeringDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-triggeringdataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TriggeringDataset
            /// </summary>
            public TriggeringDataset TriggeringDataset
            {
                get;
                set;
            }
        }

        public class IotEventsDestinationConfiguration
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputName
            {
                get;
                set;
            }

            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn
            {
                get;
                set;
            }
        }

        public class Action
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionName
            {
                get;
                set;
            }

            /// <summary>
            /// ContainerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-containeraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerAction
            /// </summary>
            public ContainerAction ContainerAction
            {
                get;
                set;
            }

            /// <summary>
            /// QueryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-queryaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryAction
            /// </summary>
            public QueryAction QueryAction
            {
                get;
                set;
            }
        }

        public class ContainerAction
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Variable
            /// </summary>
            public List<Variable> Variables
            {
                get;
                set;
            }

            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-executionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn
            {
                get;
                set;
            }

            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image
            {
                get;
                set;
            }

            /// <summary>
            /// ResourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-resourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceConfiguration
            /// </summary>
            public ResourceConfiguration ResourceConfiguration
            {
                get;
                set;
            }
        }

        public class QueryAction
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Filter> Filters
            {
                get;
                set;
            }

            /// <summary>
            /// SqlQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-sqlquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlQuery
            {
                get;
                set;
            }
        }

        public class DatasetContentDeliveryRuleDestination
        {
            /// <summary>
            /// IotEventsDestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-ioteventsdestinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEventsDestinationConfiguration
            /// </summary>
            public IotEventsDestinationConfiguration IotEventsDestinationConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// S3DestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-s3destinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3DestinationConfiguration
            {
                get;
                set;
            }
        }

        public class VersioningConfiguration
        {
            /// <summary>
            /// MaxVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-maxversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxVersions
            {
                get;
                set;
            }

            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited
            {
                get;
                set;
            }
        }

        public class ResourceConfiguration
        {
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-volumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB
            {
                get;
                set;
            }

            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-computetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeType
            {
                get;
                set;
            }
        }

        public class TriggeringDataset
        {
            /// <summary>
            /// DatasetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-triggeringdataset.html#cfn-iotanalytics-dataset-triggeringdataset-datasetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatasetName
            {
                get;
                set;
            }
        }

        public class Schedule
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger-schedule.html#cfn-iotanalytics-dataset-trigger-schedule-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression
            {
                get;
                set;
            }
        }

        public class RetentionPeriod
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-numberofdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfDays
            {
                get;
                set;
            }

            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-unlimited
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited
            {
                get;
                set;
            }
        }

        public class S3DestinationConfiguration
        {
            /// <summary>
            /// GlueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-glueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueConfiguration
            /// </summary>
            public GlueConfiguration GlueConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket
            {
                get;
                set;
            }

            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn
            {
                get;
                set;
            }
        }
    }
}