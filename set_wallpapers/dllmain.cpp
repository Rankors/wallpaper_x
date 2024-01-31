#include <Windows.h>
#include "pch.h"
#include <iostream>
#define _UNICODE
HWND wallpaper = NULL;
bool set_wallpapers(HWND hwnd);

extern "C" __declspec(dllexport) bool set(HWND hwnd)
{
	if (hwnd)
	{
		if (set_wallpapers(hwnd))
		{
			return true;
		}
	}
	return false;
}

HWND get_wallpaper() {
	HWND progman = FindWindow(L"Progman", NULL);
	SendMessageTimeout(progman, 0x052C, 0, 0, 0x0000, 1000, nullptr);
	EnumWindows([](HWND hwnd, LPARAM lparam) -> BOOL CALLBACK
		{
			HWND p = FindWindowEx(hwnd, NULL, L"SHELLDLL_DefView", NULL);
	if (p)
	{
		wallpaper = FindWindowEx(NULL, hwnd, L"WorkerW", NULL);
	}
	return true;
		}, NULL
	);
	return wallpaper;
}

bool set_wallpapers(HWND hwnd)
{
	HWND desktop = get_wallpaper();
	if (desktop)
	{
		SetParent(hwnd, desktop);
		if (SetParent(hwnd, desktop))
		{
			return true;
		}
	}
	return false;
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

