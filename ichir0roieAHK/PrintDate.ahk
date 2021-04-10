::btw::by the way

2 & v::PrtDt("yyyy-")
2 & f::PrtDt("MM-dd")
2 & r::PrtDt("HH:mm")

2 & c::PrtDt("yyyy/")
2 & d::PrtDt("MM/dd")
2 & e::PrtDt("HH:mm")

PrtDt(txt)
{
    FormatTime, CurrentDateTime,, %txt%
    SendInput %CurrentDateTime%
}