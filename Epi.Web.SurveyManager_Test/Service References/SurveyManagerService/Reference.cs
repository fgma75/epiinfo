﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.SurveyManager.Client.SurveyManagerService
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "SurveyManagerService.IManagerService")]
    public interface IManagerService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/PublishSurvey", ReplyAction = "http://tempuri.org/IManagerService/PublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/PublishSurveyCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetSurveyInfo", ReplyAction = "http://tempuri.org/IManagerService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetSurveyInfoCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetOrganization", ReplyAction = "http://tempuri.org/IManagerService/GetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetOrganizationCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetOrganizationInfo", ReplyAction = "http://tempuri.org/IManagerService/GetOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetOrganizationInfoCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetOrganizationNames", ReplyAction = "http://tempuri.org/IManagerService/GetOrganizationNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetOrganizationNamesCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetOrganizationByKey", ReplyAction = "http://tempuri.org/IManagerService/GetOrganizationByKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetOrganizationByKeyCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/SetSurveyInfo", ReplyAction = "http://tempuri.org/IManagerService/SetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/SetSurveyInfoCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/GetSurveyAnswer", ReplyAction = "http://tempuri.org/IManagerService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/GetSurveyAnswerCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/SetOrganization", ReplyAction = "http://tempuri.org/IManagerService/SetOrganizationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/SetOrganizationCustomFaultExceptionFault", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IManagerService/UpdateOrganizationInfo", ReplyAction = "http://tempuri.org/IManagerService/UpdateOrganizationInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action = "http://tempuri.org/IManagerService/UpdateOrganizationInfoCustomFaultExceptionFaul" +
            "t", Name = "CustomFaultException", Namespace = "http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerServiceChannel : Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerServiceClient : System.ServiceModel.ClientBase<Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService>, Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService
    {

        public ManagerServiceClient()
        {
        }

        public ManagerServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ManagerServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage)
        {
            return base.Channel.PublishSurvey(pRequestMessage);
        }

        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest)
        {
            return base.Channel.GetSurveyInfo(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse GetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.GetOrganization(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.GetOrganizationInfo(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationNames(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.GetOrganizationNames(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse GetOrganizationByKey(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.GetOrganizationByKey(pRequest);
        }

        public Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest)
        {
            return base.Channel.SetSurveyInfo(pRequest);
        }

        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest)
        {
            return base.Channel.GetSurveyAnswer(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse SetOrganization(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.SetOrganization(pRequest);
        }

        public Epi.Web.Common.Message.OrganizationResponse UpdateOrganizationInfo(Epi.Web.Common.Message.OrganizationRequest pRequest)
        {
            return base.Channel.UpdateOrganizationInfo(pRequest);
        }
    }
}
