with open("formats/DvorakJDefault", mode="r", encoding="utf-8")as f:
    base=f.read().splitlines()
with open("inputs/DvorakJMyKey", mode="r", encoding="utf-8")as f:
    DKeys=f.read().splitlines()
text=""

Dbase=[]
for i in base:
    buf=i.split("|")
    Dbase.append(buf)


Dlists=[]
nowParent=""
count=0
for i in DKeys:
    if(i==''):
        continue
    elif (i[0]=='#'):
        nowParent=i[1:]
        count=0
        if(nowParent=="A"):
            count+=4
            nowParent=""
    else:
        text=i.replace(" ","").split("|")
        for c,j in enumerate(text):
            Dlists.append(nowParent+Dbase[count][c]+"\t"+j)
        count+=1

output=""
for i in Dlists:
    output+=i+"\n"

with open("outputs/GoogleIME.txt", mode="w", encoding="utf-8")as f:
    f.write(output)






