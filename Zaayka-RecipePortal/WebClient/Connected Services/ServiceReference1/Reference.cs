﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Users", Namespace="http://schemas.datacontract.org/2004/07/WCFServices")]
    [System.SerializableAttribute()]
    public partial class Users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string uniquecodeField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uniquecode {
            get {
                return this.uniquecodeField;
            }
            set {
                if ((object.ReferenceEquals(this.uniquecodeField, value) != true)) {
                    this.uniquecodeField = value;
                    this.RaisePropertyChanged("uniquecode");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        string Register(WebClient.ServiceReference1.Users u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(WebClient.ServiceReference1.Users u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        WebClient.ServiceReference1.Users Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.Users> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateUserDetails", ReplyAction="http://tempuri.org/IAccountService/UpdateUserDetailsResponse")]
        void UpdateUserDetails(WebClient.ServiceReference1.Users u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateUserDetails", ReplyAction="http://tempuri.org/IAccountService/UpdateUserDetailsResponse")]
        System.Threading.Tasks.Task UpdateUserDetailsAsync(WebClient.ServiceReference1.Users u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserDetail", ReplyAction="http://tempuri.org/IAccountService/GetUserDetailResponse")]
        WebClient.ServiceReference1.Users GetUserDetail(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserDetail", ReplyAction="http://tempuri.org/IAccountService/GetUserDetailResponse")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.Users> GetUserDetailAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUsers", ReplyAction="http://tempuri.org/IAccountService/GetUsersResponse")]
        System.Data.DataSet GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUsers", ReplyAction="http://tempuri.org/IAccountService/GetUsersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteUser", ReplyAction="http://tempuri.org/IAccountService/DeleteUserResponse")]
        void DeleteUser(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteUser", ReplyAction="http://tempuri.org/IAccountService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Logout", ReplyAction="http://tempuri.org/IAccountService/LogoutResponse")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Logout", ReplyAction="http://tempuri.org/IAccountService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/SendMail", ReplyAction="http://tempuri.org/IAccountService/SendMailResponse")]
        string SendMail(string emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/SendMail", ReplyAction="http://tempuri.org/IAccountService/SendMailResponse")]
        System.Threading.Tasks.Task<string> SendMailAsync(string emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RedirectToResetPassword", ReplyAction="http://tempuri.org/IAccountService/RedirectToResetPasswordResponse")]
        string RedirectToResetPassword(string ucode, string emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RedirectToResetPassword", ReplyAction="http://tempuri.org/IAccountService/RedirectToResetPasswordResponse")]
        System.Threading.Tasks.Task<string> RedirectToResetPasswordAsync(string ucode, string emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/ResetPassword", ReplyAction="http://tempuri.org/IAccountService/ResetPasswordResponse")]
        string ResetPassword(string ucode, string emailid, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/ResetPassword", ReplyAction="http://tempuri.org/IAccountService/ResetPasswordResponse")]
        System.Threading.Tasks.Task<string> ResetPasswordAsync(string ucode, string emailid, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : WebClient.ServiceReference1.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<WebClient.ServiceReference1.IAccountService>, WebClient.ServiceReference1.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Register(WebClient.ServiceReference1.Users u) {
            return base.Channel.Register(u);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(WebClient.ServiceReference1.Users u) {
            return base.Channel.RegisterAsync(u);
        }
        
        public WebClient.ServiceReference1.Users Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.Users> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public void UpdateUserDetails(WebClient.ServiceReference1.Users u) {
            base.Channel.UpdateUserDetails(u);
        }
        
        public System.Threading.Tasks.Task UpdateUserDetailsAsync(WebClient.ServiceReference1.Users u) {
            return base.Channel.UpdateUserDetailsAsync(u);
        }
        
        public WebClient.ServiceReference1.Users GetUserDetail(int ID) {
            return base.Channel.GetUserDetail(ID);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.Users> GetUserDetailAsync(int ID) {
            return base.Channel.GetUserDetailAsync(ID);
        }
        
        public System.Data.DataSet GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public void DeleteUser(int ID) {
            base.Channel.DeleteUser(ID);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int ID) {
            return base.Channel.DeleteUserAsync(ID);
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public string SendMail(string emailid) {
            return base.Channel.SendMail(emailid);
        }
        
        public System.Threading.Tasks.Task<string> SendMailAsync(string emailid) {
            return base.Channel.SendMailAsync(emailid);
        }
        
        public string RedirectToResetPassword(string ucode, string emailid) {
            return base.Channel.RedirectToResetPassword(ucode, emailid);
        }
        
        public System.Threading.Tasks.Task<string> RedirectToResetPasswordAsync(string ucode, string emailid) {
            return base.Channel.RedirectToResetPasswordAsync(ucode, emailid);
        }
        
        public string ResetPassword(string ucode, string emailid, string password) {
            return base.Channel.ResetPassword(ucode, emailid, password);
        }
        
        public System.Threading.Tasks.Task<string> ResetPasswordAsync(string ucode, string emailid, string password) {
            return base.Channel.ResetPasswordAsync(ucode, emailid, password);
        }
    }
}
