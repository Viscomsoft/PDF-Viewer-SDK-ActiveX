
// testPDFDlg.cpp : implementation file
//

#include "stdafx.h"
#include "testPDF.h"
#include "testPDFDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CtestPDFDlg dialog




CtestPDFDlg::CtestPDFDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CtestPDFDlg::IDD, pParent)
	, m_iCurPage(0)
	, m_iTotalPage(0)
	, m_strSearchText(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	m_iExportTextPage = 1;
}

void CtestPDFDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_PDFVIEWERCTRL1, m_PDFViewer);
	DDX_Control(pDX, IDC_CHECKBORDER, m_ChkBorder);
	DDX_Control(pDX, IDC_CBOEXPORTTEXT, m_CboExportText);
	DDX_Text(pDX, IDC_EDIT_EXPORTTEXT, m_iExportTextPage);
}

BEGIN_MESSAGE_MAP(CtestPDFDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BTN_OPEN, &CtestPDFDlg::OnBnClickedBtnOpen)
	ON_BN_CLICKED(IDC_BTN_BK_COLOR, &CtestPDFDlg::OnBnClickedBtnBkColor)
	ON_BN_CLICKED(IDC_BTN_ZOOM_IN, &CtestPDFDlg::OnBnClickedBtnZoomIn)
	ON_BN_CLICKED(IDC_BTN_ZOOM_OUT, &CtestPDFDlg::OnBnClickedBtnZoomOut)
	ON_BN_CLICKED(IDC_BTN_ORIGINAL_SIZE, &CtestPDFDlg::OnBnClickedBtnOriginalSize)
	ON_BN_CLICKED(IDC_BTN_SAVE_BITMAPS, &CtestPDFDlg::OnBnClickedBtnSaveBitmaps)
	ON_BN_CLICKED(IDC_BTN_PRINT, &CtestPDFDlg::OnBnClickedBtnPrint)
	ON_BN_CLICKED(IDC_BTN_PREV_PAGE, &CtestPDFDlg::OnBnClickedBtnPrevPage)
	ON_BN_CLICKED(IDC_BTN_NEXT_PAGE, &CtestPDFDlg::OnBnClickedBtnNextPage)
	ON_BN_CLICKED(IDC_BTN_SEARCH, &CtestPDFDlg::OnBnClickedBtnSearch)
	ON_BN_CLICKED(IDC_BTN_GO, &CtestPDFDlg::OnBnClickedBtnGo)
	ON_EN_CHANGE(IDC_EDT_SEARCH_TEXT, &CtestPDFDlg::OnEnChangeEdtSearchText)
	ON_WM_TIMER()
	ON_WM_DESTROY()
	ON_BN_CLICKED(IDC_BTN_PRINTPAGE, &CtestPDFDlg::OnBnClickedBtnPrintpage)
	ON_BN_CLICKED(IDC_RADIO1, &CtestPDFDlg::OnBnClickedRadio1)
	ON_BN_CLICKED(IDC_RADIO2, &CtestPDFDlg::OnBnClickedRadio2)
	ON_BN_CLICKED(IDC_RADIO3, &CtestPDFDlg::OnBnClickedRadio3)
	ON_BN_CLICKED(IDC_RADIO4, &CtestPDFDlg::OnBnClickedRadio4)
	ON_BN_CLICKED(IDC_RADIO5, &CtestPDFDlg::OnBnClickedRadio5)
	ON_BN_CLICKED(IDC_CHECKBORDER, &CtestPDFDlg::OnBnClickedCheckborder)
	ON_BN_CLICKED(IDC_BTNEXPORT, &CtestPDFDlg::OnBnClickedBtnexport)
END_MESSAGE_MAP()


// CtestPDFDlg message handlers

