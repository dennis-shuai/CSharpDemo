
// ClientDlg.h : ͷ�ļ�
//

#pragma once

#include <Winsock2.h>
#include "afxwin.h"
#pragma comment(lib,"Ws2_32.lib")
// CClientDlg �Ի���
class CClientDlg : public CDialogEx
{
// ����
public:
	CClientDlg(CWnd* pParent = NULL);	// ��׼���캯��
// �Ի�������
	enum { IDD = IDD_CLIENT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV ֧��


// ʵ��
protected:
	HICON m_hIcon;

	// ���ɵ���Ϣӳ�亯��
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
	void InitSocket();
	
public:
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButtonConnect();
	afx_msg void OnBnClickedButton3();
	SOCKET m_ClientSocket;

	CListBox m_ClientRecvListBox;
};
