'Author: Bruce Brown
'Date: 2/10/2021
'Last Update: 3/4/2021
'Purpose: Manage the user information.

Option Strict On
Option Explicit On

Public Class User

    Private mstrFitnessID As String
    Private mstrName As String
    Private mstrAge As Integer
    Private mstrWeight As Double
    Private mstrHeight As Integer
    Private mstrGender As String
    Private mstrWaist As Double
    Private mstrWrist As Double
    Private mstrHip As Double
    Private mstrForearm As Double
    Private mstrRMR As Double
    Private mstrActivityRMR As Double
    Private mstrActivity As String
    Private mstrBodyFatPerc As Double

    Public Property FitnessID As String
        Get
            Return mstrFitnessID
        End Get
        Set(value As String)
            mstrFitnessID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return mstrAge
        End Get
        Set(value As Integer)
            mstrAge = value
        End Set
    End Property
    Public Property Weight As Double
        Get
            Return mstrWeight
        End Get
        Set(value As Double)
            mstrWeight = value
        End Set
    End Property

    Public Property Height As Integer
        Get
            Return mstrHeight
        End Get
        Set(value As Integer)
            mstrHeight = value
        End Set
    End Property
    Public Property Gender As String
        Get
            Return mstrGender
        End Get
        Set(value As String)
            mstrGender = value
        End Set
    End Property

    Public Property Waist As Double
        Get
            Return mstrWaist
        End Get
        Set(value As Double)
            mstrWaist = value
        End Set
    End Property

    Public Property Wrist As Double
        Get
            Return mstrWrist
        End Get
        Set(value As Double)
            mstrWrist = value
        End Set
    End Property

    Public Property Hip As Double
        Get
            Return mstrHip
        End Get
        Set(value As Double)
            mstrHip = value
        End Set
    End Property

    Public Property Forearm As Double
        Get
            Return mstrForearm
        End Get
        Set(value As Double)
            mstrForearm = value
        End Set
    End Property

    Public Property RMR As Double
        Get
            Return mstrRMR
        End Get
        Set(value As Double)
            mstrRMR = value
        End Set
    End Property
    Public Property ActivityRMR As Double
        Get
            Return mstrActivityRMR
        End Get
        Set(value As Double)
            mstrActivityRMR = value
        End Set
    End Property

    Public Property Activity As String
        Get
            Return mstrActivity
        End Get
        Set(value As String)
            mstrActivity = value
        End Set
    End Property
    Public Property BodyFatPerc As Double
        Get
            Return mstrBodyFatPerc
        End Get
        Set(value As Double)
            mstrBodyFatPerc = value
        End Set
    End Property

    'Default constructor
    Public Sub New()
        mstrFitnessID = String.Empty
        mstrName = String.Empty
        mstrAge = 0
        mstrWeight = 0.0
        mstrHeight = 0
        mstrGender = String.Empty
        mstrWaist = 0.0
        mstrWrist = 0.0
        mstrHip = 0.0
        mstrForearm = 0.0
        mstrRMR = 0.0
        mstrActivityRMR = 0.0
        mstrActivity = String.Empty
        mstrBodyFatPerc = 0.0
    End Sub

    'Overloaded Constructors
    Public Sub New(ByVal strID As String)
        mstrFitnessID = strID
        mstrName = String.Empty
        mstrAge = 0
        mstrWeight = 0.0
        mstrHeight = 0
        mstrGender = String.Empty
        mstrWaist = 0.0
        mstrWrist = 0.0
        mstrHip = 0.0
        mstrForearm = 0.0
        mstrRMR = 0.0
        mstrActivityRMR = 0.0
        mstrActivity = String.Empty
        mstrBodyFatPerc = 0.0
    End Sub

    Public Sub New(ByVal strName As String, ByVal strAge As Integer, ByVal strWeight As Double, ByVal strHeight As Integer, ByVal strGender As String, ByVal strActivity As String)
        mstrFitnessID = String.Empty
        mstrName = strName
        mstrAge = strAge
        mstrWeight = strWeight
        mstrHeight = strHeight
        mstrGender = strGender
        mstrWaist = 0.0
        mstrWrist = 0.0
        mstrHip = 0.0
        mstrForearm = 0.0
        mstrRMR = 0.0
        mstrActivityRMR = 0.0
        mstrActivity = strActivity
        mstrBodyFatPerc = 0.0
    End Sub

    Public Sub New(ByVal strID As String, ByVal strName As String, ByVal strAge As Integer, ByVal strWeight As Double, ByVal strHeight As Integer, ByVal strGender As String, ByVal strActivity As String)
        mstrFitnessID = strID
        mstrName = strName
        mstrAge = strAge
        mstrWeight = strWeight
        mstrHeight = strHeight
        mstrGender = strGender
        mstrWaist = 0.0
        mstrWrist = 0.0
        mstrHip = 0.0
        mstrForearm = 0.0
        mstrRMR = 0.0
        mstrActivityRMR = 0.0
        mstrActivity = strActivity
        mstrBodyFatPerc = 0.0
    End Sub

    Public Sub New(ByVal strName As String, ByVal strAge As Integer, ByVal strWeight As Double, ByVal strHeight As Integer, ByVal strGender As String, ByVal strActivity As String, ByVal strWaist As Double, ByVal strWrist As Double, ByVal strHip As Double, ByVal strForearm As Double)
        mstrFitnessID = String.Empty
        mstrName = strName
        mstrAge = strAge
        mstrWeight = strWeight
        mstrHeight = strHeight
        mstrGender = strGender
        mstrWaist = strWaist
        mstrWrist = strWrist
        mstrHip = strHip
        mstrForearm = strForearm
        mstrRMR = 0.0
        mstrActivityRMR = 0.0
        mstrActivity = strActivity
        mstrBodyFatPerc = 0.0
    End Sub

End Class
