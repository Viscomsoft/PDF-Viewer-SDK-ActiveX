
// testPDFDlg.h : header file
//

#pragma once
#include "pdfviewer.h"


// CtestPDFDlg dialog
class CtestPDFDlg : public CDialogEx
{
// Construction
public:
	CtestPDFDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_TESTPDF_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedBtnOpen();
	CPDFViewer m_PDFViewer;
	void PageFormat(int iCurPage, int iTotalPage);
	int m_iCurPage;
	int m_iTotalPage;
	afx_msg void OnBnClickedBtnBkColor();
	afx_msg void OnBnClickedBtnZoomIn();
	afx_msg void OnBnClickedBtnZoomOut();
	afx_msg void OnBnClickedBtnOriginalSize();
	afx_msg void OnBnClickedBtnSaveBitmaps();
	afx_msg void OnBnClickedBtnPrint();
	afx_msg void OnBnClickedBtnPrevPage();
	afx_msg void OnBnClickedBtnNextPage();
	afx_msg void OnBnClickedBtnSearch();
	afx_msg void OnBnClickedBtnGo();
	CString m_strSearchText;
	afx_msg void OnEnChangeEdtSearchText();
	afx_msg void OnTimer(UINT_PTR nIDEvent);
	afx_msg void OnDestroy();
	afx_msg void OnBnClickedBtnPrintpage();
	afx_msg void OnBnClickedRadio1();
	afx_msg void OnBnClickedRadio2();
	afx_msg void OnBnClickedRadio3();
	afx_msg void OnBnClickedRadio4();
	afx_msg void OnBnClickedRadio5();
	CButton m_ChkBorder;
	afx_msg void OnBnClickedCheckborder();
};
