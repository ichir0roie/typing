import os


with open("source.txt",mode="r",encoding="utf-8")as f:
    file=f.readlines()

for i in file:
    if("<p class=\"kanji\">" in i):
        i=i.replace("<p class=\"kanji\">","")
        i=i.replace("</p>","")
        i=i.replace(" ","").replace("\t","").replace("\n","").replace("\r","")
        #print(i)

    if("<p class=\"kana\">(" in i):
        i=i.replace("<p class=\"kana\">(","")
        i=i.replace(")</p>","")
        i=i.replace(" ","").replace("\t","").replace("\n","").replace("\r","")
        print(i)

