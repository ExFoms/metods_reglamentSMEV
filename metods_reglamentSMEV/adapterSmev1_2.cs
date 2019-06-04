using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
namespace adapterSmev1_2
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class SystemFault : Fault
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidationFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class Fault : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Status : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        private StatusParameter[] parameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter", IsNullable = true, Order = 2)]
        public StatusParameter[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusParameter : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Reject : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RejectCode codeField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RejectCode code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum RejectCode
    {

        /// <remarks/>
        ACCESS_DENIED,

        /// <remarks/>
        NO_DATA,

        /// <remarks/>
        UNKNOWN_REQUEST_DESCRIPTION,

        /// <remarks/>
        FAILURE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        private Reject[] rejectsField;

        private Status statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rejects", IsNullable = true, Order = 1)]
        public Reject[] rejects
        {
            get
            {
                return this.rejectsField;
            }
            set
            {
                this.rejectsField = value;
                this.RaisePropertyChanged("rejects");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Content : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement messagePrimaryContentField;

        private System.Xml.XmlElement personalSignatureField;

        private AttachmentHeaderType[] attachmentHeaderListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.Xml.XmlElement MessagePrimaryContent
        {
            get
            {
                return this.messagePrimaryContentField;
            }
            set
            {
                this.messagePrimaryContentField = value;
                this.RaisePropertyChanged("MessagePrimaryContent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public System.Xml.XmlElement PersonalSignature
        {
            get
            {
                return this.personalSignatureField;
            }
            set
            {
                this.personalSignatureField = value;
                this.RaisePropertyChanged("PersonalSignature");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AttachmentHeader", IsNullable = false)]
        public AttachmentHeaderType[] AttachmentHeaderList
        {
            get
            {
                return this.attachmentHeaderListField;
            }
            set
            {
                this.attachmentHeaderListField = value;
                this.RaisePropertyChanged("AttachmentHeaderList");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class AttachmentHeaderType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private string filePathField;

        private byte[] signaturePKCS7Field;

        private TransferMethodType transferMethodField;

        private bool transferMethodFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string filePath
        {
            get
            {
                return this.filePathField;
            }
            set
            {
                this.filePathField = value;
                this.RaisePropertyChanged("filePath");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
                this.RaisePropertyChanged("SignaturePKCS7");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TransferMethodType TransferMethod
        {
            get
            {
                return this.transferMethodField;
            }
            set
            {
                this.transferMethodField = value;
                this.RaisePropertyChanged("TransferMethod");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransferMethodSpecified
        {
            get
            {
                return this.transferMethodFieldSpecified;
            }
            set
            {
                this.transferMethodFieldSpecified = value;
                this.RaisePropertyChanged("TransferMethodSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TransferMethodType
    {

        /// <remarks/>
        MTOM,

        /// <remarks/>
        REFERENCE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RegistryRecordRoutingType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int recordIdField;

        private bool useGeneralRoutingField;

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int RecordId
        {
            get
            {
                return this.recordIdField;
            }
            set
            {
                this.recordIdField = value;
                this.RaisePropertyChanged("RecordId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool UseGeneralRouting
        {
            get
            {
                return this.useGeneralRoutingField;
            }
            set
            {
                this.useGeneralRoutingField = value;
                this.RaisePropertyChanged("UseGeneralRouting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RoutingInformationType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        private RegistryRecordRoutingType[] registryRoutingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RegistryRecordRouting", IsNullable = false)]
        public RegistryRecordRoutingType[] RegistryRouting
        {
            get
            {
                return this.registryRoutingField;
            }
            set
            {
                this.registryRoutingField = value;
                this.RaisePropertyChanged("RegistryRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class BusinessProcessMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class CreateGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string fRGUServiceCodeField;

        private string fRGUServiceDescriptionField;

        private string fRGUServiceRecipientDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string FRGUServiceCode
        {
            get
            {
                return this.fRGUServiceCodeField;
            }
            set
            {
                this.fRGUServiceCodeField = value;
                this.RaisePropertyChanged("FRGUServiceCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string FRGUServiceDescription
        {
            get
            {
                return this.fRGUServiceDescriptionField;
            }
            set
            {
                this.fRGUServiceDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceDescription");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string FRGUServiceRecipientDescription
        {
            get
            {
                return this.fRGUServiceRecipientDescriptionField;
            }
            set
            {
                this.fRGUServiceRecipientDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceRecipientDescription");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class LinkedGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string refClientIdField;

        private string refGroupIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string refClientId
        {
            get
            {
                return this.refClientIdField;
            }
            set
            {
                this.refClientIdField = value;
                this.RaisePropertyChanged("refClientId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string refGroupId
        {
            get
            {
                return this.refGroupIdField;
            }
            set
            {
                this.refGroupIdField = value;
                this.RaisePropertyChanged("refGroupId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Metadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMetadataType : Metadata
    {

        private string originalClientIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string originalClientId
        {
            get
            {
                return this.originalClientIdField;
            }
            set
            {
                this.originalClientIdField = value;
                this.RaisePropertyChanged("originalClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMetadataType : Metadata
    {

        private string replyToClientIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string replyToClientId
        {
            get
            {
                return this.replyToClientIdField;
            }
            set
            {
                this.replyToClientIdField = value;
                this.RaisePropertyChanged("replyToClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMetadataType : Metadata
    {

        private LinkedGroupIdentity linkedGroupIdentityField;

        private CreateGroupIdentity createGroupIdentityField;

        private string nodeIdField;

        private System.DateTime eolField;

        private bool eolFieldSpecified;

        private bool testMessageField;

        private bool testMessageFieldSpecified;

        private string transactionCodeField;

        private BusinessProcessMetadata businessProcessMetadataField;

        private RoutingInformationType routingInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LinkedGroupIdentity linkedGroupIdentity
        {
            get
            {
                return this.linkedGroupIdentityField;
            }
            set
            {
                this.linkedGroupIdentityField = value;
                this.RaisePropertyChanged("linkedGroupIdentity");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CreateGroupIdentity createGroupIdentity
        {
            get
            {
                return this.createGroupIdentityField;
            }
            set
            {
                this.createGroupIdentityField = value;
                this.RaisePropertyChanged("createGroupIdentity");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string nodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
                this.RaisePropertyChanged("nodeId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime eol
        {
            get
            {
                return this.eolField;
            }
            set
            {
                this.eolField = value;
                this.RaisePropertyChanged("eol");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eolSpecified
        {
            get
            {
                return this.eolFieldSpecified;
            }
            set
            {
                this.eolFieldSpecified = value;
                this.RaisePropertyChanged("eolSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public bool testMessage
        {
            get
            {
                return this.testMessageField;
            }
            set
            {
                this.testMessageField = value;
                this.RaisePropertyChanged("testMessage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool testMessageSpecified
        {
            get
            {
                return this.testMessageFieldSpecified;
            }
            set
            {
                this.testMessageFieldSpecified = value;
                this.RaisePropertyChanged("testMessageSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public BusinessProcessMetadata BusinessProcessMetadata
        {
            get
            {
                return this.businessProcessMetadataField;
            }
            set
            {
                this.businessProcessMetadataField = value;
                this.RaisePropertyChanged("BusinessProcessMetadata");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public RoutingInformationType RoutingInformation
        {
            get
            {
                return this.routingInformationField;
            }
            set
            {
                this.routingInformationField = value;
                this.RaisePropertyChanged("RoutingInformation");
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Message : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string messageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMessage : Message
    {

        private StatusMetadataType statusMetadataField;

        private StatusMessageCategory statusField;

        private string detailsField;

        private System.DateTime timestampField;

        private bool timestampFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public StatusMetadataType statusMetadata
        {
            get
            {
                return this.statusMetadataField;
            }
            set
            {
                this.statusMetadataField = value;
                this.RaisePropertyChanged("statusMetadata");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StatusMessageCategory status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string details
        {
            get
            {
                return this.detailsField;
            }
            set
            {
                this.detailsField = value;
                this.RaisePropertyChanged("details");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timestampSpecified
        {
            get
            {
                return this.timestampFieldSpecified;
            }
            set
            {
                this.timestampFieldSpecified = value;
                this.RaisePropertyChanged("timestampSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum StatusMessageCategory
    {

        /// <remarks/>
        OTHER,

        /// <remarks/>
        ERROR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ErrorMessage : StatusMessage
    {

        private ErrorType typeField;

        private Fault faultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ErrorType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Fault fault
        {
            get
            {
                return this.faultField;
            }
            set
            {
                this.faultField = value;
                this.RaisePropertyChanged("fault");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ErrorType
    {

        /// <remarks/>
        SERVER,

        /// <remarks/>
        CLIENT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMessageType : Message
    {

        private ResponseMetadataType responseMetadataField;

        private ResponseContentType responseContentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ResponseMetadataType ResponseMetadata
        {
            get
            {
                return this.responseMetadataField;
            }
            set
            {
                this.responseMetadataField = value;
                this.RaisePropertyChanged("ResponseMetadata");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ResponseContentType ResponseContent
        {
            get
            {
                return this.responseContentField;
            }
            set
            {
                this.responseContentField = value;
                this.RaisePropertyChanged("ResponseContent");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMessageType : Message
    {

        private RequestMetadataType requestMetadataField;

        private RequestContentType requestContentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RequestMetadataType RequestMetadata
        {
            get
            {
                return this.requestMetadataField;
            }
            set
            {
                this.requestMetadataField = value;
                this.RaisePropertyChanged("RequestMetadata");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RequestContentType RequestContent
        {
            get
            {
                return this.requestContentField;
            }
            set
            {
                this.requestContentField = value;
                this.RaisePropertyChanged("RequestContent");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class SmevMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageIdField;

        private string referenceMessageIDField;

        private string transactionCodeField;

        private string originalMessageIDField;

        private string senderField;

        private string recipientField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
                this.RaisePropertyChanged("MessageId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ReferenceMessageID
        {
            get
            {
                return this.referenceMessageIDField;
            }
            set
            {
                this.referenceMessageIDField = value;
                this.RaisePropertyChanged("ReferenceMessageID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OriginalMessageID
        {
            get
            {
                return this.originalMessageIDField;
            }
            set
            {
                this.originalMessageIDField = value;
                this.RaisePropertyChanged("OriginalMessageID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
                this.RaisePropertyChanged("Sender");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
                this.RaisePropertyChanged("Recipient");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class QueryTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private TypeCriteria messageTypeCriteriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TypeCriteria messageTypeCriteria
        {
            get
            {
                return this.messageTypeCriteriaField;
            }
            set
            {
                this.messageTypeCriteriaField = value;
                this.RaisePropertyChanged("messageTypeCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TypeCriteria
    {

        /// <remarks/>
        RESPONSE,

        /// <remarks/>
        REQUEST,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class ValidationFault : Fault
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter", ConfigurationName = "SMEVServiceAdapterPortType")]
    public interface SMEVServiceAdapterPortType
    {

        [System.ServiceModel.OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Metadata))]
        GetResponse Get(GetRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        System.Threading.Tasks.Task<GetResponse> GetAsync(GetRequest request);

        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/service-adapter/types) сообщения FindRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/service-adapter).
        [System.ServiceModel.OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Metadata))]
        FindResponse Find(FindRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        System.Threading.Tasks.Task<FindResponse> FindAsync(FindRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Metadata))]
        SendResponse Send(SendRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        System.Threading.Tasks.Task<SendResponse> SendAsync(SendRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "MessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string nodeId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public QueryTypeCriteria specificQuery;

        public GetRequest()
        {
        }

        public GetRequest(string itSystem, string nodeId, QueryTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.nodeId = nodeId;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "QueryResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public SmevMetadata smevMetadata;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public Message Message;

        public GetResponse()
        {
        }

        public GetResponse(SmevMetadata smevMetadata, Message Message)
        {
            this.smevMetadata = smevMetadata;
            this.Message = Message;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class FindTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MessageIntervalCriteria messagePeriodCriteriaField;

        private MessageClientIdCriteria messageClientIdCriteriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public MessageIntervalCriteria messagePeriodCriteria
        {
            get
            {
                return this.messagePeriodCriteriaField;
            }
            set
            {
                this.messagePeriodCriteriaField = value;
                this.RaisePropertyChanged("messagePeriodCriteria");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public MessageClientIdCriteria messageClientIdCriteria
        {
            get
            {
                return this.messageClientIdCriteriaField;
            }
            set
            {
                this.messageClientIdCriteriaField = value;
                this.RaisePropertyChanged("messageClientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageIntervalCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime fromField;

        private System.DateTime toField;

        private bool toFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.DateTime from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public System.DateTime to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
                this.RaisePropertyChanged("to");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toSpecified
        {
            get
            {
                return this.toFieldSpecified;
            }
            set
            {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageClientIdCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        private ClientIdCriteria clientIdCriteriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ClientIdCriteria clientIdCriteria
        {
            get
            {
                return this.clientIdCriteriaField;
            }
            set
            {
                this.clientIdCriteriaField = value;
                this.RaisePropertyChanged("clientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ClientIdCriteria
    {

        /// <remarks/>
        GET_REQUEST_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_RESPONSE_CLIENTID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    [System.Xml.Serialization.XmlRootAttribute("OrderStatusEventRequest", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsNullable = false, ElementName = "AdapterMessage")]

    public partial class AdapterMessage : object, System.ComponentModel.INotifyPropertyChanged
    {

        private SmevMetadata smevMetadataField;

        private Message messageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SmevMetadata smevMetadata
        {
            get
            {
                return this.smevMetadataField;
            }
            set
            {
                this.smevMetadataField = value;
                this.RaisePropertyChanged("smevMetadata");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Message Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "FindMessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public FindTypeCriteria specificQuery;

        public FindRequest()
        {
        }

        public FindRequest(string itSystem, FindTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "QueryResultList", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("QueryResult")]
        public AdapterMessage[] QueryResult;

        public FindResponse()
        {
        }

        public FindResponse(AdapterMessage[] QueryResult)
        {
            this.QueryResult = QueryResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContract(WrapperName = "ClientMessage", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public RequestMessageType RequestMessage;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public ResponseMessageType ResponseMessage;

        public SendRequest()
        {
        }

        public SendRequest(string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            this.itSystem = itSystem;
            this.RequestMessage = RequestMessage;
            this.ResponseMessage = ResponseMessage;
        }

    }

    //Добавлено для формирования сообщения
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContract(WrapperName = "ClientMessage", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class ClientMessage
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public RequestMessageType RequestMessage;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public ResponseMessageType ResponseMessage;

        public ClientMessage()
        { }

        public ClientMessage(string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            this.itSystem = itSystem;
            this.RequestMessage = RequestMessage;
            this.ResponseMessage = ResponseMessage;
        }
    }




    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "MessageResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string MessageId;

        public SendResponse()
        {
        }

        public SendResponse(string itSystem, string MessageId)
        {
            this.itSystem = itSystem;
            this.MessageId = MessageId;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMEVServiceAdapterPortTypeChannel : SMEVServiceAdapterPortType, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMEVServiceAdapterPortTypeClient : System.ServiceModel.ClientBase<SMEVServiceAdapterPortType>, SMEVServiceAdapterPortType
    {

        public SMEVServiceAdapterPortTypeClient()
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetResponse SMEVServiceAdapterPortType.Get(GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public SmevMetadata Get(string itSystem, string nodeId, QueryTypeCriteria specificQuery, out Message Message)
        {
            GetRequest inValue = new GetRequest();
            inValue.itSystem = itSystem;
            inValue.nodeId = nodeId;
            inValue.specificQuery = specificQuery;
            GetResponse retVal = ((SMEVServiceAdapterPortType)(this)).Get(inValue);
            Message = retVal.Message;
            return retVal.smevMetadata;
        }

        public System.Threading.Tasks.Task<GetResponse> GetAsync(GetRequest request)
        {
            return base.Channel.GetAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FindResponse SMEVServiceAdapterPortType.Find(FindRequest request)
        {
            return base.Channel.Find(request);
        }

        public AdapterMessage[] Find(string itSystem, FindTypeCriteria specificQuery)
        {
            FindRequest inValue = new FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            FindResponse retVal = ((SMEVServiceAdapterPortType)(this)).Find(inValue);
            return retVal.QueryResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FindResponse> SMEVServiceAdapterPortType.FindAsync(FindRequest request)
        {
            return base.Channel.FindAsync(request);
        }

        public System.Threading.Tasks.Task<FindResponse> FindAsync(string itSystem, FindTypeCriteria specificQuery)
        {
            FindRequest inValue = new FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            return ((SMEVServiceAdapterPortType)(this)).FindAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendResponse SMEVServiceAdapterPortType.Send(SendRequest request)
        {
            return base.Channel.Send(request);
        }

        public string Send(ref string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            SendRequest inValue = new SendRequest();
            inValue.itSystem = itSystem;
            inValue.RequestMessage = RequestMessage;
            inValue.ResponseMessage = ResponseMessage;
            SendResponse retVal = ((SMEVServiceAdapterPortType)(this)).Send(inValue);
            itSystem = retVal.itSystem;
            return retVal.MessageId;
        }

        public System.Threading.Tasks.Task<SendResponse> SendAsync(SendRequest request)
        {
            return base.Channel.SendAsync(request);
        }
    }
}