BOOL CtestPDFDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}
	((CButton*)GetDlgItem(IDC_RDO_DOWN))->SetCheck(1);
	GetDlgItem(IDC_BTN_PREV_PAGE)->EnableWindow(false);
	GetDlgItem(IDC_BTN_NEXT_PAGE)->EnableWindow(false);
	GetDlgItem(IDC_BTN_ZOOM_IN)->EnableWindow(false);
	GetDlgItem(IDC_BTN_ZOOM_OUT)->EnableWindow(false);
	GetDlgItem(IDC_BTN_ORIGINAL_SIZE)->EnableWindow(false);
	GetDlgItem(IDC_BTN_SAVE_BITMAPS)->EnableWindow(false);
	GetDlgItem(IDC_BTN_PRINT)->EnableWindow(false);
	GetDlgItem(IDC_BTN_SEARCH)->EnableWindow(false);
	GetDlgItem(IDC_BTN_GO)->EnableWindow(false);
	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	this->m_CboExportText.AddString(L"UTF8 Text File");
	this->m_CboExportText.AddString(L"XML File");
	this->m_CboExportText.AddString(L"HTML File");
	this->m_CboExportText.SetCurSel(0);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CtestPDFDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CtestPDFDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CtestPDFDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CtestPDFDlg::OnBnClickedBtnOpen()
{
	// TODO: Add your control notification handler code here
	CString strFilter = _T("PDF file(*.pdf) | *.pdf|All file (*.*) | *.*||");
	CString strPassword;
	CFileDialog dlg(TRUE,NULL,NULL,OFN_FILEMUSTEXIST,strFilter,this);

	if(dlg.DoModal()==IDOK)
	{

		GetDlgItemText(IDC_EDITPASSWORD,strPassword);
		m_PDFViewer.SetPassword(strPassword);
		if(m_PDFViewer.LoadPDFFile(dlg.GetPathName())<0)
		{
			AfxMessageBox(_T("Load file failed"));
			return;
		}

		if(m_PDFViewer.IsEncrypted() && strPassword.IsEmpty())
		{
			AfxMessageBox(_T("PDF file is protected, please input password"));
			return;
		}
		m_iCurPage = 1;
		m_iTotalPage = m_PDFViewer.GetTotalPage();
		PageFormat(m_iCurPage,m_iTotalPage);
		//GetDlgItem(IDC_BTN_PREV_PAGE)->EnableWindow(true);
		//GetDlgItem(IDC_BTN_NEXT_PAGE)->EnableWindow(true);
		GetDlgItem(IDC_BTN_ZOOM_IN)->EnableWindow(true);
		GetDlgItem(IDC_BTN_ZOOM_OUT)->EnableWindow(true);
		GetDlgItem(IDC_BTN_ORIGINAL_SIZE)->EnableWindow(true);
		GetDlgItem(IDC_BTN_SAVE_BITMAPS)->EnableWindow(true);
		GetDlgItem(IDC_BTN_PRINT)->EnableWindow(true);
		GetDlgItem(IDC_BTN_SEARCH)->EnableWindow(true);
		GetDlgItem(IDC_BTN_GO)->EnableWindow(true);
		SetTimer(1,100,NULL);
	}
}


void CtestPDFDlg::PageFormat(int iCurPage, int iTotalPage)
{
	CString strPage;   //Show Current page and Total page on the dialog
	strPage.Format(_T("%d/%d"),m_iCurPage,m_iTotalPage);
	GetDlgItem(IDC_STATIC_PAGE)->SetWindowText(strPage);
	GetDlgItem(IDC_STATIC_PAGE)->Invalidate();
}


void CtestPDFDlg::OnBnClickedBtnBkColor()
{
	// TODO: Add your control notification handler code here
	COLORREF clrBkColor;
	CColorDialog dlg;
		
	if(dlg.DoModal()==IDOK)
	{
		clrBkColor=dlg.GetColor();
		m_PDFViewer.SetBackgroudColor(clrBkColor);
	}
	
}


void CtestPDFDlg::OnBnClickedBtnZoomIn()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.PDFZoomIn();
}


void CtestPDFDlg::OnBnClickedBtnZoomOut()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.PDFZoomOut();

}


void CtestPDFDlg::OnBnClickedBtnOriginalSize()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.ShowOriginalSize();
}


void CtestPDFDlg::OnBnClickedBtnSaveBitmaps()
{
	// TODO: Add your control notification handler code here
	CString strFilter = _T("All file (*.*) | *.*||");
	
	CFileDialog dlg(FALSE,NULL,NULL,OFN_FILEMUSTEXIST,strFilter,this);
	if(dlg.DoModal()==IDOK)
	{
		m_PDFViewer.SaveBitmaps(dlg.GetPathName());
	}
}


void CtestPDFDlg::OnBnClickedBtnPrint()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.PrinterShowPrintDlg((long)this->m_hWnd);
	m_PDFViewer.PDFPrint();
}


void CtestPDFDlg::OnBnClickedBtnPrevPage()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.GoToPrevPage();
	if(m_iCurPage == 1)
	{
		m_iCurPage = 1;
	}
	else
	{
		m_iCurPage--;
	}
	PageFormat(m_iCurPage,m_iTotalPage);
}


void CtestPDFDlg::OnBnClickedBtnNextPage()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.GoToNextPage();
	if(m_iCurPage == m_iTotalPage)
	{
		m_iCurPage = m_iTotalPage;
	}
	else
	{
		m_iCurPage++;
	}
	PageFormat(m_iCurPage,m_iTotalPage);
}


