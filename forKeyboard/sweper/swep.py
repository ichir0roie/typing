import json

from collections import OrderedDict
import pprint


with open("target/for_right.json",encoding="utf-8",mode="r")as f:
    jsonText=f.read()


data=json.loads(jsonText)

keyList=data["layers"]

rowLen=12


for rowNum,i in enumerate(keyList):
    newRow=[]
    for c,d in enumerate(i):
        if c%rowLen<rowLen/2 and c<rowLen*4:
            swapPlace=int(c/rowLen)*rowLen+(int(rowLen/2)-1-c%rowLen)
            newRow.append(i[swapPlace])
        else:
            newRow.append(i[c])
    data["layers"][rowNum]=newRow
    print(i)

output=json.dumps(data)


with open("output/output.json",encoding="utf-8",mode="w")as f:
    f.write(output)

print(data)
