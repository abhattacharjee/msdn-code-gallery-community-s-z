﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSampleClient.DataServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WCFSampleDataService")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerAddress", Namespace="http://schemas.datacontract.org/2004/07/WCFSampleDataService")]
    [System.SerializableAttribute()]
    public partial class CustomerAddress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerInvoices", Namespace="http://schemas.datacontract.org/2004/07/WCFSampleDataService")]
    [System.SerializableAttribute()]
    public partial class CustomerInvoices : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFSampleClient.DataServiceProxy.CustomerInvoice[] InvoicesField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFSampleClient.DataServiceProxy.CustomerInvoice[] Invoices {
            get {
                return this.InvoicesField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoicesField, value) != true)) {
                    this.InvoicesField = value;
                    this.RaisePropertyChanged("Invoices");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerInvoice", Namespace="http://schemas.datacontract.org/2004/07/WCFSampleDataService")]
    [System.SerializableAttribute()]
    public partial class CustomerInvoice : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime InvoiceDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InvoiceIdField;
        
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
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime InvoiceDate {
            get {
                return this.InvoiceDateField;
            }
            set {
                if ((this.InvoiceDateField.Equals(value) != true)) {
                    this.InvoiceDateField = value;
                    this.RaisePropertyChanged("InvoiceDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InvoiceId {
            get {
                return this.InvoiceIdField;
            }
            set {
                if ((this.InvoiceIdField.Equals(value) != true)) {
                    this.InvoiceIdField = value;
                    this.RaisePropertyChanged("InvoiceId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="uri:wcfsampledataservice:v1", ConfigurationName="DataServiceProxy.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="uri:wcfsampledataservice:v1/IDataService/GetCustomer", ReplyAction="uri:wcfsampledataservice:v1/IDataService/GetCustomerResponse")]
        WCFSampleClient.DataServiceProxy.Customer GetCustomer(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="uri:wcfsampledataservice:v1/IDataService/GetCustomerAddress", ReplyAction="uri:wcfsampledataservice:v1/IDataService/GetCustomerAddressResponse")]
        WCFSampleClient.DataServiceProxy.CustomerAddress GetCustomerAddress(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="uri:wcfsampledataservice:v1/IDataService/GetCustomerInvoices", ReplyAction="uri:wcfsampledataservice:v1/IDataService/GetCustomerInvoicesResponse")]
        WCFSampleClient.DataServiceProxy.CustomerInvoices GetCustomerInvoices(int customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : WCFSampleClient.DataServiceProxy.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<WCFSampleClient.DataServiceProxy.IDataService>, WCFSampleClient.DataServiceProxy.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFSampleClient.DataServiceProxy.Customer GetCustomer(int customerId) {
            return base.Channel.GetCustomer(customerId);
        }
        
        public WCFSampleClient.DataServiceProxy.CustomerAddress GetCustomerAddress(int customerId) {
            return base.Channel.GetCustomerAddress(customerId);
        }
        
        public WCFSampleClient.DataServiceProxy.CustomerInvoices GetCustomerInvoices(int customerId) {
            return base.Channel.GetCustomerInvoices(customerId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="IDataService", Namespace="uri:wcfsampledataservice:v2", ConfigurationName="DataServiceProxy.IDataService1", CallbackContract=typeof(WCFSampleClient.DataServiceProxy.IDataServiceCallback))]
    public interface IDataService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="uri:wcfsampledataservice:v2/IDataService/GetCustomer", ReplyAction="uri:wcfsampledataservice:v2/IDataService/GetCustomerResponse")]
        WCFSampleClient.DataServiceProxy.Customer GetCustomer(int customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="uri:wcfsampledataservice:v2/IDataService/OnCustomerAddressComplete")]
        void OnCustomerAddressComplete(WCFSampleClient.DataServiceProxy.CustomerAddress data);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="uri:wcfsampledataservice:v2/IDataService/OnCustomerInvoicesComplete")]
        void OnCustomerInvoicesComplete(WCFSampleClient.DataServiceProxy.CustomerInvoices data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataService1Channel : WCFSampleClient.DataServiceProxy.IDataService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataService1Client : System.ServiceModel.DuplexClientBase<WCFSampleClient.DataServiceProxy.IDataService1>, WCFSampleClient.DataServiceProxy.IDataService1 {
        
        public DataService1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DataService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DataService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DataService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DataService1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public WCFSampleClient.DataServiceProxy.Customer GetCustomer(int customerId) {
            return base.Channel.GetCustomer(customerId);
        }
    }
}
