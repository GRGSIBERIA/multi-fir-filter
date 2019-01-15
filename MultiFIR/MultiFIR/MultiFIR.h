
// MultiFIR.h : PROJECT_NAME アプリケーションのメイン ヘッダー ファイルです
//

#pragma once

#ifndef __AFXWIN_H__
	#error "PCH に対してこのファイルをインクルードする前に 'stdafx.h' をインクルードしてください"
#endif

#include "resource.h"		// メイン シンボル


// CMultiFIRApp:
// このクラスの実装については、MultiFIR.cpp を参照してください
//

class CMultiFIRApp : public CWinApp
{
public:
	CMultiFIRApp();

// オーバーライド
public:
	virtual BOOL InitInstance();

// 実装

	DECLARE_MESSAGE_MAP()
};

extern CMultiFIRApp theApp;
