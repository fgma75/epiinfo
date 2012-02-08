﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.SurveyManager.Client.SurveyManagerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SurveyManagerService.IManagerService")]
    public interface IManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/PublishSurvey", ReplyAction="http://tempuri.org/IManagerService/PublishSurveyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/PublishSurveyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/SetSurveyInfo", ReplyAction="http://tempuri.org/IManagerService/SetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/SetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IManagerService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IManagerService/GetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerServiceChannel : Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerServiceClient : System.ServiceModel.ClientBase<Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService>, Epi.Web.SurveyManager.Client.SurveyManagerService.IManagerService {
        
        public ManagerServiceClient() {
        }
        
        public ManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Epi.Web.Common.Message.PublishResponse PublishSurvey(Epi.Web.Common.Message.PublishRequest pRequestMessage) {
            return base.Channel.PublishSurvey(pRequestMessage);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse SetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.SetSurveyInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswer(pRequest);
        }
    }
}
