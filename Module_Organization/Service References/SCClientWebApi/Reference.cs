//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 7/2/2017 1:31:03 AM
namespace Module_Organization.SCClientWebApi
{
    
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("SCClient.Core.Dto", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Module_Organization.SCClientWebApi", typeName.Substring(17)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Module_Organization.SCClientWebApi", global::System.StringComparison.Ordinal))
            {
                return string.Concat("SCClient.Core.Dto.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for trust in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Trust> trust
        {
            get
            {
                if ((this._trust == null))
                {
                    this._trust = base.CreateQuery<Trust>("trust");
                }
                return this._trust;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Trust> _trust;
        /// <summary>
        /// There are no comments for organization in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Organization> organization
        {
            get
            {
                if ((this._organization == null))
                {
                    this._organization = base.CreateQuery<Organization>("organization");
                }
                return this._organization;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Organization> _organization;
        /// <summary>
        /// There are no comments for trust in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddTotrust(Trust trust)
        {
            base.AddObject("trust", trust);
        }
        /// <summary>
        /// There are no comments for organization in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToorganization(Organization organization)
        {
            base.AddObject("organization", organization);
        }
    }
    /// <summary>
    /// There are no comments for SCClient.Core.Dto.Trust in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("trust")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Trust : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Trust object.
        /// </summary>
        /// <param name="trustTypeId">Initial value of TrustTypeId.</param>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Trust CreateTrust(int trustTypeId, int ID)
        {
            Trust trust = new Trust();
            trust.TrustTypeId = trustTypeId;
            trust.Id = ID;
            return trust;
        }
        /// <summary>
        /// There are no comments for Property TrustNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TrustNumber
        {
            get
            {
                return this._TrustNumber;
            }
            set
            {
                this.OnTrustNumberChanging(value);
                this._TrustNumber = value;
                this.OnTrustNumberChanged();
                this.OnPropertyChanged("TrustNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TrustNumber;
        partial void OnTrustNumberChanging(string value);
        partial void OnTrustNumberChanged();
        /// <summary>
        /// There are no comments for Property TrustTypeId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int TrustTypeId
        {
            get
            {
                return this._TrustTypeId;
            }
            set
            {
                this.OnTrustTypeIdChanging(value);
                this._TrustTypeId = value;
                this.OnTrustTypeIdChanged();
                this.OnPropertyChanged("TrustTypeId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _TrustTypeId;
        partial void OnTrustTypeIdChanging(int value);
        partial void OnTrustTypeIdChanged();
        /// <summary>
        /// There are no comments for Property TrustorFirstName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TrustorFirstName
        {
            get
            {
                return this._TrustorFirstName;
            }
            set
            {
                this.OnTrustorFirstNameChanging(value);
                this._TrustorFirstName = value;
                this.OnTrustorFirstNameChanged();
                this.OnPropertyChanged("TrustorFirstName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TrustorFirstName;
        partial void OnTrustorFirstNameChanging(string value);
        partial void OnTrustorFirstNameChanged();
        /// <summary>
        /// There are no comments for Property TrustorMiddleName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TrustorMiddleName
        {
            get
            {
                return this._TrustorMiddleName;
            }
            set
            {
                this.OnTrustorMiddleNameChanging(value);
                this._TrustorMiddleName = value;
                this.OnTrustorMiddleNameChanged();
                this.OnPropertyChanged("TrustorMiddleName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TrustorMiddleName;
        partial void OnTrustorMiddleNameChanging(string value);
        partial void OnTrustorMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property TrustorLastName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string TrustorLastName
        {
            get
            {
                return this._TrustorLastName;
            }
            set
            {
                this.OnTrustorLastNameChanging(value);
                this._TrustorLastName = value;
                this.OnTrustorLastNameChanged();
                this.OnPropertyChanged("TrustorLastName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _TrustorLastName;
        partial void OnTrustorLastNameChanging(string value);
        partial void OnTrustorLastNameChanged();
        /// <summary>
        /// There are no comments for Property TrustorBirthYear in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> TrustorBirthYear
        {
            get
            {
                return this._TrustorBirthYear;
            }
            set
            {
                this.OnTrustorBirthYearChanging(value);
                this._TrustorBirthYear = value;
                this.OnTrustorBirthYearChanged();
                this.OnPropertyChanged("TrustorBirthYear");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _TrustorBirthYear;
        partial void OnTrustorBirthYearChanging(global::System.Nullable<int> value);
        partial void OnTrustorBirthYearChanged();
        /// <summary>
        /// There are no comments for Property TrustorDateDeceased in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> TrustorDateDeceased
        {
            get
            {
                return this._TrustorDateDeceased;
            }
            set
            {
                this.OnTrustorDateDeceasedChanging(value);
                this._TrustorDateDeceased = value;
                this.OnTrustorDateDeceasedChanged();
                this.OnPropertyChanged("TrustorDateDeceased");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _TrustorDateDeceased;
        partial void OnTrustorDateDeceasedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnTrustorDateDeceasedChanged();
        /// <summary>
        /// There are no comments for Property SpouseFirstName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SpouseFirstName
        {
            get
            {
                return this._SpouseFirstName;
            }
            set
            {
                this.OnSpouseFirstNameChanging(value);
                this._SpouseFirstName = value;
                this.OnSpouseFirstNameChanged();
                this.OnPropertyChanged("SpouseFirstName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SpouseFirstName;
        partial void OnSpouseFirstNameChanging(string value);
        partial void OnSpouseFirstNameChanged();
        /// <summary>
        /// There are no comments for Property SpouseMiddleName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SpouseMiddleName
        {
            get
            {
                return this._SpouseMiddleName;
            }
            set
            {
                this.OnSpouseMiddleNameChanging(value);
                this._SpouseMiddleName = value;
                this.OnSpouseMiddleNameChanged();
                this.OnPropertyChanged("SpouseMiddleName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SpouseMiddleName;
        partial void OnSpouseMiddleNameChanging(string value);
        partial void OnSpouseMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property SpouseLastName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SpouseLastName
        {
            get
            {
                return this._SpouseLastName;
            }
            set
            {
                this.OnSpouseLastNameChanging(value);
                this._SpouseLastName = value;
                this.OnSpouseLastNameChanged();
                this.OnPropertyChanged("SpouseLastName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SpouseLastName;
        partial void OnSpouseLastNameChanging(string value);
        partial void OnSpouseLastNameChanged();
        /// <summary>
        /// There are no comments for Property SpouseBirthYear in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> SpouseBirthYear
        {
            get
            {
                return this._SpouseBirthYear;
            }
            set
            {
                this.OnSpouseBirthYearChanging(value);
                this._SpouseBirthYear = value;
                this.OnSpouseBirthYearChanged();
                this.OnPropertyChanged("SpouseBirthYear");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _SpouseBirthYear;
        partial void OnSpouseBirthYearChanging(global::System.Nullable<int> value);
        partial void OnSpouseBirthYearChanged();
        /// <summary>
        /// There are no comments for Property SpouseDateDeceased in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> SpouseDateDeceased
        {
            get
            {
                return this._SpouseDateDeceased;
            }
            set
            {
                this.OnSpouseDateDeceasedChanging(value);
                this._SpouseDateDeceased = value;
                this.OnSpouseDateDeceasedChanged();
                this.OnPropertyChanged("SpouseDateDeceased");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _SpouseDateDeceased;
        partial void OnSpouseDateDeceasedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnSpouseDateDeceasedChanged();
        /// <summary>
        /// There are no comments for Property MaritalStatus in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MaritalStatus
        {
            get
            {
                return this._MaritalStatus;
            }
            set
            {
                this.OnMaritalStatusChanging(value);
                this._MaritalStatus = value;
                this.OnMaritalStatusChanged();
                this.OnPropertyChanged("MaritalStatus");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MaritalStatus;
        partial void OnMaritalStatusChanging(string value);
        partial void OnMaritalStatusChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for SCClient.Core.Dto.Organization in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("organization")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Organization : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Organization object.
        /// </summary>
        /// <param name="type">Initial value of Type.</param>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Organization CreateOrganization(int type, int ID)
        {
            Organization organization = new Organization();
            organization.Type = type;
            organization.Id = ID;
            return organization;
        }
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Type;
        partial void OnTypeChanging(int value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
                this.OnPropertyChanged("Country");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        /// <summary>
        /// There are no comments for Property SponsorType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SponsorType
        {
            get
            {
                return this._SponsorType;
            }
            set
            {
                this.OnSponsorTypeChanging(value);
                this._SponsorType = value;
                this.OnSponsorTypeChanged();
                this.OnPropertyChanged("SponsorType");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SponsorType;
        partial void OnSponsorTypeChanging(string value);
        partial void OnSponsorTypeChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property FPMRep in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FPMRep
        {
            get
            {
                return this._FPMRep;
            }
            set
            {
                this.OnFPMRepChanging(value);
                this._FPMRep = value;
                this.OnFPMRepChanged();
                this.OnPropertyChanged("FPMRep");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FPMRep;
        partial void OnFPMRepChanging(string value);
        partial void OnFPMRepChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this._Address = value;
                this.OnAddressChanged();
                this.OnPropertyChanged("Address");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property CPerson in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CPerson
        {
            get
            {
                return this._CPerson;
            }
            set
            {
                this.OnCPersonChanging(value);
                this._CPerson = value;
                this.OnCPersonChanged();
                this.OnPropertyChanged("CPerson");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CPerson;
        partial void OnCPersonChanging(string value);
        partial void OnCPersonChanged();
        /// <summary>
        /// There are no comments for Property CTitle in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CTitle
        {
            get
            {
                return this._CTitle;
            }
            set
            {
                this.OnCTitleChanging(value);
                this._CTitle = value;
                this.OnCTitleChanged();
                this.OnPropertyChanged("CTitle");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CTitle;
        partial void OnCTitleChanging(string value);
        partial void OnCTitleChanged();
        /// <summary>
        /// There are no comments for Property CEmail in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CEmail
        {
            get
            {
                return this._CEmail;
            }
            set
            {
                this.OnCEmailChanging(value);
                this._CEmail = value;
                this.OnCEmailChanged();
                this.OnPropertyChanged("CEmail");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CEmail;
        partial void OnCEmailChanging(string value);
        partial void OnCEmailChanged();
        /// <summary>
        /// There are no comments for Property OrganizationTypeId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> OrganizationTypeId
        {
            get
            {
                return this._OrganizationTypeId;
            }
            set
            {
                this.OnOrganizationTypeIdChanging(value);
                this._OrganizationTypeId = value;
                this.OnOrganizationTypeIdChanged();
                this.OnPropertyChanged("OrganizationTypeId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _OrganizationTypeId;
        partial void OnOrganizationTypeIdChanging(global::System.Nullable<int> value);
        partial void OnOrganizationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
