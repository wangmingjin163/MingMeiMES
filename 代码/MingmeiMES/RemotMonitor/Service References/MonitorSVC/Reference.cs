﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemotMonitor.MonitorSVC {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MonitorSvcNodeStatus", Namespace="http://schemas.datacontract.org/2004/07/LineNodes")]
    [System.SerializableAttribute()]
    public partial class MonitorSvcNodeStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NodeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductBarcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatDescribeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public string NodeName {
            get {
                return this.NodeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NodeNameField, value) != true)) {
                    this.NodeNameField = value;
                    this.RaisePropertyChanged("NodeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductBarcode {
            get {
                return this.ProductBarcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductBarcodeField, value) != true)) {
                    this.ProductBarcodeField = value;
                    this.RaisePropertyChanged("ProductBarcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatDescribe {
            get {
                return this.StatDescribeField;
            }
            set {
                if ((object.ReferenceEquals(this.StatDescribeField, value) != true)) {
                    this.StatDescribeField = value;
                    this.RaisePropertyChanged("StatDescribe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonitorSVC.INodeMonitorSvc")]
    public interface INodeMonitorSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeMonitorSvc/DoWork", ReplyAction="http://tempuri.org/INodeMonitorSvc/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeMonitorSvc/GetNodeStatus", ReplyAction="http://tempuri.org/INodeMonitorSvc/GetNodeStatusResponse")]
        RemotMonitor.MonitorSVC.MonitorSvcNodeStatus[] GetNodeStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeMonitorSvc/GetRunningDetectdevs", ReplyAction="http://tempuri.org/INodeMonitorSvc/GetRunningDetectdevsResponse")]
        int GetRunningDetectdevs();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INodeMonitorSvcChannel : RemotMonitor.MonitorSVC.INodeMonitorSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NodeMonitorSvcClient : System.ServiceModel.ClientBase<RemotMonitor.MonitorSVC.INodeMonitorSvc>, RemotMonitor.MonitorSVC.INodeMonitorSvc {
        
        public NodeMonitorSvcClient() {
        }
        
        public NodeMonitorSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NodeMonitorSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NodeMonitorSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NodeMonitorSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public RemotMonitor.MonitorSVC.MonitorSvcNodeStatus[] GetNodeStatus() {
            return base.Channel.GetNodeStatus();
        }
        
        public int GetRunningDetectdevs() {
            return base.Channel.GetRunningDetectdevs();
        }
    }
}
