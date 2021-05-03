#Include IME.ahk

; sc07B::Shift
sc079::Space

Space::Shift
LShift::LCtrl
RShift::RCtrl

sc03A::Tab
Tab::sc029
sc029::Esc
Esc::NumLock

#Include, muhenkan.ahk

;use input mode,this is last
#Include DirectInput.ahk
#Include, PrintDate.ahk
#Include, PrintMaru.ahk
#Include, FileCreater.ahk
;#Include, ColemakBreak.ahk

