'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:N.N.NNNNN.N
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System

Namespace TestOutput
Public Class ExpressionsInCode
Public Sub New()
MyBase.New
End Sub
Public Overrides Sub Execute()

#ExternalSource("ExpressionsInCode.vbhtml",1)
     
    Dim foo As Object = Nothing
    Dim bar as String = "Foo"


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("ExpressionsInCode.vbhtml",6)
 If foo IsNot Nothing Then
    

#End ExternalSource

#ExternalSource("ExpressionsInCode.vbhtml",7)
Write(foo)


#End ExternalSource

#ExternalSource("ExpressionsInCode.vbhtml",7)
        
Else


#End ExternalSource
WriteLiteral("    ")

WriteLiteral("<p>Foo is Null!</p>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("ExpressionsInCode.vbhtml",10)
End If


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<p>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("ExpressionsInCode.vbhtml",13)
 If Not String.IsNullOrEmpty(bar) Then
    

#End ExternalSource

#ExternalSource("ExpressionsInCode.vbhtml",14)
Write(bar.Replace("F", "B"))


#End ExternalSource

#ExternalSource("ExpressionsInCode.vbhtml",14)
                            
End If


#End ExternalSource
WriteLiteral("</p>")

End Sub
End Class
End Namespace
