
charList=[]

with open("mainTwoChars",encoding="utf-8") as f:
    text=f.readlines()
    for i in text:
        i=i.replace("\n","")
        if not i =="\n":
            charList.append(i)

print(charList)


numList=[]

with open("mainTwoCharsNum",encoding="utf-8") as f:
    text=f.readlines()
    for i in text:
        i=i.replace("\n","")
        if not i =="\n":
            numList.append(int(i))

print(numList)

c=0
text=""
for i in range(4):
    for j in range(10):
        print(c)
        text+=charList[numList[c]-1]+"|"
        c+=1
    text+="\n"

print(text)
