﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MitchellClaimConsole.MitchellClaimService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimService")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MitchellClaims", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimConsole")]
    [System.SerializableAttribute()]
    public partial class MitchellClaims : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimConsole.MitchellClaimService.MitchellClaim[] MitchellClaimField;
        
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
        public MitchellClaimConsole.MitchellClaimService.MitchellClaim[] MitchellClaim {
            get {
                return this.MitchellClaimField;
            }
            set {
                if ((object.ReferenceEquals(this.MitchellClaimField, value) != true)) {
                    this.MitchellClaimField = value;
                    this.RaisePropertyChanged("MitchellClaim");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MitchellClaim", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimConsole")]
    [System.SerializableAttribute()]
    public partial class MitchellClaim : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AssignedAdjusterIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaimNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaimantFirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaimantLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LossDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimConsole.MitchellClaimService.LossInfo LossInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimConsole.MitchellClaimService.Vehicles VehiclesField;
        
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
        public string AssignedAdjusterID {
            get {
                return this.AssignedAdjusterIDField;
            }
            set {
                if ((object.ReferenceEquals(this.AssignedAdjusterIDField, value) != true)) {
                    this.AssignedAdjusterIDField = value;
                    this.RaisePropertyChanged("AssignedAdjusterID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClaimNumber {
            get {
                return this.ClaimNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaimNumberField, value) != true)) {
                    this.ClaimNumberField = value;
                    this.RaisePropertyChanged("ClaimNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClaimantFirstName {
            get {
                return this.ClaimantFirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaimantFirstNameField, value) != true)) {
                    this.ClaimantFirstNameField = value;
                    this.RaisePropertyChanged("ClaimantFirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClaimantLastName {
            get {
                return this.ClaimantLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaimantLastNameField, value) != true)) {
                    this.ClaimantLastNameField = value;
                    this.RaisePropertyChanged("ClaimantLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LossDate {
            get {
                return this.LossDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LossDateField, value) != true)) {
                    this.LossDateField = value;
                    this.RaisePropertyChanged("LossDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimConsole.MitchellClaimService.LossInfo LossInfo {
            get {
                return this.LossInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.LossInfoField, value) != true)) {
                    this.LossInfoField = value;
                    this.RaisePropertyChanged("LossInfo");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MitchellClaimConsole.MitchellClaimService.Vehicles Vehicles {
            get {
                return this.VehiclesField;
            }
            set {
                if ((object.ReferenceEquals(this.VehiclesField, value) != true)) {
                    this.VehiclesField = value;
                    this.RaisePropertyChanged("Vehicles");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LossInfo", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimConsole")]
    [System.SerializableAttribute()]
    public partial class LossInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CauseOfLossField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LossDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReportedDateField;
        
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
        public string CauseOfLoss {
            get {
                return this.CauseOfLossField;
            }
            set {
                if ((object.ReferenceEquals(this.CauseOfLossField, value) != true)) {
                    this.CauseOfLossField = value;
                    this.RaisePropertyChanged("CauseOfLoss");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LossDescription {
            get {
                return this.LossDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.LossDescriptionField, value) != true)) {
                    this.LossDescriptionField = value;
                    this.RaisePropertyChanged("LossDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReportedDate {
            get {
                return this.ReportedDateField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportedDateField, value) != true)) {
                    this.ReportedDateField = value;
                    this.RaisePropertyChanged("ReportedDate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Vehicles", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimConsole")]
    [System.SerializableAttribute()]
    public partial class Vehicles : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MitchellClaimConsole.MitchellClaimService.VehicleDetails VehicleDetailsField;
        
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
        public MitchellClaimConsole.MitchellClaimService.VehicleDetails VehicleDetails {
            get {
                return this.VehicleDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.VehicleDetailsField, value) != true)) {
                    this.VehicleDetailsField = value;
                    this.RaisePropertyChanged("VehicleDetails");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleDetails", Namespace="http://schemas.datacontract.org/2004/07/MitchellClaimConsole")]
    [System.SerializableAttribute()]
    public partial class VehicleDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DamageDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EngineDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExteriorColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicPlateStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MileageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VinField;
        
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
        public string DamageDescription {
            get {
                return this.DamageDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DamageDescriptionField, value) != true)) {
                    this.DamageDescriptionField = value;
                    this.RaisePropertyChanged("DamageDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EngineDescription {
            get {
                return this.EngineDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.EngineDescriptionField, value) != true)) {
                    this.EngineDescriptionField = value;
                    this.RaisePropertyChanged("EngineDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExteriorColor {
            get {
                return this.ExteriorColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ExteriorColorField, value) != true)) {
                    this.ExteriorColorField = value;
                    this.RaisePropertyChanged("ExteriorColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlate {
            get {
                return this.LicPlateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateField, value) != true)) {
                    this.LicPlateField = value;
                    this.RaisePropertyChanged("LicPlate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlateExpDate {
            get {
                return this.LicPlateExpDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateExpDateField, value) != true)) {
                    this.LicPlateExpDateField = value;
                    this.RaisePropertyChanged("LicPlateExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicPlateState {
            get {
                return this.LicPlateStateField;
            }
            set {
                if ((object.ReferenceEquals(this.LicPlateStateField, value) != true)) {
                    this.LicPlateStateField = value;
                    this.RaisePropertyChanged("LicPlateState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MakeDescription {
            get {
                return this.MakeDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeDescriptionField, value) != true)) {
                    this.MakeDescriptionField = value;
                    this.RaisePropertyChanged("MakeDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mileage {
            get {
                return this.MileageField;
            }
            set {
                if ((object.ReferenceEquals(this.MileageField, value) != true)) {
                    this.MileageField = value;
                    this.RaisePropertyChanged("Mileage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModelDescription {
            get {
                return this.ModelDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelDescriptionField, value) != true)) {
                    this.ModelDescriptionField = value;
                    this.RaisePropertyChanged("ModelDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModelYear {
            get {
                return this.ModelYearField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelYearField, value) != true)) {
                    this.ModelYearField = value;
                    this.RaisePropertyChanged("ModelYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vin {
            get {
                return this.VinField;
            }
            set {
                if ((object.ReferenceEquals(this.VinField, value) != true)) {
                    this.VinField = value;
                    this.RaisePropertyChanged("Vin");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MitchellClaimService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MitchellClaimConsole.MitchellClaimService.CompositeType GetDataUsingDataContract(MitchellClaimConsole.MitchellClaimService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MitchellClaimConsole.MitchellClaimService.CompositeType> GetDataUsingDataContractAsync(MitchellClaimConsole.MitchellClaimService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMitchellClaims", ReplyAction="http://tempuri.org/IService1/CreateMitchellClaimsResponse")]
        void CreateMitchellClaims(string createXMLPath, string BackStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMitchellClaims", ReplyAction="http://tempuri.org/IService1/CreateMitchellClaimsResponse")]
        System.Threading.Tasks.Task CreateMitchellClaimsAsync(string createXMLPath, string BackStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadMitchellClaims", ReplyAction="http://tempuri.org/IService1/ReadMitchellClaimsResponse")]
        MitchellClaimConsole.MitchellClaimService.MitchellClaims ReadMitchellClaims(string backStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadMitchellClaims", ReplyAction="http://tempuri.org/IService1/ReadMitchellClaimsResponse")]
        System.Threading.Tasks.Task<MitchellClaimConsole.MitchellClaimService.MitchellClaims> ReadMitchellClaimsAsync(string backStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateXMLStore", ReplyAction="http://tempuri.org/IService1/UpdateXMLStoreResponse")]
        bool UpdateXMLStore(string updateXMLPath, string backStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateXMLStore", ReplyAction="http://tempuri.org/IService1/UpdateXMLStoreResponse")]
        System.Threading.Tasks.Task<bool> UpdateXMLStoreAsync(string updateXMLPath, string backStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteMitchellClaim", ReplyAction="http://tempuri.org/IService1/DeleteMitchellClaimResponse")]
        bool DeleteMitchellClaim(string claimNumber, string backStoreXMLPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteMitchellClaim", ReplyAction="http://tempuri.org/IService1/DeleteMitchellClaimResponse")]
        System.Threading.Tasks.Task<bool> DeleteMitchellClaimAsync(string claimNumber, string backStoreXMLPath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MitchellClaimConsole.MitchellClaimService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MitchellClaimConsole.MitchellClaimService.IService1>, MitchellClaimConsole.MitchellClaimService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MitchellClaimConsole.MitchellClaimService.CompositeType GetDataUsingDataContract(MitchellClaimConsole.MitchellClaimService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MitchellClaimConsole.MitchellClaimService.CompositeType> GetDataUsingDataContractAsync(MitchellClaimConsole.MitchellClaimService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void CreateMitchellClaims(string createXMLPath, string BackStoreXMLPath) {
            base.Channel.CreateMitchellClaims(createXMLPath, BackStoreXMLPath);
        }
        
        public System.Threading.Tasks.Task CreateMitchellClaimsAsync(string createXMLPath, string BackStoreXMLPath) {
            return base.Channel.CreateMitchellClaimsAsync(createXMLPath, BackStoreXMLPath);
        }
        
        public MitchellClaimConsole.MitchellClaimService.MitchellClaims ReadMitchellClaims(string backStoreXMLPath) {
            return base.Channel.ReadMitchellClaims(backStoreXMLPath);
        }
        
        public System.Threading.Tasks.Task<MitchellClaimConsole.MitchellClaimService.MitchellClaims> ReadMitchellClaimsAsync(string backStoreXMLPath) {
            return base.Channel.ReadMitchellClaimsAsync(backStoreXMLPath);
        }
        
        public bool UpdateXMLStore(string updateXMLPath, string backStoreXMLPath) {
            return base.Channel.UpdateXMLStore(updateXMLPath, backStoreXMLPath);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateXMLStoreAsync(string updateXMLPath, string backStoreXMLPath) {
            return base.Channel.UpdateXMLStoreAsync(updateXMLPath, backStoreXMLPath);
        }
        
        public bool DeleteMitchellClaim(string claimNumber, string backStoreXMLPath) {
            return base.Channel.DeleteMitchellClaim(claimNumber, backStoreXMLPath);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMitchellClaimAsync(string claimNumber, string backStoreXMLPath) {
            return base.Channel.DeleteMitchellClaimAsync(claimNumber, backStoreXMLPath);
        }
    }
}
