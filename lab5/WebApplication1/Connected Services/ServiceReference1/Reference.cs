﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/solution")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="A", Namespace="http://schemas.datacontract.org/2004/07/solution")]
    [System.SerializableAttribute()]
    public partial class A : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float fField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int kField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float f {
            get {
                return this.fField;
            }
            set {
                if ((this.fField.Equals(value) != true)) {
                    this.fField = value;
                    this.RaisePropertyChanged("f");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int k {
            get {
                return this.kField;
            }
            set {
                if ((this.kField.Equals(value) != true)) {
                    this.kField = value;
                    this.RaisePropertyChanged("k");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s {
            get {
                return this.sField;
            }
            set {
                if ((object.ReferenceEquals(this.sField, value) != true)) {
                    this.sField = value;
                    this.RaisePropertyChanged("s");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWCFSiplex")]
    public interface IWCFSiplex {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/GetData", ReplyAction="http://tempuri.org/IWCFSiplex/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/GetData", ReplyAction="http://tempuri.org/IWCFSiplex/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWCFSiplex/GetDataUsingDataContractResponse")]
        WebApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(WebApplication1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWCFSiplex/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Add", ReplyAction="http://tempuri.org/IWCFSiplex/AddResponse")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Add", ReplyAction="http://tempuri.org/IWCFSiplex/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Concat", ReplyAction="http://tempuri.org/IWCFSiplex/ConcatResponse")]
        string Concat(string x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Concat", ReplyAction="http://tempuri.org/IWCFSiplex/ConcatResponse")]
        System.Threading.Tasks.Task<string> ConcatAsync(string x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Sum", ReplyAction="http://tempuri.org/IWCFSiplex/SumResponse")]
        WebApplication1.ServiceReference1.A Sum(WebApplication1.ServiceReference1.A x, WebApplication1.ServiceReference1.A y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSiplex/Sum", ReplyAction="http://tempuri.org/IWCFSiplex/SumResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.A> SumAsync(WebApplication1.ServiceReference1.A x, WebApplication1.ServiceReference1.A y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFSiplexChannel : WebApplication1.ServiceReference1.IWCFSiplex, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFSiplexClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IWCFSiplex>, WebApplication1.ServiceReference1.IWCFSiplex {
        
        public WCFSiplexClient() {
        }
        
        public WCFSiplexClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFSiplexClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSiplexClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSiplexClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WebApplication1.ServiceReference1.CompositeType GetDataUsingDataContract(WebApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public string Concat(string x, double y) {
            return base.Channel.Concat(x, y);
        }
        
        public System.Threading.Tasks.Task<string> ConcatAsync(string x, double y) {
            return base.Channel.ConcatAsync(x, y);
        }
        
        public WebApplication1.ServiceReference1.A Sum(WebApplication1.ServiceReference1.A x, WebApplication1.ServiceReference1.A y) {
            return base.Channel.Sum(x, y);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.A> SumAsync(WebApplication1.ServiceReference1.A x, WebApplication1.ServiceReference1.A y) {
            return base.Channel.SumAsync(x, y);
        }
    }
}
