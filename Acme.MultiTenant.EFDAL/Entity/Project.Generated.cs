//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 612
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using Acme.MultiTenant.EFDAL;
using Acme.MultiTenant.EFDAL.EventArguments;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Acme.MultiTenant.EFDAL.Entity
{
	/// <summary>
	/// The 'Project' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	[FieldNameConstants(typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))]
	[EntityMetadata("Project", false,true, true, true, "", true, false, false, "dbo")]
	[MetadataTypeAttribute(typeof(Acme.MultiTenant.EFDAL.Entity.Metadata.ProjectMetadata))]
	[TenantEntity]
	public partial class Project : BaseEntity, Acme.MultiTenant.EFDAL.IBusinessObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ICloneable, Acme.MultiTenant.EFDAL.IAuditable, Acme.MultiTenant.EFDAL.IAuditableSet, Acme.MultiTenant.EFDAL.ICreatable
	{
		#region FieldNameConstants Enumeration

		/// <summary>
		/// Enumeration to define each property that maps to a database field for the 'Project' table.
		/// </summary>
		public enum FieldNameConstants
		{
			/// <summary>
			/// Field mapping for the 'Name' property
			/// </summary>
			Name,
			/// <summary>
			/// Field mapping for the 'ProjectId' property
			/// </summary>
			[System.ComponentModel.DataAnnotations.Key]
			[System.ComponentModel.DataAnnotations.Editable(false)]
			ProjectId,
			/// <summary>
			/// Field mapping for the 'ProjectTypeId' property
			/// </summary>
			ProjectTypeId,
			/// <summary>
			/// Field mapping for the 'CreatedBy' property
			/// </summary>
			CreatedBy,
			/// <summary>
			/// Field mapping for the 'CreatedDate' property
			/// </summary>
			CreatedDate,
			/// <summary>
			/// Field mapping for the 'ModifiedBy' property
			/// </summary>
			ModifiedBy,
			/// <summary>
			/// Field mapping for the 'ModifiedDate' property
			/// </summary>
			ModifiedDate,
		}
		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Project entity
		/// </summary>
		public Project()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// The property that maps back to the database 'Project.Name' field.
		/// </summary>
		/// <remarks>Field: [Project].[Name], Field Length: 50, Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Name")]
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Name
		{
			get { return _name; }
			set
			{
				if ((value != null) && (value.Length > GetMaxLength(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name))) throw new Exception(string.Format(GlobalValues.ERROR_DATA_TOO_BIG, value, "Project.Name", GetMaxLength(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name)));
				if (value == _name) return;
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>(value, "Name");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_name = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("Name"));
			}
		}

		/// <summary>
		/// The property that maps back to the database 'Project.ProjectId' field.
		/// </summary>
		/// <remarks>Field: [Project].[ProjectId], Not Nullable, Primary Key, AutoNumber, Unique, Indexed</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "ProjectId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int ProjectId
		{
			get { return _projectId; }
			protected internal set
			{
				if (value == _projectId) return;
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>(value, "ProjectId");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_projectId = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ProjectId"));
			}
		}

		/// <summary>
		/// This property is a wrapper for the typed enumeration for the 'ProjectTypeId' field.
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.NotMapped()]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual Acme.MultiTenant.EFDAL.ProjectTypeConstants ProjectTypeValue
		{
			get { return (Acme.MultiTenant.EFDAL.ProjectTypeConstants)this.ProjectTypeId; }
			set { this.ProjectTypeId = (int)value; }
		}

		/// <summary>
		/// The property that maps back to the database 'Project.ProjectTypeId' field.
		/// This property has an additional enumeration wrapper property ProjectTypeValue. Use it as a strongly-typed property.
		/// </summary>
		/// <remarks>Field: [Project].[ProjectTypeId], Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "ProjectTypeId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int ProjectTypeId
		{
			get { return _projectTypeId; }
			set
			{
				//Error check the wrapped enumeration
				switch(value)
				{
					case 1:
					case 2:
					case 3:
						break;
					default: throw new Exception(string.Format(GlobalValues.ERROR_INVALID_ENUM, value.ToString(), "Project.ProjectTypeId"));
				}

				if (value == _projectTypeId) return;
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>(value, "ProjectTypeId");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_projectTypeId = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ProjectTypeId"));
			}
		}

		/// <summary>
		/// The audit field for the 'Created By' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditCreatedBy]
		public virtual string CreatedBy
		{
			get { return _createdby; }
			protected internal set
			{
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>(value, "CreatedBy");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_createdby = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("CreatedBy"));
			}
		}

		/// <summary />
		protected string _createdby;

		/// <summary>
		/// The audit field for the 'Created Date' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditCreatedDate]
		public virtual DateTime CreatedDate
		{
			get { return _createddate; }
			protected internal set
			{
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime>(value, "CreatedDate");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_createddate = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("CreatedDate"));
			}
		}

		/// <summary />
		protected DateTime _createddate;

		/// <summary>
		/// The audit field for the 'Modified By' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditModifiedBy]
		public virtual string ModifiedBy
		{
			get { return _modifiedby; }
			protected internal set
			{
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>(value, "ModifiedBy");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_modifiedby = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ModifiedBy"));
			}
		}

		/// <summary />
		protected string _modifiedby;

		/// <summary>
		/// The audit field for the 'Modified Date' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditModifiedDate]
		public virtual DateTime ModifiedDate
		{
			get { return _modifieddate; }
			protected internal set
			{
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime>(value, "ModifiedDate");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_modifieddate = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ModifiedDate"));
			}
		}

		/// <summary />
		protected DateTime _modifieddate;

		/// <summary>
		/// The audit field for the 'Timestamp' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditTimestamp]
		public virtual byte[] Timestamp
		{
			get { return _timestamp; }
			protected internal set
			{
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<byte[]>(value, "Timestamp");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_timestamp = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("Timestamp"));
			}
		}

		/// <summary />
		protected byte[] _timestamp;

		#endregion

		#region Property Holders

		/// <summary />
		protected string _name;
		/// <summary>
		/// Occurs when the 'Name' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>> NameChanging;

		/// <summary>
		/// Raises the OnNameChanging event.
		/// </summary>
		protected virtual void OnNameChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.NameChanging != null)
				this.NameChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'Name' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> NameChanged;

		/// <summary>
		/// Raises the OnNameChanged event.
		/// </summary>
		protected virtual void OnNameChanged(ChangedEventArgs<string> e)
		{
			if (this.NameChanged != null)
				this.NameChanged(this, e);
		}

		/// <summary />
		protected int _projectId;
		/// <summary>
		/// Occurs when the 'ProjectId' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>> ProjectIdChanging;

		/// <summary>
		/// Raises the OnProjectIdChanging event.
		/// </summary>
		protected virtual void OnProjectIdChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.ProjectIdChanging != null)
				this.ProjectIdChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ProjectId' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> ProjectIdChanged;

		/// <summary>
		/// Raises the OnProjectIdChanged event.
		/// </summary>
		protected virtual void OnProjectIdChanged(ChangedEventArgs<int> e)
		{
			if (this.ProjectIdChanged != null)
				this.ProjectIdChanged(this, e);
		}

		/// <summary />
		protected int _projectTypeId;
		/// <summary>
		/// Occurs when the 'ProjectTypeId' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>> ProjectTypeIdChanging;

		/// <summary>
		/// Raises the OnProjectTypeIdChanging event.
		/// </summary>
		protected virtual void OnProjectTypeIdChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.ProjectTypeIdChanging != null)
				this.ProjectTypeIdChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ProjectTypeId' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> ProjectTypeIdChanged;

		/// <summary>
		/// Raises the OnProjectTypeIdChanged event.
		/// </summary>
		protected virtual void OnProjectTypeIdChanged(ChangedEventArgs<int> e)
		{
			if (this.ProjectTypeIdChanged != null)
				this.ProjectTypeIdChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedBy' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>> CreatedByChanging;

		/// <summary>
		/// Raises the OnCreatedByChanging event.
		/// </summary>
		protected virtual void OnCreatedByChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.CreatedByChanging != null)
				this.CreatedByChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedBy' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> CreatedByChanged;

		/// <summary>
		/// Raises the OnCreatedByChanged event.
		/// </summary>
		protected virtual void OnCreatedByChanged(ChangedEventArgs<string> e)
		{
			if (this.CreatedByChanged != null)
				this.CreatedByChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedDate' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime>> CreatedDateChanging;

		/// <summary>
		/// Raises the OnCreatedDateChanging event.
		/// </summary>
		protected virtual void OnCreatedDateChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime> e)
		{
			if (this.CreatedDateChanging != null)
				this.CreatedDateChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedDate' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<DateTime>> CreatedDateChanged;

		/// <summary>
		/// Raises the OnCreatedDateChanged event.
		/// </summary>
		protected virtual void OnCreatedDateChanged(ChangedEventArgs<DateTime> e)
		{
			if (this.CreatedDateChanged != null)
				this.CreatedDateChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedBy' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>> ModifiedByChanging;

		/// <summary>
		/// Raises the OnModifiedByChanging event.
		/// </summary>
		protected virtual void OnModifiedByChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.ModifiedByChanging != null)
				this.ModifiedByChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedBy' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> ModifiedByChanged;

		/// <summary>
		/// Raises the OnModifiedByChanged event.
		/// </summary>
		protected virtual void OnModifiedByChanged(ChangedEventArgs<string> e)
		{
			if (this.ModifiedByChanged != null)
				this.ModifiedByChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedDate' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime>> ModifiedDateChanging;

		/// <summary>
		/// Raises the OnModifiedDateChanging event.
		/// </summary>
		protected virtual void OnModifiedDateChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<DateTime> e)
		{
			if (this.ModifiedDateChanging != null)
				this.ModifiedDateChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedDate' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<DateTime>> ModifiedDateChanged;

		/// <summary>
		/// Raises the OnModifiedDateChanged event.
		/// </summary>
		protected virtual void OnModifiedDateChanged(ChangedEventArgs<DateTime> e)
		{
			if (this.ModifiedDateChanged != null)
				this.ModifiedDateChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'Timestamp' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<byte[]>> TimestampChanging;

		/// <summary>
		/// Raises the OnTimestampChanging event.
		/// </summary>
		protected virtual void OnTimestampChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<byte[]> e)
		{
			if (this.TimestampChanging != null)
				this.TimestampChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'Timestamp' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<byte[]>> TimestampChanged;

		/// <summary>
		/// Raises the OnTimestampChanged event.
		/// </summary>
		protected virtual void OnTimestampChanged(ChangedEventArgs<byte[]> e)
		{
			if (this.TimestampChanged != null)
				this.TimestampChanged(this, e);
		}


		#endregion

		#region GetMaxLength

		/// <summary>
		/// Gets the maximum size of the field value.
		/// </summary>
		public static int GetMaxLength(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field)
		{
			switch (field)
			{
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name:
					return 50;
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectId:
					return 0; //Type=Int
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectTypeId:
					return 0; //Type=Int
			}
			return 0;
		}

		int Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetMaxLength(Enum field)
		{
			return GetMaxLength((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field);
		}

		#endregion

		#region GetFieldNameConstants

		System.Type Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetFieldNameConstants()
		{
			return typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants);
		}

		#endregion

		#region GetFieldType

		/// <summary>
		/// Gets the system type of a field on this object
		/// </summary>
		public static System.Type GetFieldType(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants'.");

			switch ((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field)
			{
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name: return typeof(string);
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectId: return typeof(int);
				case Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectTypeId: return typeof(int);
			}
			return null;
		}

		System.Type Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetFieldType(Enum field)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants'.");

			return GetFieldType((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field);
		}

		#endregion

		#region Get/Set Value

		object Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field)
		{
			return ((Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject)this).GetValue(field, null);
		}

		object Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field, object defaultValue)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants'.");
			return this.GetValue((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field, defaultValue);
		}

		void Acme.MultiTenant.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants'.");
			this.SetValue((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field, newValue);
		}

		void Acme.MultiTenant.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue, bool fixLength)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants'.");
			this.SetValue((Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants)field, newValue, fixLength);
		}

		#endregion

		#region PrimaryKey

		/// <summary>
		/// Generic primary key for this object
		/// </summary>
		Acme.MultiTenant.EFDAL.IPrimaryKey Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.PrimaryKey
		{
			get { return new PrimaryKey(Util.HashPK("Project", this.ProjectId)); }
		}

		#endregion

		#region Clone

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public virtual object Clone()
		{
			return Acme.MultiTenant.EFDAL.Entity.Project.Clone(this);
		}

		/// <summary>
		/// Creates a shallow copy of this object with defined, default values and new PK
		/// </summary>
		public virtual object CloneAsNew()
		{
			var item = Acme.MultiTenant.EFDAL.Entity.Project.Clone(this);
			item._projectId = 0;
			return item;
		}

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public static Project Clone(Acme.MultiTenant.EFDAL.Entity.Project item)
		{
			var newItem = new Project();
			newItem.Name = item.Name;
			newItem.ProjectId = item.ProjectId;
			newItem.ProjectTypeId = item.ProjectTypeId;
			newItem.CreatedDate = item.CreatedDate;
			newItem.CreatedBy = item.CreatedBy;
			newItem.ModifiedDate = item.ModifiedDate;
			newItem.ModifiedBy = item.ModifiedBy;
			return newItem;
		}

		#endregion

		#region GetValue

		/// <summary>
		/// Gets the value of one of this object's properties.
		/// </summary>
		public virtual object GetValue(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field)
		{
			return GetValue(field, null);
		}

		/// <summary>
		/// Gets the value of one of this object's properties.
		/// </summary>
		public virtual object GetValue(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field, object defaultValue)
		{
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name)
				return this.Name;
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectId)
				return this.ProjectId;
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectTypeId)
				return this.ProjectTypeId;
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.CreatedBy)
				return ((this.CreatedBy == null) ? defaultValue : this.CreatedBy);
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.CreatedDate)
				return ((this.CreatedDate == null) ? defaultValue : this.CreatedDate);
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ModifiedBy)
				return ((this.ModifiedBy == null) ? defaultValue : this.ModifiedBy);
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ModifiedDate)
				return ((this.ModifiedDate == null) ? defaultValue : this.ModifiedDate);
			throw new Exception("Field '" + field.ToString() + "' not found!");
		}

		#endregion

		#region SetValue

		/// <summary>
		/// Assigns a value to a field on this object.
		/// </summary>
		/// <param name="field">The field to set</param>
		/// <param name="newValue">The new value to assign to the field</param>
		public virtual void SetValue(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field, object newValue)
		{
			SetValue(field, newValue, false);
		}

		/// <summary>
		/// Assigns a value to a field on this object.
		/// </summary>
		/// <param name="field">The field to set</param>
		/// <param name="newValue">The new value to assign to the field</param>
		/// <param name="fixLength">Determines if the length should be truncated if too long. When false, an error will be raised if data is too large to be assigned to the field.</param>
		public virtual void SetValue(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field, object newValue, bool fixLength)
		{
			if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.Name)
			{
				this.Name = GlobalValues.SetValueHelperInternal((string)newValue, fixLength, GetMaxLength(field));
			}
			else if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectId)
			{
				throw new Exception("Field '" + field.ToString() + "' is a primary key and cannot be set!");
			}
			else if (field == Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants.ProjectTypeId)
			{
				this.ProjectTypeId = GlobalValues.SetValueHelperIntNotNullableInternal(newValue, "Field 'ProjectTypeId' does not allow null values!");
			}
			else
				throw new Exception("Field '" + field.ToString() + "' not found!");
		}

		#endregion

		#region Navigation Properties

		/// <summary>
		/// The navigation definition for walking Project->ProjectFile
		/// </summary>
		public virtual ICollection<Acme.MultiTenant.EFDAL.Entity.ProjectFile> ProjectFileList
		{
			get; protected internal set;
		}

		/// <summary>
		/// The navigation definition for walking ProjectType->Project
		/// </summary>
		public virtual ProjectType ProjectType { get; set; }

		#endregion

		#region GetDatabaseFieldName

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		internal static string GetDatabaseFieldName(Acme.MultiTenant.EFDAL.Entity.Project.FieldNameConstants field)
		{
			return GetDatabaseFieldName(field.ToString());
		}

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		internal static string GetDatabaseFieldName(string field)
		{
			switch (field)
			{
				case "Name": return "Name";
				case "ProjectId": return "ProjectId";
				case "ProjectTypeId": return "ProjectTypeId";
				case "CreatedBy": return "CreatedBy";
				case "CreatedDate": return "CreatedDate";
				case "ModifiedBy": return "ModifiedBy";
				case "ModifiedDate": return "ModifiedDate";
				case "Timestamp": return "Timestamp";
			}
			return string.Empty;
		}

		#endregion

		#region Auditing
		string Acme.MultiTenant.EFDAL.IAuditableSet.CreatedBy
		{
			set { this.CreatedBy = value; }
		}

		string Acme.MultiTenant.EFDAL.IAuditableSet.ModifiedBy
		{
			set { this.ModifiedBy = value; }
		}

		string Acme.MultiTenant.EFDAL.IAuditable.CreatedBy
		{
			get { return this.CreatedBy; }
		}

		System.DateTime? Acme.MultiTenant.EFDAL.IAuditable.CreatedDate
		{
			get { return this.CreatedDate; }
		}

		bool Acme.MultiTenant.EFDAL.IAuditable.IsCreateAuditImplemented
		{
			get { return true; }
		}

		bool Acme.MultiTenant.EFDAL.IAuditable.IsModifyAuditImplemented
		{
			get { return true; }
		}

		bool Acme.MultiTenant.EFDAL.IAuditable.IsTimestampAuditImplemented
		{
			get { return true; }
		}

		string Acme.MultiTenant.EFDAL.IAuditable.ModifiedBy
		{
			get { return this.ModifiedBy; }
		}

		System.DateTime? Acme.MultiTenant.EFDAL.IAuditable.ModifiedDate
		{
			get { return this.ModifiedDate; }
		}

		byte[] Acme.MultiTenant.EFDAL.IAuditable.TimeStamp
		{
			get { return this.Timestamp; }
		}

		System.DateTime Acme.MultiTenant.EFDAL.IAuditableSet.CreatedDate
		{
			set { this.CreatedDate = value; }
		}

		System.DateTime Acme.MultiTenant.EFDAL.IAuditableSet.ModifiedDate
		{
			set { this.ModifiedDate = value; }
		}

		#endregion

		#region Equals
		/// <summary>
		/// Compares two objects of 'Project' type and determines if all properties match
		/// </summary>
		/// <returns>True if all properties match, false otherwise</returns>
		public override bool Equals(object obj)
		{
			var other = obj as Acme.MultiTenant.EFDAL.Entity.Project;
			if (other == null) return false;
			return (
				other.Name == this.Name &&
				other.ProjectId == this.ProjectId &&
				other.ProjectTypeId == this.ProjectTypeId
				);
		}

		/// <summary>
		/// Serves as a hash function for this type.
		/// </summary>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#endregion

	}
}

