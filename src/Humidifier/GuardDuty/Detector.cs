namespace Humidifier.GuardDuty
{
    using System.Collections.Generic;

    public class Detector : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::GuardDuty::Detector";
            }
        }

        /// <summary>
        /// Enable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-enable
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Enable
        {
            get;
            set;
        }
    }
}