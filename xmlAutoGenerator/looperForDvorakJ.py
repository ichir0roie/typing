with open("formats/DvorakJBase", mode="r", encoding="utf-8")as f:
    base=f.read()
with open("inputs/kKeys", mode="r", encoding="utf-8")as f:
    kKeys=f.read().splitlines()
with open("inputs/lKeys", mode="r", encoding="utf-8")as f:
    lKeys=f.read().splitlines()
with open("inputs/keyCodes", mode="r", encoding="utf-8")as f:
    codes=f.read().splitlines()

text=""
for i in range(len(kKeys)):
       text=text+base.format(kKeys[i]+"&"+lKeys[i],codes[i],kKeys[i],lKeys[i])+"\n"

with open("outputs/output", mode="w", encoding="utf-8")as f:
    f.write(text)