#region Metadata Class

namespace Acme.MultiTenant.EFDAL.Entity.Metadata
{
	/// <summary>
	/// Metadata class for the 'Project' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	public partial class ProjectMetadata : Acme.MultiTenant.EFDAL.IMetadata
	{
		#region Properties

		/// <summary>
		/// Metadata information for the 'Name' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'Name' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.StringLength(50, ErrorMessage = "The property 'Name' has a maximum length of 50")]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "Name", AutoGenerateField = true)]
		public object Name;

		/// <summary>
		/// Metadata information for the 'ProjectId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'ProjectId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Key()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "ProjectId", AutoGenerateField = true)]
		public object ProjectId;

		/// <summary>
		/// Metadata information for the 'ProjectTypeId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'ProjectTypeId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "ProjectTypeId", AutoGenerateField = true)]
		public object ProjectTypeId;

		/// <summary>
		/// Metadata information for the 'CreatedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'CreatedBy' has a maximum length of 100")]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object CreatedBy;

		/// <summary>
		/// Metadata information for the 'CreatedDate' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object CreatedDate;

		/// <summary>
		/// Metadata information for the 'ModifiedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'ModifiedBy' has a maximum length of 100")]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object ModifiedBy;

		/// <summary>
		/// Metadata information for the 'ModifiedDate' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object ModifiedDate;

		/// <summary>
		/// Metadata information for the 'Timestamp' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Timestamp()]
		[System.ComponentModel.DataAnnotations.ConcurrencyCheck()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object Timestamp;

		#endregion

		#region Methods
		/// <summary />
		public virtual string GetTableName()
		{
			return "Project";
		}

		/// <summary>
		/// Gets a list of all object fields with alias/code facade applied excluding inheritance.
		/// </summary>
		public virtual List<string> GetFields()
		{
			var retval = new List<string>();
			retval.Add("Name");
			retval.Add("ProjectId");
			retval.Add("ProjectTypeId");
			return retval;
		}

		/// <summary>
		/// Returns the type of the parent object if one exists.
		/// </summary>
		public virtual System.Type InheritsFrom()
		{
			return null;
		}

		/// <summary>
		/// Returns the database schema name.
		/// </summary>
		public virtual string Schema()
		{
			return "dbo";
		}

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		public virtual string GetDatabaseFieldName(string field)
		{
			switch (field)
			{
				case "Name": return "Name";
				case "ProjectId": return "ProjectId";
				case "ProjectTypeId": return "ProjectTypeId";
				case "CreatedBy": return "CreatedBy";
				case "CreatedDate": return "CreatedDate";
				case "ModifiedBy": return "ModifiedBy";
				case "ModifiedDate": return "ModifiedDate";
				case "Timestamp": return "Timestamp";
			}
			return string.Empty;
		}

		#endregion

	}

}

#endregion

#pragma warning restore 612

