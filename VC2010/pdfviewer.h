#if !defined(AFX_PDFVIEWER_H__5B419C18_9277_411D_8743_B126DFC40417__INCLUDED_)
#define AFX_PDFVIEWER_H__5B419C18_9277_411D_8743_B126DFC40417__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.

/////////////////////////////////////////////////////////////////////////////
// CPDFViewer wrapper class

class CPDFViewer : public CWnd
{
protected:
	DECLARE_DYNCREATE(CPDFViewer)
public:
	CLSID const& GetClsid()
	{
		static CLSID const clsid
			= { 0xd4f80d00, 0x5f46, 0x4902, { 0x8a, 0xfc, 0xd0, 0x2, 0x69, 0x32, 0x3, 0x39 } };
		return clsid;
	}
	virtual BOOL Create(LPCTSTR lpszClassName,
		LPCTSTR lpszWindowName, DWORD dwStyle,
		const RECT& rect,
		CWnd* pParentWnd, UINT nID,
		CCreateContext* pContext = NULL)
	{ return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID); }

    BOOL Create(LPCTSTR lpszWindowName, DWORD dwStyle,
		const RECT& rect, CWnd* pParentWnd, UINT nID,
		CFile* pPersist = NULL, BOOL bStorage = FALSE,
		BSTR bstrLicKey = NULL)
	{ return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID,
		pPersist, bStorage, bstrLicKey); }

// Attributes
public:
	short GetTotalPage();
	void SetTotalPage(short);
	unsigned long GetBackgroudColor();
	void SetBackgroudColor(unsigned long);
	CString GetLicenseKey();
	void SetLicenseKey(LPCTSTR);
	float GetRotateAngle();
	void SetRotateAngle(float);
	CString GetPassword();
	void SetPassword(LPCTSTR);
	BOOL GetEnablePanning();
	void SetEnablePanning(BOOL);
	double GetZoom();
	void SetZoom(double);
	BOOL GetBorder();
	void SetBorder(BOOL);

// Operations
public:
	void AboutBox();
	short LoadPDFFile(LPCTSTR strPDFFile);
	void GoToPage(short iPage);
	void GoToNextPage();
	short SearchPrevText();
	short SearchNextText();
	void ShowOriginalSize();
	short SaveBitmaps(LPCTSTR strSaveFileName);
	void PDFZoomIn();
	void PDFZoomOut();
	void PDFPrint();
	void GoToPrevPage();
	void PDFClose();
	short Search(LPCTSTR strSearchText, BOOL bBackward);
	void FitHeight();
	void FitWidth();
	short PrinterCount();
	CString PrinterName(short iIndex);
	CString PrinterGetDefaultPrinterName();
	short PrinterGetPageCount();
	BOOL PrinterSetPageRange(short iFirstPage, short iLastPage);
	BOOL PrinterShowPageSetupDlg(long iOwnerHandle);
	BOOL PrinterSetPrinterName(LPCTSTR strPrinterName);
	BOOL PrinterShowPrintDlg(long iOwnerHandle);
	BOOL PrinterSetPageOrientation(short iMode);
	BOOL PrinterOpenPDF(LPCTSTR strFile);
	void PrinterClosePDF();
	void FitWindow();
	short SaveBitmapsBySize(LPCTSTR strSaveFileName, short iPageNo, double iScale);
	BOOL IsEncrypted();
	short UnicodeLoadPDFFile(BSTR* strPDFFile);
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PDFVIEWER_H__5B419C18_9277_411D_8743_B126DFC40417__INCLUDED_)
