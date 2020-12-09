with open("formats/format", mode="r", encoding="utf-8")as f:
    button=f.read()
with open("formats/header", mode="r", encoding="utf-8")as f:
    header=f.read()

text=""
for i in range(1,7):
    text=text+header
    for j in range(0,13):
       text=text+button.format(i,j,i,j)


with open("outputs/output", mode="w", encoding="utf-8")as f:
    f.write(text)