void CtestPDFDlg::OnBnClickedBtnSearch()
{
	// TODO: Add your control notification handler code here
	if(((CButton*)GetDlgItem(IDC_RDO_UP))->GetCheck() == 1)
	{
		if(m_PDFViewer.SearchPrevText()<0)
		{
			AfxMessageBox(_T("Can't search the text"));
		}
	}
	if(((CButton*)GetDlgItem(IDC_RDO_DOWN))->GetCheck() == 1)
	{
		if(m_PDFViewer.SearchNextText()<0)
		{
			AfxMessageBox(_T("Can't search the text"));
		}
	}
}


void CtestPDFDlg::OnBnClickedBtnGo()
{
	// TODO: Add your control notification handler code here
	CString strPage;
	GetDlgItemText(IDC_EDT_PAGE,strPage);
	m_iCurPage = _ttoi(strPage);
	m_PDFViewer.GoToPage(m_iCurPage);
	PageFormat(m_iCurPage,m_iTotalPage);

}




void CtestPDFDlg::OnEnChangeEdtSearchText()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
	GetDlgItemText(IDC_EDT_SEARCH_TEXT,m_strSearchText);
	if(m_PDFViewer.Search(m_strSearchText,false)<0&&(!m_strSearchText.IsEmpty()))
	{
		AfxMessageBox(_T("Can't search the text"));
	}
}


void CtestPDFDlg::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: Add your message handler code here and/or call default
	if(nIDEvent == 1)
	{
		if(m_iCurPage == 1)
		{
			GetDlgItem(IDC_BTN_PREV_PAGE)->EnableWindow(false);			
		}
		else
		{
			GetDlgItem(IDC_BTN_PREV_PAGE)->EnableWindow(true);
		}
		if(m_iCurPage == m_iTotalPage)
		{
			GetDlgItem(IDC_BTN_NEXT_PAGE)->EnableWindow(false);
		}
		else
		{
			GetDlgItem(IDC_BTN_NEXT_PAGE)->EnableWindow(true);
		}
	}
	CDialogEx::OnTimer(nIDEvent);
}


void CtestPDFDlg::OnDestroy()
{
	CDialogEx::OnDestroy();
	KillTimer(1);
	// TODO: Add your message handler code here
}


void CtestPDFDlg::OnBnClickedBtnPrintpage()
{
	// TODO: Add your control notification handler code here
	CString strPageNo;

	m_PDFViewer.PrinterSetPrinterName(m_PDFViewer.PrinterGetDefaultPrinterName());	
	m_PDFViewer.PDFPrint();
}


void CtestPDFDlg::OnBnClickedRadio1()
{
	// TODO: Add your control notification handler code here

	m_PDFViewer.SetRotateAngle(90);

}


void CtestPDFDlg::OnBnClickedRadio2()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.SetRotateAngle(180);
}


void CtestPDFDlg::OnBnClickedRadio3()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.SetRotateAngle(270);
}


void CtestPDFDlg::OnBnClickedRadio4()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.SetRotateAngle(45);
}


void CtestPDFDlg::OnBnClickedRadio5()
{
	// TODO: Add your control notification handler code here
	m_PDFViewer.SetRotateAngle(0);
}


void CtestPDFDlg::OnBnClickedCheckborder()
{
	// TODO: Add your control notification handler code here
	if(m_ChkBorder.GetCheck()==1)
		m_PDFViewer.SetBorder(TRUE);
	else
		m_PDFViewer.SetBorder(FALSE);

}


void CtestPDFDlg::OnBnClickedBtnexport()
{
	// TODO: Add your control notification handler code here
	CString strFilter;
	CString strExt;
	UpdateData(TRUE);
	
	if(this->m_CboExportText.GetCurSel()==0)
	{
		strFilter = _T("Text file (*.txt) | *.txt||");
		strExt=".txt";
		
		
	}
	else if(this->m_CboExportText.GetCurSel()==1)
	{
		strFilter = _T("XML file (*.xml) | *.xml||");
		strExt=".xml";
	
	}
	else if(this->m_CboExportText.GetCurSel()==2)
	{
		strFilter = _T("HTML file (*.html) | *.html||");
		strExt=".html";
	}



	CFileDialog dlg(FALSE,NULL,strExt,OFN_FILEMUSTEXIST,strFilter,this);
	
	if(this->m_CboExportText.GetCurSel()==0)
		dlg.SetDefExt("txt");
	else if(this->m_CboExportText.GetCurSel()==1)
		dlg.SetDefExt("xml");
	else if(this->m_CboExportText.GetCurSel()==2)
		dlg.SetDefExt("html");

	if(dlg.DoModal()==IDOK)
	{
		
		m_PDFViewer.ExportText(dlg.GetPathName(),this->m_iExportTextPage,m_CboExportText.GetCurSel());
	}
}
