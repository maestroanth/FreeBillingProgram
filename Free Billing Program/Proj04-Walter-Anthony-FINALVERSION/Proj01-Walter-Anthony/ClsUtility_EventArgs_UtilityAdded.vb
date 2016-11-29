'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Utility System
'File:               ClsUtility_EventArgs_UtilityAdded.vb
'Author:             Anthony Walter
'Description:        This class handles the Utility such as gas or electric
'Date:               3/5/2015
'Tier:               Business Logic
'Exceptions:         None generated
'Exception-Handling: None
'Events:             None generated
'Event-Handling:     Handles the adding of ClsUtility
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Utility_EventArgs_UtilityAdded
    Inherits System.EventArgs

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mUtility As Utility

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pUtility As Utility)

        'Special constructor

        'This constructor creates a new Utility System

        MyBase.New()

        _Utility = pUtility
    End Sub 'New(pCustomer)


    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property Utility As Utility
        Get
            Return _Utility
        End Get
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)


    Private Property _Utility As Utility
        Get
            Return mUtility
        End Get
        Set(pValue As Utility)
            mUtility = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods



    'Public Function value() As Decimal

    '    'value() calculates and returns the actual value of this
    '    'PortfolioItem: the current market price times the number of
    '    'shares owned.

    '    'We could have used this public function for this purpose, but
    '    'instead http://bizcast.business.colostate.edu/BizCast/Play/Javascript/Players/StandardPlayer/Themes/Mediasite/Images/CommandBar/btnPrevNormal.pngwe designed an equivalent private/public pair of property
    '    'procedures (above) and use them instead.

    '    'This is the public method; 
    '    'it depends on the private method to actually do the work.

    '    Return _value()

    'End Function 'value()

    Public Overrides Function ToString() As String

        'ToString() returns a string version of the object.
        'It is a standard method that should be provided for *all* classes.

        'This is the public method; 
        'it depends on the private method to actually do the work.

        Return _toString()

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods


    'Private Function _value() As Decimal

    '    '_value() calculates and returns the actual value of this
    '    'PortfolioItem: the current market price times the number of
    '    'shares owned.

    '    'We could have used this private function for this purpose, but
    '    'instead we designed an equivalent private/public pair of property
    '    'procedures (above) and use them instead.

    '    Return _stock.price * _numShares

    'End Function '_value()

    Private Function _toString() As String

        '_toString() returns a string version of the object.

        'This is the private method, that actually does the work.

        Dim tmpStr As String

        tmpStr = _
            "( Utility EVENTARGS: " _
            & "Utility =" & _Utility.ToString & ")"

        Return tmpStr

    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************
    'These are all public.

#End Region 'Events

End Class 'Utility_EventArgs