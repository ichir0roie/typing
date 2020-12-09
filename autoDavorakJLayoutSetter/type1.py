
charList=[]


def outOneList(list,list3):
    text="/*["+list3[0]+"]*/\n+"+list3[1]+"[\n"
    c=0
    for i in range(13):
        text += list[c] + "|"
        c += 1
    text += "\n"
    for i in range(12):
        text += list[c] + "|"
        c += 1
    text += "\n"
    for i in range(12):
        text += list[c] + "|"
        c += 1
    text += "\n"
    for i in range(11):
        text += list[c] + "|"
        c += 1
    text += "\n"
    text+="]\n"
    return text

def setMyLay(list1,list2):
    list=[]
    for i in range(13+7):
        list.append("  ")
    list.extend(list2[0:2])
    for i in range(3+5):
        list.append("  ")
    list.extend(list2[2:3])
    list.extend(list1)
    for i in range(2+5):
        list.append("  ")
    list.extend(list2[3:])
    list.append("  ")
    return list

list1=[]
with open("list1.txt",encoding="utf-8") as f:
    for line in f:
        buf=[]
        for c in line.replace("\n",""):
            buf.append(c)
        list1.append(buf)
list2=[]
with open("list2.txt",encoding="utf-8") as f:
    for line in f:
        buf=[]
        for c in line.replace("\n",""):
            buf.append(c)
        list2.append(buf)

list=[]
with open("list.txt",encoding="utf-8") as f:
    text=f.readlines()
    for i in text:
        i=i.replace("\n","")
        if not i =="\n":
            list.append(i)
list1=[]
list2=[]
list1.append(list[0:4])
list2.append(list[4:12])
list=list[12:]
c=0
for i in range(12):
    list1.append(list[c:c+4])
    c+=4
for i in range(12):
    list2.append(list[c:c+8])
    c+=8

print(list)

print(list1)
print(list2)
list3=[
    ["",""],
    ["f","21"],
    ["d","20"],
    ["s","1f"],
    ["a","1e"],
    ["e","12"],
    ["w","11"],
    ["g","22"],
    ["v","2f"],
    ["c","2e"],
    ["x","2d"],
    ["z","2c"],
]

for i in range(len(list3)):
    print(outOneList(setMyLay(list1[i],list2[i]),list3[i]))