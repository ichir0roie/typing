with open("inputs/KC", mode="r", encoding="utf-8")as f:
    keys=f.read().splitlines()

text=""

buf=[]
for t in keys:
    buf.append(t)
    if len(buf)%14==0:
        buf=buf[7:]+buf[0:7]
        for j in buf:
            text+=j+"\n"
        buf=[]


with open("outputs/output", mode="w", encoding="utf-8")as f:
    f.write(text)





