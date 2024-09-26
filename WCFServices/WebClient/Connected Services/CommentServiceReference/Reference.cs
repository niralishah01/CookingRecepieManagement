﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.CommentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comments", Namespace="http://schemas.datacontract.org/2004/07/WCFServices")]
    [System.SerializableAttribute()]
    public partial class Comments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatetimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RecipeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public string CommentText {
            get {
                return this.CommentTextField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentTextField, value) != true)) {
                    this.CommentTextField = value;
                    this.RaisePropertyChanged("CommentText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Datetime {
            get {
                return this.DatetimeField;
            }
            set {
                if ((this.DatetimeField.Equals(value) != true)) {
                    this.DatetimeField = value;
                    this.RaisePropertyChanged("Datetime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RecipeId {
            get {
                return this.RecipeIdField;
            }
            set {
                if ((this.RecipeIdField.Equals(value) != true)) {
                    this.RecipeIdField = value;
                    this.RaisePropertyChanged("RecipeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CommentServiceReference.ICommentService")]
    public interface ICommentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/AddComment", ReplyAction="http://tempuri.org/ICommentService/AddCommentResponse")]
        string AddComment(WebClient.CommentServiceReference.Comments comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/AddComment", ReplyAction="http://tempuri.org/ICommentService/AddCommentResponse")]
        System.Threading.Tasks.Task<string> AddCommentAsync(WebClient.CommentServiceReference.Comments comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/ViewComments", ReplyAction="http://tempuri.org/ICommentService/ViewCommentsResponse")]
        WebClient.CommentServiceReference.Comments[] ViewComments(int recipeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/ViewComments", ReplyAction="http://tempuri.org/ICommentService/ViewCommentsResponse")]
        System.Threading.Tasks.Task<WebClient.CommentServiceReference.Comments[]> ViewCommentsAsync(int recipeId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommentServiceChannel : WebClient.CommentServiceReference.ICommentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommentServiceClient : System.ServiceModel.ClientBase<WebClient.CommentServiceReference.ICommentService>, WebClient.CommentServiceReference.ICommentService {
        
        public CommentServiceClient() {
        }
        
        public CommentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddComment(WebClient.CommentServiceReference.Comments comment) {
            return base.Channel.AddComment(comment);
        }
        
        public System.Threading.Tasks.Task<string> AddCommentAsync(WebClient.CommentServiceReference.Comments comment) {
            return base.Channel.AddCommentAsync(comment);
        }
        
        public WebClient.CommentServiceReference.Comments[] ViewComments(int recipeId) {
            return base.Channel.ViewComments(recipeId);
        }
        
        public System.Threading.Tasks.Task<WebClient.CommentServiceReference.Comments[]> ViewCommentsAsync(int recipeId) {
            return base.Channel.ViewCommentsAsync(recipeId);
        }
    }
}