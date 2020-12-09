from bs4 import BeautifulSoup as bs
import re

soup=bs(open("文字頻度表.html"),"html.parser")
vals=soup.find_all("td")
vals=[i.text for i in vals ]
c=0
for i in vals:
    if "あ（1672）" == i:
        break
    c+=1

print(c)
vals=vals[c:]
print(vals)

regex=re.compile("\d+")

lists=[]
for i in vals:
    t=[]
    cha=re.sub("[0-9]","",i)
    cha=cha.replace("（","")
    cha=cha.replace("）","")
    t.append(cha)
    num=regex.findall(i)
    if len(num)==0:
        continue
    t.append(int(num[0]))
    lists.append(t)
# lists=[i for i in lists if not "" == i[1] ]
print(lists)

# lists.sort(key=lambda x:x[1],reverse=True)
#
# lists=[i for i in lists if len(i[0])<3]
lists=[i for i in lists if len(i[0])>1 and len(i[0])<3]
# lists=[i for i in lists if len(i[0])>1 and i[1]>0]
# lists=[i for i in lists if not "ゃ"in i[0]]
# lists=[i for i in lists if not "ゅ"in i[0]]
# lists=[i for i in lists if not  "ょ"in i[0]]
lists.sort(key=lambda x:x[1],reverse=True)


for i in lists[:41]:
    print(i[0])
    # print(i[0]+":"+str(i[1]))