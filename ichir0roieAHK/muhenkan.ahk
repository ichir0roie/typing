;はコメントアウト。その行の;以降に書かれた文字を全て無視する。

;キーの指定方法のメモ
;　無変換キー	sc07B
;　SHIFT	+
;　Ctrl		^
;　Alt		!
;　;(セミコロン)vkBBsc027
;　:(コロン)	vkBAsc028
;　,(カンマ)	vkBCsc033
;　.(ピリオド)	vkBEsc034
;　Space	vk20sc039
;　その他はAutoHotKey Wikiのキーリスト参照


;無変換+右手に矢印キーなどを割り当て
sc07B & i:: Up  	;無変換 + i で ↑
sc07B & k:: Down	;無変換 + k で ↓
sc07B & j:: Left	;無変換 + j で ←
sc07B & l:: Right		;無変換 + l で →
sc07B & u:: Home	;無変換 + u で PgUp
sc07B & o:: End	;無変換 + o で PgDn
sc07B & m:: PgUp	;無変換 + , で Home
sc07B & .:: PgDn	;無変換 + . で End


sc07B & a:: Numpad0
sc07B & x:: Numpad1
sc07B & c:: Numpad2
sc07B & v:: Numpad3
sc07B & s:: Numpad4
sc07B & d:: Numpad5
sc07B & f:: Numpad6
sc07B & w:: Numpad7
sc07B & e:: Numpad8
sc07B & r:: Numpad9

Space::Shift
sc079::Space

sc070::BackSpace
AppsKey::Enter




sc03A::Tab
Tab::sc029
sc029::Esc
Esc::NumLock





