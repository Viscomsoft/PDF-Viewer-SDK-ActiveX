VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Output folder"
   ClientHeight    =   4380
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   5775
   LinkTopic       =   "Form2"
   ScaleHeight     =   4380
   ScaleWidth      =   5775
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "OK"
      Height          =   495
      Left            =   4680
      TabIndex        =   1
      Top             =   360
      Width           =   975
   End
   Begin VB.DirListBox Dir1 
      Height          =   3870
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   4215
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Me.Hide
End Sub
