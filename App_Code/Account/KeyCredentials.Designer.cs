﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Account
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class KeyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new KeyEntities object using the connection string found in the 'KeyEntities' section of the application configuration file.
        /// </summary>
        public KeyEntities() : base("name=KeyEntities", "KeyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KeyEntities object.
        /// </summary>
        public KeyEntities(string connectionString) : base(connectionString, "KeyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KeyEntities object.
        /// </summary>
        public KeyEntities(EntityConnection connection) : base(connection, "KeyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AP_KeyCredentials> AP_KeyCredentials
        {
            get
            {
                if ((_AP_KeyCredentials == null))
                {
                    _AP_KeyCredentials = base.CreateObjectSet<AP_KeyCredentials>("AP_KeyCredentials");
                }
                return _AP_KeyCredentials;
            }
        }
        private ObjectSet<AP_KeyCredentials> _AP_KeyCredentials;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AP_KeyCredentials EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAP_KeyCredentials(AP_KeyCredentials aP_KeyCredentials)
        {
            base.AddObject("AP_KeyCredentials", aP_KeyCredentials);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="KeyCredentialsModel", Name="AP_KeyCredentials")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AP_KeyCredentials : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AP_KeyCredentials object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static AP_KeyCredentials CreateAP_KeyCredentials(global::System.Int32 id)
        {
            AP_KeyCredentials aP_KeyCredentials = new AP_KeyCredentials();
            aP_KeyCredentials.ID = id;
            return aP_KeyCredentials;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> KeyGuid
        {
            get
            {
                return _KeyGuid;
            }
            set
            {
                OnKeyGuidChanging(value);
                ReportPropertyChanging("KeyGuid");
                _KeyGuid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("KeyGuid");
                OnKeyGuidChanged();
            }
        }
        private Nullable<global::System.Guid> _KeyGuid;
        partial void OnKeyGuidChanging(Nullable<global::System.Guid> value);
        partial void OnKeyGuidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> MobilePasscode
        {
            get
            {
                return _MobilePasscode;
            }
            set
            {
                OnMobilePasscodeChanging(value);
                ReportPropertyChanging("MobilePasscode");
                _MobilePasscode = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MobilePasscode");
                OnMobilePasscodeChanged();
            }
        }
        private Nullable<global::System.Guid> _MobilePasscode;
        partial void OnMobilePasscodeChanging(Nullable<global::System.Guid> value);
        partial void OnMobilePasscodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastModified
        {
            get
            {
                return _LastModified;
            }
            set
            {
                OnLastModifiedChanging(value);
                ReportPropertyChanging("LastModified");
                _LastModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastModified");
                OnLastModifiedChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastModified;
        partial void OnLastModifiedChanging(Nullable<global::System.DateTime> value);
        partial void OnLastModifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateAdded
        {
            get
            {
                return _DateAdded;
            }
            set
            {
                OnDateAddedChanging(value);
                ReportPropertyChanging("DateAdded");
                _DateAdded = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateAdded");
                OnDateAddedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateAdded;
        partial void OnDateAddedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateAddedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsActive;
        partial void OnIsActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnIsActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Device
        {
            get
            {
                return _Device;
            }
            set
            {
                OnDeviceChanging(value);
                ReportPropertyChanging("Device");
                _Device = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Device");
                OnDeviceChanged();
            }
        }
        private global::System.String _Device;
        partial void OnDeviceChanging(global::System.String value);
        partial void OnDeviceChanged();

        #endregion

    
    }

    #endregion

    
}