#Include, IME.ahk

#IF IME_GET()==0

1::*
2::+
3::-
4::"
5::~
6::_
7::'
8::(
9::SendInput,{{}
0::[
-::$
^::SendInput, {`%}

sc073::SendInput, {:}

+2::SendInput,{`^}

+7::`
+8::)
+9::SendInput,{}}
+0::SendInput,]

[::@
]::#

+/::|
+`;::&

@::=
+@::!
+sc028::?

; 1::\
; 2::{
; 3::}
; 4::'
; 5::@
; 6::#
; 7::"
; 8::[
; 9::]
; 0::(
; -::)
; ^::*
; \::~
; [::-
; ]::+
; sc073::SendInput, {:}

; @::=

; +1::_
; +2::SendInput, {`%}
; +3::$
; +4::~
; +8::`
; +9::^
; +^::~
; +/::|
; +`;::&
; +@::!
; +sc028::?