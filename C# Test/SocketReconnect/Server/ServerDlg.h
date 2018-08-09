
// ServerDlg.h : ͷ�ļ�
//

#pragma once

#include "afxwin.h"
#include <Winsock2.h>
#pragma comment(lib,"Ws2_32.lib")

// CServerDlg �Ի���
struct CClientInfo
{
	SOCKET sSocket;
	CString strIp;
	u_short nPort;
	CString GetShowText();
};

class CServerDlg : public CDialogEx
{
// ����
public:
	CServerDlg(CWnd* pParent = NULL);	// ��׼���캯��
	~CServerDlg();
// �Ի�������
	enum { IDD = IDD_SERVER_DIALOG };

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

	
public:
	afx_msg void OnBnClickedButton1();
	void InitSocket();
	SOCKET m_ServerSocket;
	void OnSocketConnected(SOCKET sClientSocket,sockaddr_in * saClient);
	void OnSocketDisconnect(SOCKET aClientSocket);
	CListBox m_ClientListBox;
	CArray<CClientInfo> m_ClientArray;
	CListBox m_RecvMsgListBox;
	CRITICAL_SECTION m_CS_ClientArray;
	void LockClientArray(){EnterCriticalSection(&m_CS_ClientArray);}
	void UnLockClientArray(){LeaveCriticalSection(&m_CS_ClientArray);}
	afx_msg void OnBnClickedButton3();
};
