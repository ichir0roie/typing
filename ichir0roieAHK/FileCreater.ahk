#IfWinActive, ahk_class CabinetWClass
    ^+f:: ;explorer - create new text file and open it with Notepad2
        #IfWinActive, ahk_class ExploreWClass
            ^+f:: ;explorer - create new text file and open it with Notepad2
                vPathNotepad2 := "C:\Program Files\Notepad\Notepad.exe"
                vNameNoExt := "new file"
                vDotExt := ""
                vPath := ""
                WinGet, hWnd, ID, A
                for oWin in ComObjCreate("Shell.Application").Windows
                {
                    if (oWin.HWND = hWnd)
                    {
                        vDir := RTrim(oWin.Document.Folder.Self.Path, "\")
                        ;if !DirExist(vDir)
                        if !InStr(FileExist(vDir), "D")
                        {
                            oWin := ""
                            return
                        }

                        Loop
                        {
                            vSfx := (A_Index=1) ? "" : " (" A_Index ")"
                            vName := vNameNoExt vSfx vDotExt
                            vPath := vDir "\" vName
                            if !FileExist(vPath)
                                break
                        }

                        ;create a blank text file (ANSI/UTF-8/UTF-16)
                        ;FileAppend,, % "*" vPath
                        FileAppend,, % "*" vPath, UTF-8
                        ;FileAppend,, % "*" vPath, UTF-16
                        break
                    }
                }
            return