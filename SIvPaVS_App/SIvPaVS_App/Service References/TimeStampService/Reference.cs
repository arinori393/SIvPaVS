﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIvPaVS_App.TimeStampService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ditec.sk/", ConfigurationName="TimeStampService.TSSoap")]
    public interface TSSoap {
        
        // CODEGEN: Generating message contract since element name dataB64 from namespace http://www.ditec.sk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ditec.sk/GetTimestamp", ReplyAction="*")]
        SIvPaVS_App.TimeStampService.GetTimestampResponse GetTimestamp(SIvPaVS_App.TimeStampService.GetTimestampRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ditec.sk/GetTimestamp", ReplyAction="*")]
        System.Threading.Tasks.Task<SIvPaVS_App.TimeStampService.GetTimestampResponse> GetTimestampAsync(SIvPaVS_App.TimeStampService.GetTimestampRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTimestampRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTimestamp", Namespace="http://www.ditec.sk/", Order=0)]
        public SIvPaVS_App.TimeStampService.GetTimestampRequestBody Body;
        
        public GetTimestampRequest() {
        }
        
        public GetTimestampRequest(SIvPaVS_App.TimeStampService.GetTimestampRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ditec.sk/")]
    public partial class GetTimestampRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string dataB64;
        
        public GetTimestampRequestBody() {
        }
        
        public GetTimestampRequestBody(string dataB64) {
            this.dataB64 = dataB64;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTimestampResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTimestampResponse", Namespace="http://www.ditec.sk/", Order=0)]
        public SIvPaVS_App.TimeStampService.GetTimestampResponseBody Body;
        
        public GetTimestampResponse() {
        }
        
        public GetTimestampResponse(SIvPaVS_App.TimeStampService.GetTimestampResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ditec.sk/")]
    public partial class GetTimestampResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTimestampResult;
        
        public GetTimestampResponseBody() {
        }
        
        public GetTimestampResponseBody(string GetTimestampResult) {
            this.GetTimestampResult = GetTimestampResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TSSoapChannel : SIvPaVS_App.TimeStampService.TSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TSSoapClient : System.ServiceModel.ClientBase<SIvPaVS_App.TimeStampService.TSSoap>, SIvPaVS_App.TimeStampService.TSSoap {
        
        public TSSoapClient() {
        }
        
        public TSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIvPaVS_App.TimeStampService.GetTimestampResponse SIvPaVS_App.TimeStampService.TSSoap.GetTimestamp(SIvPaVS_App.TimeStampService.GetTimestampRequest request) {
            return base.Channel.GetTimestamp(request);
        }
        
        public string GetTimestamp(string dataB64) {
            SIvPaVS_App.TimeStampService.GetTimestampRequest inValue = new SIvPaVS_App.TimeStampService.GetTimestampRequest();
            inValue.Body = new SIvPaVS_App.TimeStampService.GetTimestampRequestBody();
            inValue.Body.dataB64 = dataB64;
            SIvPaVS_App.TimeStampService.GetTimestampResponse retVal = ((SIvPaVS_App.TimeStampService.TSSoap)(this)).GetTimestamp(inValue);
            return retVal.Body.GetTimestampResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SIvPaVS_App.TimeStampService.GetTimestampResponse> SIvPaVS_App.TimeStampService.TSSoap.GetTimestampAsync(SIvPaVS_App.TimeStampService.GetTimestampRequest request) {
            return base.Channel.GetTimestampAsync(request);
        }
        
        public System.Threading.Tasks.Task<SIvPaVS_App.TimeStampService.GetTimestampResponse> GetTimestampAsync(string dataB64) {
            SIvPaVS_App.TimeStampService.GetTimestampRequest inValue = new SIvPaVS_App.TimeStampService.GetTimestampRequest();
            inValue.Body = new SIvPaVS_App.TimeStampService.GetTimestampRequestBody();
            inValue.Body.dataB64 = dataB64;
            return ((SIvPaVS_App.TimeStampService.TSSoap)(this)).GetTimestampAsync(inValue);
        }
    }
}