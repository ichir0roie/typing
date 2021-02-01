::btw::by the way

2 & c::PrtDt("yyyy/")
2 & d::PrtDt("MM/dd")
2 & e::PrtDt("HH:mm")
2 & r::PrtDt("HH")
2 & t:: SendInput, 00
2 & f:: SendInput, {:}
2 & g:: SendInput, 30
PrtDt(txt)
{
    FormatTime, CurrentDateTime,, %txt%
    SendInput %CurrentDateTime%
}