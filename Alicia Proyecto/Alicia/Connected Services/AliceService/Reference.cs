﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26323.1
// 
namespace Alicia.AliceService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherInfo", Namespace="http://schemas.datacontract.org/2004/07/SmartMirror.Models")]
    public partial class WeatherInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private System.Collections.ObjectModel.ObservableCollection<Alicia.AliceService.Forecast> forecastField;
        
        private int humidityField;
        
        private Alicia.AliceService.Location locationField;
        
        private string tempField;
        
        private string textField;
        
        private int windField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<Alicia.AliceService.Forecast> forecast {
            get {
                return this.forecastField;
            }
            set {
                if ((object.ReferenceEquals(this.forecastField, value) != true)) {
                    this.forecastField = value;
                    this.RaisePropertyChanged("forecast");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int humidity {
            get {
                return this.humidityField;
            }
            set {
                if ((this.humidityField.Equals(value) != true)) {
                    this.humidityField = value;
                    this.RaisePropertyChanged("humidity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Alicia.AliceService.Location location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string temp {
            get {
                return this.tempField;
            }
            set {
                if ((object.ReferenceEquals(this.tempField, value) != true)) {
                    this.tempField = value;
                    this.RaisePropertyChanged("temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int wind {
            get {
                return this.windField;
            }
            set {
                if ((this.windField.Equals(value) != true)) {
                    this.windField = value;
                    this.RaisePropertyChanged("wind");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/SmartMirror.Models.Weather")]
    public partial class Location : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private string countryField;
        
        private string regionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string region {
            get {
                return this.regionField;
            }
            set {
                if ((object.ReferenceEquals(this.regionField, value) != true)) {
                    this.regionField = value;
                    this.RaisePropertyChanged("region");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Forecast", Namespace="http://schemas.datacontract.org/2004/07/SmartMirror.Models")]
    public partial class Forecast : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dateField;
        
        private string dayField;
        
        private int highField;
        
        private int lowField;
        
        private string textField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string date {
            get {
                return this.dateField;
            }
            set {
                if ((object.ReferenceEquals(this.dateField, value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string day {
            get {
                return this.dayField;
            }
            set {
                if ((object.ReferenceEquals(this.dayField, value) != true)) {
                    this.dayField = value;
                    this.RaisePropertyChanged("day");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int high {
            get {
                return this.highField;
            }
            set {
                if ((this.highField.Equals(value) != true)) {
                    this.highField = value;
                    this.RaisePropertyChanged("high");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int low {
            get {
                return this.lowField;
            }
            set {
                if ((this.lowField.Equals(value) != true)) {
                    this.lowField = value;
                    this.RaisePropertyChanged("low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="rss", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class rss : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Alicia.AliceService.rssChannel channelField;
        
        private decimal versionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Alicia.AliceService.rssChannel channel {
            get {
                return this.channelField;
            }
            set {
                if ((object.ReferenceEquals(this.channelField, value) != true)) {
                    this.channelField = value;
                    this.RaisePropertyChanged("channel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal version {
            get {
                return this.versionField;
            }
            set {
                if ((this.versionField.Equals(value) != true)) {
                    this.versionField = value;
                    this.RaisePropertyChanged("version");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="rssChannel", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class rssChannel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descriptionField;
        
        private System.Collections.ObjectModel.ObservableCollection<Alicia.AliceService.rssChannelItem> itemField;
        
        private string languageField;
        
        private Alicia.AliceService.link linkField;
        
        private string link1Field;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<Alicia.AliceService.rssChannelItem> item {
            get {
                return this.itemField;
            }
            set {
                if ((object.ReferenceEquals(this.itemField, value) != true)) {
                    this.itemField = value;
                    this.RaisePropertyChanged("item");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string language {
            get {
                return this.languageField;
            }
            set {
                if ((object.ReferenceEquals(this.languageField, value) != true)) {
                    this.languageField = value;
                    this.RaisePropertyChanged("language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Alicia.AliceService.link link {
            get {
                return this.linkField;
            }
            set {
                if ((object.ReferenceEquals(this.linkField, value) != true)) {
                    this.linkField = value;
                    this.RaisePropertyChanged("link");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string link1 {
            get {
                return this.link1Field;
            }
            set {
                if ((object.ReferenceEquals(this.link1Field, value) != true)) {
                    this.link1Field = value;
                    this.RaisePropertyChanged("link1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="link", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class link : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string hrefField;
        
        private string relField;
        
        private string typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                if ((object.ReferenceEquals(this.hrefField, value) != true)) {
                    this.hrefField = value;
                    this.RaisePropertyChanged("href");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rel {
            get {
                return this.relField;
            }
            set {
                if ((object.ReferenceEquals(this.relField, value) != true)) {
                    this.relField = value;
                    this.RaisePropertyChanged("rel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="rssChannelItem", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class rssChannelItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string categoryField;
        
        private string descriptionField;
        
        private string guidField;
        
        private string linkField;
        
        private string pubDateField;
        
        private string shortdescField;
        
        private string thumbnailField;
        
        private Alicia.AliceService.thumbnail thumbnail1Field;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string guid {
            get {
                return this.guidField;
            }
            set {
                if ((object.ReferenceEquals(this.guidField, value) != true)) {
                    this.guidField = value;
                    this.RaisePropertyChanged("guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string link {
            get {
                return this.linkField;
            }
            set {
                if ((object.ReferenceEquals(this.linkField, value) != true)) {
                    this.linkField = value;
                    this.RaisePropertyChanged("link");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string pubDate {
            get {
                return this.pubDateField;
            }
            set {
                if ((object.ReferenceEquals(this.pubDateField, value) != true)) {
                    this.pubDateField = value;
                    this.RaisePropertyChanged("pubDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shortdesc {
            get {
                return this.shortdescField;
            }
            set {
                if ((object.ReferenceEquals(this.shortdescField, value) != true)) {
                    this.shortdescField = value;
                    this.RaisePropertyChanged("shortdesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string thumbnail {
            get {
                return this.thumbnailField;
            }
            set {
                if ((object.ReferenceEquals(this.thumbnailField, value) != true)) {
                    this.thumbnailField = value;
                    this.RaisePropertyChanged("thumbnail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Alicia.AliceService.thumbnail thumbnail1 {
            get {
                return this.thumbnail1Field;
            }
            set {
                if ((object.ReferenceEquals(this.thumbnail1Field, value) != true)) {
                    this.thumbnail1Field = value;
                    this.RaisePropertyChanged("thumbnail1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="thumbnail", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class thumbnail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string urlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                if ((object.ReferenceEquals(this.urlField, value) != true)) {
                    this.urlField = value;
                    this.RaisePropertyChanged("url");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/SmartMirrorBLL.AliciaService")]
    public partial class Usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ApellidoMaternoField;
        
        private string ApellidoPaternoField;
        
        private System.Nullable<System.DateTime> FechaHoraField;
        
        private System.Nullable<System.DateTime> FechaUsuarioField;
        
        private string FotoURLField;
        
        private System.Nullable<int> NipField;
        
        private string NombreField;
        
        private string PasswordField;
        
        private int SexoField;
        
        private int UsuarioIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaHora {
            get {
                return this.FechaHoraField;
            }
            set {
                if ((this.FechaHoraField.Equals(value) != true)) {
                    this.FechaHoraField = value;
                    this.RaisePropertyChanged("FechaHora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaUsuario {
            get {
                return this.FechaUsuarioField;
            }
            set {
                if ((this.FechaUsuarioField.Equals(value) != true)) {
                    this.FechaUsuarioField = value;
                    this.RaisePropertyChanged("FechaUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FotoURL {
            get {
                return this.FotoURLField;
            }
            set {
                if ((object.ReferenceEquals(this.FotoURLField, value) != true)) {
                    this.FotoURLField = value;
                    this.RaisePropertyChanged("FotoURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Nip {
            get {
                return this.NipField;
            }
            set {
                if ((this.NipField.Equals(value) != true)) {
                    this.NipField = value;
                    this.RaisePropertyChanged("Nip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((this.SexoField.Equals(value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UsuarioId {
            get {
                return this.UsuarioIdField;
            }
            set {
                if ((this.UsuarioIdField.Equals(value) != true)) {
                    this.UsuarioIdField = value;
                    this.RaisePropertyChanged("UsuarioId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AliceService.ISmartMirror")]
    public interface ISmartMirror {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartMirror/getWeatherByWOEID", ReplyAction="http://tempuri.org/ISmartMirror/getWeatherByWOEIDResponse")]
        System.Threading.Tasks.Task<Alicia.AliceService.WeatherInfo> getWeatherByWOEIDAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartMirror/getTechNews", ReplyAction="http://tempuri.org/ISmartMirror/getTechNewsResponse")]
        System.Threading.Tasks.Task<Alicia.AliceService.rss> getTechNewsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartMirror/getUsuario", ReplyAction="http://tempuri.org/ISmartMirror/getUsuarioResponse")]
        System.Threading.Tasks.Task<Alicia.AliceService.Usuario> getUsuarioAsync(string usuarioId, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISmartMirrorChannel : Alicia.AliceService.ISmartMirror, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartMirrorClient : System.ServiceModel.ClientBase<Alicia.AliceService.ISmartMirror>, Alicia.AliceService.ISmartMirror {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SmartMirrorClient() : 
                base(SmartMirrorClient.GetDefaultBinding(), SmartMirrorClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISmartMirror.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmartMirrorClient(EndpointConfiguration endpointConfiguration) : 
                base(SmartMirrorClient.GetBindingForEndpoint(endpointConfiguration), SmartMirrorClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmartMirrorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SmartMirrorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmartMirrorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SmartMirrorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmartMirrorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<Alicia.AliceService.WeatherInfo> getWeatherByWOEIDAsync(int value) {
            return base.Channel.getWeatherByWOEIDAsync(value);
        }
        
        public System.Threading.Tasks.Task<Alicia.AliceService.rss> getTechNewsAsync() {
            return base.Channel.getTechNewsAsync();
        }
        
        public System.Threading.Tasks.Task<Alicia.AliceService.Usuario> getUsuarioAsync(string usuarioId, string password) {
            return base.Channel.getUsuarioAsync(usuarioId, password);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISmartMirror)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISmartMirror)) {
                return new System.ServiceModel.EndpointAddress("http://luisduenas-001-site1.ctempurl.com/SmartMirrorService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return SmartMirrorClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISmartMirror);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return SmartMirrorClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISmartMirror);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ISmartMirror,
        }
    }
}