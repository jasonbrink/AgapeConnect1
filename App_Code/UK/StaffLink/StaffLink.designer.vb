﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1008
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace UK.StaffLink
	
	<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="AgapeConnect")>  _
	Partial Public Class StaffLinkDataContext
		Inherits System.Data.Linq.DataContext
		
		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertTab(instance As Tab)
    End Sub
    Partial Private Sub UpdateTab(instance As Tab)
    End Sub
    Partial Private Sub DeleteTab(instance As Tab)
    End Sub
    Partial Private Sub InsertAgape_Staff_Link(instance As Agape_Staff_Link)
    End Sub
    Partial Private Sub UpdateAgape_Staff_Link(instance As Agape_Staff_Link)
    End Sub
    Partial Private Sub DeleteAgape_Staff_Link(instance As Agape_Staff_Link)
    End Sub
    Partial Private Sub InsertAgape_Staff_Event(instance As Agape_Staff_Event)
    End Sub
    Partial Private Sub UpdateAgape_Staff_Event(instance As Agape_Staff_Event)
    End Sub
    Partial Private Sub DeleteAgape_Staff_Event(instance As Agape_Staff_Event)
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("SiteSqlServer").ConnectionString, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public ReadOnly Property Tabs() As System.Data.Linq.Table(Of Tab)
			Get
				Return Me.GetTable(Of Tab)
			End Get
		End Property
		
		Public ReadOnly Property Agape_Staff_Links() As System.Data.Linq.Table(Of Agape_Staff_Link)
			Get
				Return Me.GetTable(Of Agape_Staff_Link)
			End Get
		End Property
		
		Public ReadOnly Property Agape_Staff_Events() As System.Data.Linq.Table(Of Agape_Staff_Event)
			Get
				Return Me.GetTable(Of Agape_Staff_Event)
			End Get
		End Property
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Tabs")>  _
	Partial Public Class Tab
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _TabID As Integer
		
		Private _TabOrder As Integer
		
		Private _PortalID As System.Nullable(Of Integer)
		
		Private _TabName As String
		
		Private _IsVisible As Boolean
		
		Private _ParentId As System.Nullable(Of Integer)
		
		Private _IconFile As String
		
		Private _DisableLink As Boolean
		
		Private _Title As String
		
		Private _Description As String
		
		Private _KeyWords As String
		
		Private _IsDeleted As Boolean
		
		Private _Url As String
		
		Private _SkinSrc As String
		
		Private _ContainerSrc As String
		
		Private _StartDate As System.Nullable(Of Date)
		
		Private _EndDate As System.Nullable(Of Date)
		
		Private _RefreshInterval As System.Nullable(Of Integer)
		
		Private _PageHeadText As String
		
		Private _IsSecure As Boolean
		
		Private _PermanentRedirect As Boolean
		
		Private _SiteMapPriority As Double
		
		Private _CreatedByUserID As System.Nullable(Of Integer)
		
		Private _CreatedOnDate As System.Nullable(Of Date)
		
		Private _LastModifiedByUserID As System.Nullable(Of Integer)
		
		Private _LastModifiedOnDate As System.Nullable(Of Date)
		
		Private _IconFileLarge As String
		
		Private _CultureCode As String
		
		Private _ContentItemID As System.Nullable(Of Integer)
		
		Private _UniqueId As System.Guid
		
		Private _VersionGuid As System.Guid
		
		Private _DefaultLanguageGuid As System.Nullable(Of System.Guid)
		
		Private _LocalizedVersionGuid As System.Guid
		
		Private _Level As Integer
		
		Private _TabPath As String
		
		Private _Tabs As EntitySet(Of Tab)
		
		Private _Tab As EntityRef(Of Tab)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnTabIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnTabIDChanged()
    End Sub
    Partial Private Sub OnTabOrderChanging(value As Integer)
    End Sub
    Partial Private Sub OnTabOrderChanged()
    End Sub
    Partial Private Sub OnPortalIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPortalIDChanged()
    End Sub
    Partial Private Sub OnTabNameChanging(value As String)
    End Sub
    Partial Private Sub OnTabNameChanged()
    End Sub
    Partial Private Sub OnIsVisibleChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsVisibleChanged()
    End Sub
    Partial Private Sub OnParentIdChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnParentIdChanged()
    End Sub
    Partial Private Sub OnIconFileChanging(value As String)
    End Sub
    Partial Private Sub OnIconFileChanged()
    End Sub
    Partial Private Sub OnDisableLinkChanging(value As Boolean)
    End Sub
    Partial Private Sub OnDisableLinkChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
    Partial Private Sub OnKeyWordsChanging(value As String)
    End Sub
    Partial Private Sub OnKeyWordsChanged()
    End Sub
    Partial Private Sub OnIsDeletedChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsDeletedChanged()
    End Sub
    Partial Private Sub OnUrlChanging(value As String)
    End Sub
    Partial Private Sub OnUrlChanged()
    End Sub
    Partial Private Sub OnSkinSrcChanging(value As String)
    End Sub
    Partial Private Sub OnSkinSrcChanged()
    End Sub
    Partial Private Sub OnContainerSrcChanging(value As String)
    End Sub
    Partial Private Sub OnContainerSrcChanged()
    End Sub
    Partial Private Sub OnStartDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnStartDateChanged()
    End Sub
    Partial Private Sub OnEndDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnEndDateChanged()
    End Sub
    Partial Private Sub OnRefreshIntervalChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnRefreshIntervalChanged()
    End Sub
    Partial Private Sub OnPageHeadTextChanging(value As String)
    End Sub
    Partial Private Sub OnPageHeadTextChanged()
    End Sub
    Partial Private Sub OnIsSecureChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsSecureChanged()
    End Sub
    Partial Private Sub OnPermanentRedirectChanging(value As Boolean)
    End Sub
    Partial Private Sub OnPermanentRedirectChanged()
    End Sub
    Partial Private Sub OnSiteMapPriorityChanging(value As Double)
    End Sub
    Partial Private Sub OnSiteMapPriorityChanged()
    End Sub
    Partial Private Sub OnCreatedByUserIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnCreatedByUserIDChanged()
    End Sub
    Partial Private Sub OnCreatedOnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnCreatedOnDateChanged()
    End Sub
    Partial Private Sub OnLastModifiedByUserIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnLastModifiedByUserIDChanged()
    End Sub
    Partial Private Sub OnLastModifiedOnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnLastModifiedOnDateChanged()
    End Sub
    Partial Private Sub OnIconFileLargeChanging(value As String)
    End Sub
    Partial Private Sub OnIconFileLargeChanged()
    End Sub
    Partial Private Sub OnCultureCodeChanging(value As String)
    End Sub
    Partial Private Sub OnCultureCodeChanged()
    End Sub
    Partial Private Sub OnContentItemIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnContentItemIDChanged()
    End Sub
    Partial Private Sub OnUniqueIdChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnUniqueIdChanged()
    End Sub
    Partial Private Sub OnVersionGuidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnVersionGuidChanged()
    End Sub
    Partial Private Sub OnDefaultLanguageGuidChanging(value As System.Nullable(Of System.Guid))
    End Sub
    Partial Private Sub OnDefaultLanguageGuidChanged()
    End Sub
    Partial Private Sub OnLocalizedVersionGuidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnLocalizedVersionGuidChanged()
    End Sub
    Partial Private Sub OnLevelChanging(value As Integer)
    End Sub
    Partial Private Sub OnLevelChanged()
    End Sub
    Partial Private Sub OnTabPathChanging(value As String)
    End Sub
    Partial Private Sub OnTabPathChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._Tabs = New EntitySet(Of Tab)(AddressOf Me.attach_Tabs, AddressOf Me.detach_Tabs)
			Me._Tab = CType(Nothing, EntityRef(Of Tab))
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property TabID() As Integer
			Get
				Return Me._TabID
			End Get
			Set
				If ((Me._TabID = value)  _
							= false) Then
					Me.OnTabIDChanging(value)
					Me.SendPropertyChanging
					Me._TabID = value
					Me.SendPropertyChanged("TabID")
					Me.OnTabIDChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabOrder", DbType:="Int NOT NULL")>  _
		Public Property TabOrder() As Integer
			Get
				Return Me._TabOrder
			End Get
			Set
				If ((Me._TabOrder = value)  _
							= false) Then
					Me.OnTabOrderChanging(value)
					Me.SendPropertyChanging
					Me._TabOrder = value
					Me.SendPropertyChanged("TabOrder")
					Me.OnTabOrderChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalID", DbType:="Int")>  _
		Public Property PortalID() As System.Nullable(Of Integer)
			Get
				Return Me._PortalID
			End Get
			Set
				If (Me._PortalID.Equals(value) = false) Then
					Me.OnPortalIDChanging(value)
					Me.SendPropertyChanging
					Me._PortalID = value
					Me.SendPropertyChanged("PortalID")
					Me.OnPortalIDChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
		Public Property TabName() As String
			Get
				Return Me._TabName
			End Get
			Set
				If (String.Equals(Me._TabName, value) = false) Then
					Me.OnTabNameChanging(value)
					Me.SendPropertyChanging
					Me._TabName = value
					Me.SendPropertyChanged("TabName")
					Me.OnTabNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsVisible", DbType:="Bit NOT NULL")>  _
		Public Property IsVisible() As Boolean
			Get
				Return Me._IsVisible
			End Get
			Set
				If ((Me._IsVisible = value)  _
							= false) Then
					Me.OnIsVisibleChanging(value)
					Me.SendPropertyChanging
					Me._IsVisible = value
					Me.SendPropertyChanged("IsVisible")
					Me.OnIsVisibleChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ParentId", DbType:="Int")>  _
		Public Property ParentId() As System.Nullable(Of Integer)
			Get
				Return Me._ParentId
			End Get
			Set
				If (Me._ParentId.Equals(value) = false) Then
					If Me._Tab.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
					End If
					Me.OnParentIdChanging(value)
					Me.SendPropertyChanging
					Me._ParentId = value
					Me.SendPropertyChanged("ParentId")
					Me.OnParentIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IconFile", DbType:="NVarChar(100)")>  _
		Public Property IconFile() As String
			Get
				Return Me._IconFile
			End Get
			Set
				If (String.Equals(Me._IconFile, value) = false) Then
					Me.OnIconFileChanging(value)
					Me.SendPropertyChanging
					Me._IconFile = value
					Me.SendPropertyChanged("IconFile")
					Me.OnIconFileChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DisableLink", DbType:="Bit NOT NULL")>  _
		Public Property DisableLink() As Boolean
			Get
				Return Me._DisableLink
			End Get
			Set
				If ((Me._DisableLink = value)  _
							= false) Then
					Me.OnDisableLinkChanging(value)
					Me.SendPropertyChanging
					Me._DisableLink = value
					Me.SendPropertyChanged("DisableLink")
					Me.OnDisableLinkChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="NVarChar(200)")>  _
		Public Property Title() As String
			Get
				Return Me._Title
			End Get
			Set
				If (String.Equals(Me._Title, value) = false) Then
					Me.OnTitleChanging(value)
					Me.SendPropertyChanging
					Me._Title = value
					Me.SendPropertyChanged("Title")
					Me.OnTitleChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="NVarChar(500)")>  _
		Public Property Description() As String
			Get
				Return Me._Description
			End Get
			Set
				If (String.Equals(Me._Description, value) = false) Then
					Me.OnDescriptionChanging(value)
					Me.SendPropertyChanging
					Me._Description = value
					Me.SendPropertyChanged("Description")
					Me.OnDescriptionChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_KeyWords", DbType:="NVarChar(500)")>  _
		Public Property KeyWords() As String
			Get
				Return Me._KeyWords
			End Get
			Set
				If (String.Equals(Me._KeyWords, value) = false) Then
					Me.OnKeyWordsChanging(value)
					Me.SendPropertyChanging
					Me._KeyWords = value
					Me.SendPropertyChanged("KeyWords")
					Me.OnKeyWordsChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsDeleted", DbType:="Bit NOT NULL")>  _
		Public Property IsDeleted() As Boolean
			Get
				Return Me._IsDeleted
			End Get
			Set
				If ((Me._IsDeleted = value)  _
							= false) Then
					Me.OnIsDeletedChanging(value)
					Me.SendPropertyChanging
					Me._IsDeleted = value
					Me.SendPropertyChanged("IsDeleted")
					Me.OnIsDeletedChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Url", DbType:="NVarChar(255)")>  _
		Public Property Url() As String
			Get
				Return Me._Url
			End Get
			Set
				If (String.Equals(Me._Url, value) = false) Then
					Me.OnUrlChanging(value)
					Me.SendPropertyChanging
					Me._Url = value
					Me.SendPropertyChanged("Url")
					Me.OnUrlChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SkinSrc", DbType:="NVarChar(200)")>  _
		Public Property SkinSrc() As String
			Get
				Return Me._SkinSrc
			End Get
			Set
				If (String.Equals(Me._SkinSrc, value) = false) Then
					Me.OnSkinSrcChanging(value)
					Me.SendPropertyChanging
					Me._SkinSrc = value
					Me.SendPropertyChanged("SkinSrc")
					Me.OnSkinSrcChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContainerSrc", DbType:="NVarChar(200)")>  _
		Public Property ContainerSrc() As String
			Get
				Return Me._ContainerSrc
			End Get
			Set
				If (String.Equals(Me._ContainerSrc, value) = false) Then
					Me.OnContainerSrcChanging(value)
					Me.SendPropertyChanging
					Me._ContainerSrc = value
					Me.SendPropertyChanged("ContainerSrc")
					Me.OnContainerSrcChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartDate", DbType:="DateTime")>  _
		Public Property StartDate() As System.Nullable(Of Date)
			Get
				Return Me._StartDate
			End Get
			Set
				If (Me._StartDate.Equals(value) = false) Then
					Me.OnStartDateChanging(value)
					Me.SendPropertyChanging
					Me._StartDate = value
					Me.SendPropertyChanged("StartDate")
					Me.OnStartDateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndDate", DbType:="DateTime")>  _
		Public Property EndDate() As System.Nullable(Of Date)
			Get
				Return Me._EndDate
			End Get
			Set
				If (Me._EndDate.Equals(value) = false) Then
					Me.OnEndDateChanging(value)
					Me.SendPropertyChanging
					Me._EndDate = value
					Me.SendPropertyChanged("EndDate")
					Me.OnEndDateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RefreshInterval", DbType:="Int")>  _
		Public Property RefreshInterval() As System.Nullable(Of Integer)
			Get
				Return Me._RefreshInterval
			End Get
			Set
				If (Me._RefreshInterval.Equals(value) = false) Then
					Me.OnRefreshIntervalChanging(value)
					Me.SendPropertyChanging
					Me._RefreshInterval = value
					Me.SendPropertyChanged("RefreshInterval")
					Me.OnRefreshIntervalChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PageHeadText", DbType:="NVarChar(MAX)")>  _
		Public Property PageHeadText() As String
			Get
				Return Me._PageHeadText
			End Get
			Set
				If (String.Equals(Me._PageHeadText, value) = false) Then
					Me.OnPageHeadTextChanging(value)
					Me.SendPropertyChanging
					Me._PageHeadText = value
					Me.SendPropertyChanged("PageHeadText")
					Me.OnPageHeadTextChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsSecure", DbType:="Bit NOT NULL")>  _
		Public Property IsSecure() As Boolean
			Get
				Return Me._IsSecure
			End Get
			Set
				If ((Me._IsSecure = value)  _
							= false) Then
					Me.OnIsSecureChanging(value)
					Me.SendPropertyChanging
					Me._IsSecure = value
					Me.SendPropertyChanged("IsSecure")
					Me.OnIsSecureChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PermanentRedirect", DbType:="Bit NOT NULL")>  _
		Public Property PermanentRedirect() As Boolean
			Get
				Return Me._PermanentRedirect
			End Get
			Set
				If ((Me._PermanentRedirect = value)  _
							= false) Then
					Me.OnPermanentRedirectChanging(value)
					Me.SendPropertyChanging
					Me._PermanentRedirect = value
					Me.SendPropertyChanged("PermanentRedirect")
					Me.OnPermanentRedirectChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SiteMapPriority", DbType:="Float NOT NULL")>  _
		Public Property SiteMapPriority() As Double
			Get
				Return Me._SiteMapPriority
			End Get
			Set
				If ((Me._SiteMapPriority = value)  _
							= false) Then
					Me.OnSiteMapPriorityChanging(value)
					Me.SendPropertyChanging
					Me._SiteMapPriority = value
					Me.SendPropertyChanged("SiteMapPriority")
					Me.OnSiteMapPriorityChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreatedByUserID", DbType:="Int")>  _
		Public Property CreatedByUserID() As System.Nullable(Of Integer)
			Get
				Return Me._CreatedByUserID
			End Get
			Set
				If (Me._CreatedByUserID.Equals(value) = false) Then
					Me.OnCreatedByUserIDChanging(value)
					Me.SendPropertyChanging
					Me._CreatedByUserID = value
					Me.SendPropertyChanged("CreatedByUserID")
					Me.OnCreatedByUserIDChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreatedOnDate", DbType:="DateTime")>  _
		Public Property CreatedOnDate() As System.Nullable(Of Date)
			Get
				Return Me._CreatedOnDate
			End Get
			Set
				If (Me._CreatedOnDate.Equals(value) = false) Then
					Me.OnCreatedOnDateChanging(value)
					Me.SendPropertyChanging
					Me._CreatedOnDate = value
					Me.SendPropertyChanged("CreatedOnDate")
					Me.OnCreatedOnDateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastModifiedByUserID", DbType:="Int")>  _
		Public Property LastModifiedByUserID() As System.Nullable(Of Integer)
			Get
				Return Me._LastModifiedByUserID
			End Get
			Set
				If (Me._LastModifiedByUserID.Equals(value) = false) Then
					Me.OnLastModifiedByUserIDChanging(value)
					Me.SendPropertyChanging
					Me._LastModifiedByUserID = value
					Me.SendPropertyChanged("LastModifiedByUserID")
					Me.OnLastModifiedByUserIDChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastModifiedOnDate", DbType:="DateTime")>  _
		Public Property LastModifiedOnDate() As System.Nullable(Of Date)
			Get
				Return Me._LastModifiedOnDate
			End Get
			Set
				If (Me._LastModifiedOnDate.Equals(value) = false) Then
					Me.OnLastModifiedOnDateChanging(value)
					Me.SendPropertyChanging
					Me._LastModifiedOnDate = value
					Me.SendPropertyChanged("LastModifiedOnDate")
					Me.OnLastModifiedOnDateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IconFileLarge", DbType:="NVarChar(100)")>  _
		Public Property IconFileLarge() As String
			Get
				Return Me._IconFileLarge
			End Get
			Set
				If (String.Equals(Me._IconFileLarge, value) = false) Then
					Me.OnIconFileLargeChanging(value)
					Me.SendPropertyChanging
					Me._IconFileLarge = value
					Me.SendPropertyChanged("IconFileLarge")
					Me.OnIconFileLargeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CultureCode", DbType:="NVarChar(10)")>  _
		Public Property CultureCode() As String
			Get
				Return Me._CultureCode
			End Get
			Set
				If (String.Equals(Me._CultureCode, value) = false) Then
					Me.OnCultureCodeChanging(value)
					Me.SendPropertyChanging
					Me._CultureCode = value
					Me.SendPropertyChanged("CultureCode")
					Me.OnCultureCodeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContentItemID", DbType:="Int")>  _
		Public Property ContentItemID() As System.Nullable(Of Integer)
			Get
				Return Me._ContentItemID
			End Get
			Set
				If (Me._ContentItemID.Equals(value) = false) Then
					Me.OnContentItemIDChanging(value)
					Me.SendPropertyChanging
					Me._ContentItemID = value
					Me.SendPropertyChanged("ContentItemID")
					Me.OnContentItemIDChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UniqueId", DbType:="UniqueIdentifier NOT NULL")>  _
		Public Property UniqueId() As System.Guid
			Get
				Return Me._UniqueId
			End Get
			Set
				If ((Me._UniqueId = value)  _
							= false) Then
					Me.OnUniqueIdChanging(value)
					Me.SendPropertyChanging
					Me._UniqueId = value
					Me.SendPropertyChanged("UniqueId")
					Me.OnUniqueIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VersionGuid", DbType:="UniqueIdentifier NOT NULL")>  _
		Public Property VersionGuid() As System.Guid
			Get
				Return Me._VersionGuid
			End Get
			Set
				If ((Me._VersionGuid = value)  _
							= false) Then
					Me.OnVersionGuidChanging(value)
					Me.SendPropertyChanging
					Me._VersionGuid = value
					Me.SendPropertyChanged("VersionGuid")
					Me.OnVersionGuidChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DefaultLanguageGuid", DbType:="UniqueIdentifier")>  _
		Public Property DefaultLanguageGuid() As System.Nullable(Of System.Guid)
			Get
				Return Me._DefaultLanguageGuid
			End Get
			Set
				If (Me._DefaultLanguageGuid.Equals(value) = false) Then
					Me.OnDefaultLanguageGuidChanging(value)
					Me.SendPropertyChanging
					Me._DefaultLanguageGuid = value
					Me.SendPropertyChanged("DefaultLanguageGuid")
					Me.OnDefaultLanguageGuidChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LocalizedVersionGuid", DbType:="UniqueIdentifier NOT NULL")>  _
		Public Property LocalizedVersionGuid() As System.Guid
			Get
				Return Me._LocalizedVersionGuid
			End Get
			Set
				If ((Me._LocalizedVersionGuid = value)  _
							= false) Then
					Me.OnLocalizedVersionGuidChanging(value)
					Me.SendPropertyChanging
					Me._LocalizedVersionGuid = value
					Me.SendPropertyChanged("LocalizedVersionGuid")
					Me.OnLocalizedVersionGuidChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Level]", Storage:="_Level", DbType:="Int NOT NULL")>  _
		Public Property Level() As Integer
			Get
				Return Me._Level
			End Get
			Set
				If ((Me._Level = value)  _
							= false) Then
					Me.OnLevelChanging(value)
					Me.SendPropertyChanging
					Me._Level = value
					Me.SendPropertyChanged("Level")
					Me.OnLevelChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabPath", DbType:="NVarChar(255) NOT NULL", CanBeNull:=false)>  _
		Public Property TabPath() As String
			Get
				Return Me._TabPath
			End Get
			Set
				If (String.Equals(Me._TabPath, value) = false) Then
					Me.OnTabPathChanging(value)
					Me.SendPropertyChanging
					Me._TabPath = value
					Me.SendPropertyChanged("TabPath")
					Me.OnTabPathChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Tab_Tab", Storage:="_Tabs", ThisKey:="TabID", OtherKey:="ParentId")>  _
		Public Property Tabs() As EntitySet(Of Tab)
			Get
				Return Me._Tabs
			End Get
			Set
				Me._Tabs.Assign(value)
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Tab_Tab", Storage:="_Tab", ThisKey:="ParentId", OtherKey:="TabID", IsForeignKey:=true)>  _
		Public Property Tab() As Tab
			Get
				Return Me._Tab.Entity
			End Get
			Set
				Dim previousValue As Tab = Me._Tab.Entity
				If ((Object.Equals(previousValue, value) = false)  _
							OrElse (Me._Tab.HasLoadedOrAssignedValue = false)) Then
					Me.SendPropertyChanging
					If ((previousValue Is Nothing)  _
								= false) Then
						Me._Tab.Entity = Nothing
						previousValue.Tabs.Remove(Me)
					End If
					Me._Tab.Entity = value
					If ((value Is Nothing)  _
								= false) Then
						value.Tabs.Add(Me)
						Me._ParentId = value.TabID
					Else
						Me._ParentId = CType(Nothing, Nullable(Of Integer))
					End If
					Me.SendPropertyChanged("Tab")
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		Private Sub attach_Tabs(ByVal entity As Tab)
			Me.SendPropertyChanging
			entity.Tab = Me
		End Sub
		
		Private Sub detach_Tabs(ByVal entity As Tab)
			Me.SendPropertyChanging
			entity.Tab = Nothing
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Agape_Staff_Link")>  _
	Partial Public Class Agape_Staff_Link
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _StaffLinkId As Integer
		
		Private _SortOrder As System.Nullable(Of Short)
		
		Private _LinkName As String
		
		Private _LinkURL As String
		
		Private _NewWindow As System.Nullable(Of Boolean)
		
		Private _TabId As System.Nullable(Of Integer)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnStaffLinkIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnStaffLinkIdChanged()
    End Sub
    Partial Private Sub OnSortOrderChanging(value As System.Nullable(Of Short))
    End Sub
    Partial Private Sub OnSortOrderChanged()
    End Sub
    Partial Private Sub OnLinkNameChanging(value As String)
    End Sub
    Partial Private Sub OnLinkNameChanged()
    End Sub
    Partial Private Sub OnLinkURLChanging(value As String)
    End Sub
    Partial Private Sub OnLinkURLChanged()
    End Sub
    Partial Private Sub OnNewWindowChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnNewWindowChanged()
    End Sub
    Partial Private Sub OnTabIdChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnTabIdChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StaffLinkId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property StaffLinkId() As Integer
			Get
				Return Me._StaffLinkId
			End Get
			Set
				If ((Me._StaffLinkId = value)  _
							= false) Then
					Me.OnStaffLinkIdChanging(value)
					Me.SendPropertyChanging
					Me._StaffLinkId = value
					Me.SendPropertyChanged("StaffLinkId")
					Me.OnStaffLinkIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SortOrder", DbType:="SmallInt")>  _
		Public Property SortOrder() As System.Nullable(Of Short)
			Get
				Return Me._SortOrder
			End Get
			Set
				If (Me._SortOrder.Equals(value) = false) Then
					Me.OnSortOrderChanging(value)
					Me.SendPropertyChanging
					Me._SortOrder = value
					Me.SendPropertyChanged("SortOrder")
					Me.OnSortOrderChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LinkName", DbType:="NVarChar(400)")>  _
		Public Property LinkName() As String
			Get
				Return Me._LinkName
			End Get
			Set
				If (String.Equals(Me._LinkName, value) = false) Then
					Me.OnLinkNameChanging(value)
					Me.SendPropertyChanging
					Me._LinkName = value
					Me.SendPropertyChanged("LinkName")
					Me.OnLinkNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LinkURL", DbType:="NVarChar(400)")>  _
		Public Property LinkURL() As String
			Get
				Return Me._LinkURL
			End Get
			Set
				If (String.Equals(Me._LinkURL, value) = false) Then
					Me.OnLinkURLChanging(value)
					Me.SendPropertyChanging
					Me._LinkURL = value
					Me.SendPropertyChanged("LinkURL")
					Me.OnLinkURLChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NewWindow", DbType:="Bit")>  _
		Public Property NewWindow() As System.Nullable(Of Boolean)
			Get
				Return Me._NewWindow
			End Get
			Set
				If (Me._NewWindow.Equals(value) = false) Then
					Me.OnNewWindowChanging(value)
					Me.SendPropertyChanging
					Me._NewWindow = value
					Me.SendPropertyChanged("NewWindow")
					Me.OnNewWindowChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabId", DbType:="Int")>  _
		Public Property TabId() As System.Nullable(Of Integer)
			Get
				Return Me._TabId
			End Get
			Set
				If (Me._TabId.Equals(value) = false) Then
					Me.OnTabIdChanging(value)
					Me.SendPropertyChanging
					Me._TabId = value
					Me.SendPropertyChanged("TabId")
					Me.OnTabIdChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Agape_Staff_Event")>  _
	Partial Public Class Agape_Staff_Event
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _EventId As Integer
		
		Private _EventName As String
		
		Private _EventDate As String
		
		Private _EventLocation As String
		
		Private _SortOrder As System.Nullable(Of Short)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnEventIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnEventIdChanged()
    End Sub
    Partial Private Sub OnEventNameChanging(value As String)
    End Sub
    Partial Private Sub OnEventNameChanged()
    End Sub
    Partial Private Sub OnEventDateChanging(value As String)
    End Sub
    Partial Private Sub OnEventDateChanged()
    End Sub
    Partial Private Sub OnEventLocationChanging(value As String)
    End Sub
    Partial Private Sub OnEventLocationChanged()
    End Sub
    Partial Private Sub OnSortOrderChanging(value As System.Nullable(Of Short))
    End Sub
    Partial Private Sub OnSortOrderChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EventId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property EventId() As Integer
			Get
				Return Me._EventId
			End Get
			Set
				If ((Me._EventId = value)  _
							= false) Then
					Me.OnEventIdChanging(value)
					Me.SendPropertyChanging
					Me._EventId = value
					Me.SendPropertyChanged("EventId")
					Me.OnEventIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EventName", DbType:="NVarChar(400)")>  _
		Public Property EventName() As String
			Get
				Return Me._EventName
			End Get
			Set
				If (String.Equals(Me._EventName, value) = false) Then
					Me.OnEventNameChanging(value)
					Me.SendPropertyChanging
					Me._EventName = value
					Me.SendPropertyChanged("EventName")
					Me.OnEventNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EventDate", DbType:="NVarChar(200)")>  _
		Public Property EventDate() As String
			Get
				Return Me._EventDate
			End Get
			Set
				If (String.Equals(Me._EventDate, value) = false) Then
					Me.OnEventDateChanging(value)
					Me.SendPropertyChanging
					Me._EventDate = value
					Me.SendPropertyChanged("EventDate")
					Me.OnEventDateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EventLocation", DbType:="NVarChar(200)")>  _
		Public Property EventLocation() As String
			Get
				Return Me._EventLocation
			End Get
			Set
				If (String.Equals(Me._EventLocation, value) = false) Then
					Me.OnEventLocationChanging(value)
					Me.SendPropertyChanging
					Me._EventLocation = value
					Me.SendPropertyChanged("EventLocation")
					Me.OnEventLocationChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SortOrder", DbType:="SmallInt")>  _
		Public Property SortOrder() As System.Nullable(Of Short)
			Get
				Return Me._SortOrder
			End Get
			Set
				If (Me._SortOrder.Equals(value) = false) Then
					Me.OnSortOrderChanging(value)
					Me.SendPropertyChanging
					Me._SortOrder = value
					Me.SendPropertyChanged("SortOrder")
					Me.OnSortOrderChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace
