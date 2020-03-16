namespace Humidifier.ApiGatewayV2
{
    using System.Collections.Generic;
    using AuthorizerTypes;

    public class Authorizer : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ApiGatewayV2::Authorizer";
            }
        }

        /// <summary>
        /// IdentityValidationExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identityvalidationexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityValidationExpression
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizerUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizeruri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerUri
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizerCredentialsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizercredentialsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerCredentialsArn
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerType
        {
            get;
            set;
        }

        /// <summary>
        /// JwtConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-jwtconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JWTConfiguration
        /// </summary>
        public JWTConfiguration JwtConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizerResultTtlInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizerresultttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic AuthorizerResultTtlInSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// IdentitySource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identitysource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic IdentitySource
        {
            get;
            set;
        }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApiId
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace AuthorizerTypes
    {
        public class JWTConfiguration
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer
            {
                get;
                set;
            }

            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-audience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Audience
            {
                get;
                set;
            }
        }
    }
}