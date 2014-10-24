﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.1.
// 
namespace Energistics.DataAccess.PRODML121.PROD_AssetRegistry {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PROD_AssetRegistrySoap", Namespace="http://www.prodml.org/api/200/assetRegistry")]
    public partial class PROD_AssetRegistry : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetServiceInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetItemIdListOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetReferencesOperationCompleted;
        
        /// <remarks/>
        public PROD_AssetRegistry() {
            this.Url = "http://_Vendor_Address_And_Port_/_Vendor_Service_Name_/";
        }
        
        /// <remarks/>
        public event GetServiceInfoCompletedEventHandler GetServiceInfoCompleted;
        
        /// <remarks/>
        public event GetItemIdListCompletedEventHandler GetItemIdListCompleted;
        
        /// <remarks/>
        public event GetReferencesCompletedEventHandler GetReferencesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prodml.org/api/200/assetRegistry/GetServiceInfo", RequestNamespace="http://www.prodml.org/api/200/assetRegistry", ResponseNamespace="http://www.prodml.org/api/200/assetRegistry", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ServiceInfo GetServiceInfo() {
            object[] results = this.Invoke("GetServiceInfo", new object[0]);
            return ((ServiceInfo)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetServiceInfo(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetServiceInfo", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public ServiceInfo EndGetServiceInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ServiceInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetServiceInfoAsync() {
            this.GetServiceInfoAsync(null);
        }
        
        /// <remarks/>
        public void GetServiceInfoAsync(object userState) {
            if ((this.GetServiceInfoOperationCompleted == null)) {
                this.GetServiceInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceInfoOperationCompleted);
            }
            this.InvokeAsync("GetServiceInfo", new object[0], this.GetServiceInfoOperationCompleted, userState);
        }
        
        private void OnGetServiceInfoOperationCompleted(object arg) {
            if ((this.GetServiceInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceInfoCompleted(this, new GetServiceInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prodml.org/api/200/assetRegistry/GetItemIdList", RequestNamespace="http://www.prodml.org/api/200/assetRegistry", ResponseNamespace="http://www.prodml.org/api/200/assetRegistry", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Uid")]
        public string[] GetItemIdList(string modelName, string xpathQuery) {
            object[] results = this.Invoke("GetItemIdList", new object[] {
                        modelName,
                        xpathQuery});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetItemIdList(string modelName, string xpathQuery, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetItemIdList", new object[] {
                        modelName,
                        xpathQuery}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGetItemIdList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetItemIdListAsync(string modelName, string xpathQuery) {
            this.GetItemIdListAsync(modelName, xpathQuery, null);
        }
        
        /// <remarks/>
        public void GetItemIdListAsync(string modelName, string xpathQuery, object userState) {
            if ((this.GetItemIdListOperationCompleted == null)) {
                this.GetItemIdListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemIdListOperationCompleted);
            }
            this.InvokeAsync("GetItemIdList", new object[] {
                        modelName,
                        xpathQuery}, this.GetItemIdListOperationCompleted, userState);
        }
        
        private void OnGetItemIdListOperationCompleted(object arg) {
            if ((this.GetItemIdListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemIdListCompleted(this, new GetItemIdListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prodml.org/api/200/assetRegistry/GetReferences", RequestNamespace="http://www.prodml.org/api/200/assetRegistry", ResponseNamespace="http://www.prodml.org/api/200/assetRegistry", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("references")]
        public ReferenceInfo[] GetReferences(string assetID, string referenceName, string referenceType, [System.Xml.Serialization.XmlElementAttribute("idList")] string[] idList) {
            object[] results = this.Invoke("GetReferences", new object[] {
                        assetID,
                        referenceName,
                        referenceType,
                        idList});
            return ((ReferenceInfo[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetReferences(string assetID, string referenceName, string referenceType, string[] idList, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetReferences", new object[] {
                        assetID,
                        referenceName,
                        referenceType,
                        idList}, callback, asyncState);
        }
        
        /// <remarks/>
        public ReferenceInfo[] EndGetReferences(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReferenceInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetReferencesAsync(string assetID, string referenceName, string referenceType, string[] idList) {
            this.GetReferencesAsync(assetID, referenceName, referenceType, idList, null);
        }
        
        /// <remarks/>
        public void GetReferencesAsync(string assetID, string referenceName, string referenceType, string[] idList, object userState) {
            if ((this.GetReferencesOperationCompleted == null)) {
                this.GetReferencesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetReferencesOperationCompleted);
            }
            this.InvokeAsync("GetReferences", new object[] {
                        assetID,
                        referenceName,
                        referenceType,
                        idList}, this.GetReferencesOperationCompleted, userState);
        }
        
        private void OnGetReferencesOperationCompleted(object arg) {
            if ((this.GetReferencesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetReferencesCompleted(this, new GetReferencesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/api/200/assetRegistry")]
    public partial class ServiceInfo {
        
        private string contactNameField;
        
        private string contactEmailField;
        
        private string contactPhoneField;
        
        private string descriptionField;
        
        private string nameField;
        
        private string categoryField;
        
        private string vendorField;
        
        private string versionField;
        
        private string apiVersionField;
        
        private string assetModelSchemaVersionField;
        
        /// <remarks/>
        public string ContactName {
            get {
                return this.contactNameField;
            }
            set {
                this.contactNameField = value;
            }
        }
        
        /// <remarks/>
        public string ContactEmail {
            get {
                return this.contactEmailField;
            }
            set {
                this.contactEmailField = value;
            }
        }
        
        /// <remarks/>
        public string ContactPhone {
            get {
                return this.contactPhoneField;
            }
            set {
                this.contactPhoneField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public string Vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string ApiVersion {
            get {
                return this.apiVersionField;
            }
            set {
                this.apiVersionField = value;
            }
        }
        
        /// <remarks/>
        public string AssetModelSchemaVersion {
            get {
                return this.assetModelSchemaVersionField;
            }
            set {
                this.assetModelSchemaVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.prodml.org/api/200/assetRegistry")]
    public partial class ReferenceInfo {
        
        private string parentIdField;
        
        private string nameField;
        
        private string typeField;
        
        private string urlField;
        
        private string referenceIDField;
        
        /// <remarks/>
        public string ParentId {
            get {
                return this.parentIdField;
            }
            set {
                this.parentIdField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceID {
            get {
                return this.referenceIDField;
            }
            set {
                this.referenceIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetServiceInfoCompletedEventHandler(object sender, GetServiceInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServiceInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ServiceInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ServiceInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemIdListCompletedEventHandler(object sender, GetItemIdListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemIdListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetItemIdListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetReferencesCompletedEventHandler(object sender, GetReferencesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetReferencesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetReferencesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReferenceInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReferenceInfo[])(this.results[0]));
            }
        }
    }
}