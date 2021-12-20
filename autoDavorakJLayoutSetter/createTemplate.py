
rows=[11,12,12,11]

placeNumber=1

with open("keyboardNums.txt",mode="w",encoding="utf-8") as f:
    txt=""
    for row in rows:
        cells=range(row)
        for cell in cells:
            txt+="{}\t|\t".format(placeNumber)
            placeNumber+=1
        txt+="\n"
    
    f.write(txt)
   

