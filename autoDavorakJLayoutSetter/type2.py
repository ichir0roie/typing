
charList=[]


rightLen=11


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

def outOneCSV(list,list3):
    text=list3[0]+",,"
    c=0
    for i in range(13):
        text += list[c] + ","
        c += 1
    text += "\n"
    for i in range(rightLen):
        text += list[c] + ","
        c += 1
    text += "\n"
    for i in range(rightLen):
        text += list[c] + ","
        c += 1
    text += "\n"
    for i in range(11):
        text += list[c] + ","
        c += 1
    return text.replace(" ","")

def setMyLay12key(list1):
    list=[]
    for i in range(13+7):
        list.append("  ")
    list.append(list1[5])
    list.append(list1[6])
    for i in range(3+5):
        list.append("  ")
    list.append(list1[4])
    list.extend(list1[0:4])
    for i in range(2+5):
        list.append("  ")
    list.extend(list1[7:rightLen])
    list.append("  ")
    return list
def setMyLay11key(list1):
    list=[]
    for i in range(13+7):
        list.append("  ")
    list.append(list1[5])
    list.append(list1[6])
    for i in range(3+5):
        list.append("  ")
    list.append(list1[4])
    list.extend(list1[0:4])
    for i in range(2+5):
        list.append("  ")
    list.extend(list1[7:rightLen])
    list.append("  ")
    list.append("  ")
    return list
list1=[]

list=[]
with open("list.txt",encoding="utf-8") as f:
    text=f.readlines()
    for i in text:
        i=i.replace("\n","")
        if not i =="\n":
            list.append(i)
list1=[]
list2=[]

print(list)

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
]


for i in range(len(list3)):
    print(outOneList(setMyLay11key(list[i*rightLen:i*rightLen+rightLen]),list3[i]))
for i in range(len(list3)):
    print(outOneCSV(setMyLay11key(list[i*rightLen:i*rightLen+rightLen]),list3[i]))
dict=[]
for i in range(len(list3)):
    for j in list[i*rightLen:i*rightLen+rightLen]:
        dict.append([j,list3[i][0]])

print("")

dict.sort(key=lambda x:x[0])
printlist=["" for i in range(12)]
c=0
for i in dict:
    if c>11:
        c=0
    printlist[c]+=i[0]+","+i[1]+","
    c+=1
for i in printlist:
    print(i)
