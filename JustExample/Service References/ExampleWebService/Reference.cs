﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustExample.ExampleWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JsonData", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class JsonData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        private bool ResultField;
        
        private int CountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public object Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExampleWebService.AppDataAPISoap")]
    public interface AppDataAPISoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        JustExample.ExampleWebService.HelloWorldResponse HelloWorld(JustExample.ExampleWebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<JustExample.ExampleWebService.HelloWorldResponse> HelloWorldAsync(JustExample.ExampleWebService.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 files 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        JustExample.ExampleWebService.UploadFileResponse UploadFile(JustExample.ExampleWebService.UploadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<JustExample.ExampleWebService.UploadFileResponse> UploadFileAsync(JustExample.ExampleWebService.UploadFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public JustExample.ExampleWebService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(JustExample.ExampleWebService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public JustExample.ExampleWebService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(JustExample.ExampleWebService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFile", Namespace="http://tempuri.org/", Order=0)]
        public JustExample.ExampleWebService.UploadFileRequestBody Body;
        
        public UploadFileRequest() {
        }
        
        public UploadFileRequest(JustExample.ExampleWebService.UploadFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] files;
        
        public UploadFileRequestBody() {
        }
        
        public UploadFileRequestBody(byte[] files) {
            this.files = files;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public JustExample.ExampleWebService.UploadFileResponseBody Body;
        
        public UploadFileResponse() {
        }
        
        public UploadFileResponse(JustExample.ExampleWebService.UploadFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public JustExample.ExampleWebService.JsonData UploadFileResult;
        
        public UploadFileResponseBody() {
        }
        
        public UploadFileResponseBody(JustExample.ExampleWebService.JsonData UploadFileResult) {
            this.UploadFileResult = UploadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AppDataAPISoapChannel : JustExample.ExampleWebService.AppDataAPISoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppDataAPISoapClient : System.ServiceModel.ClientBase<JustExample.ExampleWebService.AppDataAPISoap>, JustExample.ExampleWebService.AppDataAPISoap {
        
        public AppDataAPISoapClient() {
        }
        
        public AppDataAPISoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppDataAPISoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppDataAPISoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppDataAPISoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JustExample.ExampleWebService.HelloWorldResponse JustExample.ExampleWebService.AppDataAPISoap.HelloWorld(JustExample.ExampleWebService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            JustExample.ExampleWebService.HelloWorldRequest inValue = new JustExample.ExampleWebService.HelloWorldRequest();
            inValue.Body = new JustExample.ExampleWebService.HelloWorldRequestBody();
            JustExample.ExampleWebService.HelloWorldResponse retVal = ((JustExample.ExampleWebService.AppDataAPISoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JustExample.ExampleWebService.HelloWorldResponse> JustExample.ExampleWebService.AppDataAPISoap.HelloWorldAsync(JustExample.ExampleWebService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<JustExample.ExampleWebService.HelloWorldResponse> HelloWorldAsync() {
            JustExample.ExampleWebService.HelloWorldRequest inValue = new JustExample.ExampleWebService.HelloWorldRequest();
            inValue.Body = new JustExample.ExampleWebService.HelloWorldRequestBody();
            return ((JustExample.ExampleWebService.AppDataAPISoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JustExample.ExampleWebService.UploadFileResponse JustExample.ExampleWebService.AppDataAPISoap.UploadFile(JustExample.ExampleWebService.UploadFileRequest request) {
            return base.Channel.UploadFile(request);
        }
        
        public JustExample.ExampleWebService.JsonData UploadFile(byte[] files) {
            JustExample.ExampleWebService.UploadFileRequest inValue = new JustExample.ExampleWebService.UploadFileRequest();
            inValue.Body = new JustExample.ExampleWebService.UploadFileRequestBody();
            inValue.Body.files = files;
            JustExample.ExampleWebService.UploadFileResponse retVal = ((JustExample.ExampleWebService.AppDataAPISoap)(this)).UploadFile(inValue);
            return retVal.Body.UploadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JustExample.ExampleWebService.UploadFileResponse> JustExample.ExampleWebService.AppDataAPISoap.UploadFileAsync(JustExample.ExampleWebService.UploadFileRequest request) {
            return base.Channel.UploadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<JustExample.ExampleWebService.UploadFileResponse> UploadFileAsync(byte[] files) {
            JustExample.ExampleWebService.UploadFileRequest inValue = new JustExample.ExampleWebService.UploadFileRequest();
            inValue.Body = new JustExample.ExampleWebService.UploadFileRequestBody();
            inValue.Body.files = files;
            return ((JustExample.ExampleWebService.AppDataAPISoap)(this)).UploadFileAsync(inValue);
        }
    }
}
