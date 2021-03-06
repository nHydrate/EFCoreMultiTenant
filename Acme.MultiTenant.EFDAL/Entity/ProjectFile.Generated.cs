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
	/// The 'ProjectFile' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	[FieldNameConstants(typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))]
	[EntityMetadata("ProjectFile", false,true, true, true, "", true, false, false, "dbo")]
	[MetadataTypeAttribute(typeof(Acme.MultiTenant.EFDAL.Entity.Metadata.ProjectFileMetadata))]
	[TenantEntity]
	public partial class ProjectFile : BaseEntity, Acme.MultiTenant.EFDAL.IBusinessObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ICloneable, Acme.MultiTenant.EFDAL.IAuditable, Acme.MultiTenant.EFDAL.IAuditableSet, Acme.MultiTenant.EFDAL.ICreatable
	{
		#region FieldNameConstants Enumeration

		/// <summary>
		/// Enumeration to define each property that maps to a database field for the 'ProjectFile' table.
		/// </summary>
		public enum FieldNameConstants
		{
			/// <summary>
			/// Field mapping for the 'FileName' property
			/// </summary>
			FileName,
			/// <summary>
			/// Field mapping for the 'ProjectFileId' property
			/// </summary>
			[System.ComponentModel.DataAnnotations.Key]
			[System.ComponentModel.DataAnnotations.Editable(false)]
			ProjectFileId,
			/// <summary>
			/// Field mapping for the 'ProjectId' property
			/// </summary>
			ProjectId,
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
		/// Initializes a new instance of the ProjectFile entity
		/// </summary>
		public ProjectFile()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// The property that maps back to the database 'ProjectFile.FileName' field.
		/// </summary>
		/// <remarks>Field: [ProjectFile].[FileName], Field Length: 450, Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "FileName")]
		[System.ComponentModel.DataAnnotations.StringLength(450)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string FileName
		{
			get { return _fileName; }
			set
			{
				if ((value != null) && (value.Length > GetMaxLength(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName))) throw new Exception(string.Format(GlobalValues.ERROR_DATA_TOO_BIG, value, "ProjectFile.FileName", GetMaxLength(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName)));
				if (value == _fileName) return;
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>(value, "FileName");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_fileName = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("FileName"));
			}
		}

		/// <summary>
		/// The property that maps back to the database 'ProjectFile.ProjectFileId' field.
		/// </summary>
		/// <remarks>Field: [ProjectFile].[ProjectFileId], Not Nullable, Primary Key, AutoNumber, Unique, Indexed</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "ProjectFileId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int ProjectFileId
		{
			get { return _projectFileId; }
			protected internal set
			{
				if (value == _projectFileId) return;
				var eventArg = new Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>(value, "ProjectFileId");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_projectFileId = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ProjectFileId"));
			}
		}

		/// <summary>
		/// The property that maps back to the database 'ProjectFile.ProjectId' field.
		/// </summary>
		/// <remarks>Field: [ProjectFile].[ProjectId], Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "ProjectId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int ProjectId
		{
			get { return _projectId; }
			set
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
		protected string _fileName;
		/// <summary>
		/// Occurs when the 'FileName' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string>> FileNameChanging;

		/// <summary>
		/// Raises the OnFileNameChanging event.
		/// </summary>
		protected virtual void OnFileNameChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.FileNameChanging != null)
				this.FileNameChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'FileName' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> FileNameChanged;

		/// <summary>
		/// Raises the OnFileNameChanged event.
		/// </summary>
		protected virtual void OnFileNameChanged(ChangedEventArgs<string> e)
		{
			if (this.FileNameChanged != null)
				this.FileNameChanged(this, e);
		}

		/// <summary />
		protected int _projectFileId;
		/// <summary>
		/// Occurs when the 'ProjectFileId' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int>> ProjectFileIdChanging;

		/// <summary>
		/// Raises the OnProjectFileIdChanging event.
		/// </summary>
		protected virtual void OnProjectFileIdChanging(Acme.MultiTenant.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.ProjectFileIdChanging != null)
				this.ProjectFileIdChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ProjectFileId' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> ProjectFileIdChanged;

		/// <summary>
		/// Raises the OnProjectFileIdChanged event.
		/// </summary>
		protected virtual void OnProjectFileIdChanged(ChangedEventArgs<int> e)
		{
			if (this.ProjectFileIdChanged != null)
				this.ProjectFileIdChanged(this, e);
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
		public static int GetMaxLength(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field)
		{
			switch (field)
			{
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName:
					return 450;
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectFileId:
					return 0; //Type=Int
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectId:
					return 0; //Type=Int
			}
			return 0;
		}

		int Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetMaxLength(Enum field)
		{
			return GetMaxLength((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field);
		}

		#endregion

		#region GetFieldNameConstants

		System.Type Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetFieldNameConstants()
		{
			return typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants);
		}

		#endregion

		#region GetFieldType

		/// <summary>
		/// Gets the system type of a field on this object
		/// </summary>
		public static System.Type GetFieldType(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants'.");

			switch ((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field)
			{
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName: return typeof(string);
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectFileId: return typeof(int);
				case Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectId: return typeof(int);
			}
			return null;
		}

		System.Type Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetFieldType(Enum field)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants'.");

			return GetFieldType((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field);
		}

		#endregion

		#region Get/Set Value

		object Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field)
		{
			return ((Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject)this).GetValue(field, null);
		}

		object Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field, object defaultValue)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants'.");
			return this.GetValue((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field, defaultValue);
		}

		void Acme.MultiTenant.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants'.");
			this.SetValue((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field, newValue);
		}

		void Acme.MultiTenant.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue, bool fixLength)
		{
			if (field.GetType() != typeof(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants'.");
			this.SetValue((Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants)field, newValue, fixLength);
		}

		#endregion

		#region PrimaryKey

		/// <summary>
		/// Generic primary key for this object
		/// </summary>
		Acme.MultiTenant.EFDAL.IPrimaryKey Acme.MultiTenant.EFDAL.IReadOnlyBusinessObject.PrimaryKey
		{
			get { return new PrimaryKey(Util.HashPK("ProjectFile", this.ProjectFileId)); }
		}

		#endregion

		#region Clone

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public virtual object Clone()
		{
			return Acme.MultiTenant.EFDAL.Entity.ProjectFile.Clone(this);
		}

		/// <summary>
		/// Creates a shallow copy of this object with defined, default values and new PK
		/// </summary>
		public virtual object CloneAsNew()
		{
			var item = Acme.MultiTenant.EFDAL.Entity.ProjectFile.Clone(this);
			item._projectFileId = 0;
			return item;
		}

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public static ProjectFile Clone(Acme.MultiTenant.EFDAL.Entity.ProjectFile item)
		{
			var newItem = new ProjectFile();
			newItem.FileName = item.FileName;
			newItem.ProjectFileId = item.ProjectFileId;
			newItem.ProjectId = item.ProjectId;
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
		public virtual object GetValue(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field)
		{
			return GetValue(field, null);
		}

		/// <summary>
		/// Gets the value of one of this object's properties.
		/// </summary>
		public virtual object GetValue(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field, object defaultValue)
		{
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName)
				return this.FileName;
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectFileId)
				return this.ProjectFileId;
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectId)
				return this.ProjectId;
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.CreatedBy)
				return ((this.CreatedBy == null) ? defaultValue : this.CreatedBy);
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.CreatedDate)
				return ((this.CreatedDate == null) ? defaultValue : this.CreatedDate);
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ModifiedBy)
				return ((this.ModifiedBy == null) ? defaultValue : this.ModifiedBy);
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ModifiedDate)
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
		public virtual void SetValue(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field, object newValue)
		{
			SetValue(field, newValue, false);
		}

		/// <summary>
		/// Assigns a value to a field on this object.
		/// </summary>
		/// <param name="field">The field to set</param>
		/// <param name="newValue">The new value to assign to the field</param>
		/// <param name="fixLength">Determines if the length should be truncated if too long. When false, an error will be raised if data is too large to be assigned to the field.</param>
		public virtual void SetValue(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field, object newValue, bool fixLength)
		{
			if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.FileName)
			{
				this.FileName = GlobalValues.SetValueHelperInternal((string)newValue, fixLength, GetMaxLength(field));
			}
			else if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectFileId)
			{
				throw new Exception("Field '" + field.ToString() + "' is a primary key and cannot be set!");
			}
			else if (field == Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants.ProjectId)
			{
				this.ProjectId = GlobalValues.SetValueHelperIntNotNullableInternal(newValue, "Field 'ProjectId' does not allow null values!");
			}
			else
				throw new Exception("Field '" + field.ToString() + "' not found!");
		}

		#endregion

		#region Navigation Properties

		/// <summary>
		/// The navigation definition for walking Project->ProjectFile
		/// </summary>
		public virtual Project Project { get; set; }

		#endregion

		#region GetDatabaseFieldName

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		internal static string GetDatabaseFieldName(Acme.MultiTenant.EFDAL.Entity.ProjectFile.FieldNameConstants field)
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
				case "FileName": return "FileName";
				case "ProjectFileId": return "ProjectFileId";
				case "ProjectId": return "ProjectId";
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
		/// Compares two objects of 'ProjectFile' type and determines if all properties match
		/// </summary>
		/// <returns>True if all properties match, false otherwise</returns>
		public override bool Equals(object obj)
		{
			var other = obj as Acme.MultiTenant.EFDAL.Entity.ProjectFile;
			if (other == null) return false;
			return (
				other.FileName == this.FileName &&
				other.ProjectFileId == this.ProjectFileId &&
				other.ProjectId == this.ProjectId
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
	/// Metadata class for the 'ProjectFile' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	public partial class ProjectFileMetadata : Acme.MultiTenant.EFDAL.IMetadata
	{
		#region Properties

		/// <summary>
		/// Metadata information for the 'FileName' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'FileName' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.StringLength(450, ErrorMessage = "The property 'FileName' has a maximum length of 450")]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "FileName", AutoGenerateField = true)]
		public object FileName;

		/// <summary>
		/// Metadata information for the 'ProjectFileId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'ProjectFileId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Key()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "ProjectFileId", AutoGenerateField = true)]
		public object ProjectFileId;

		/// <summary>
		/// Metadata information for the 'ProjectId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'ProjectId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "ProjectId", AutoGenerateField = true)]
		public object ProjectId;

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
			return "ProjectFile";
		}

		/// <summary>
		/// Gets a list of all object fields with alias/code facade applied excluding inheritance.
		/// </summary>
		public virtual List<string> GetFields()
		{
			var retval = new List<string>();
			retval.Add("FileName");
			retval.Add("ProjectFileId");
			retval.Add("ProjectId");
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
				case "FileName": return "FileName";
				case "ProjectFileId": return "ProjectFileId";
				case "ProjectId": return "ProjectId";
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

