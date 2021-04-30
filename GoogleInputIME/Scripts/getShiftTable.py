
import csv

pathRoot = "Scripts/shiftRoot.csv"

pathOut = "Scripts/shiftRes.csv"

pathGime = "getaro.gime"

with open(pathRoot, newline="")as f:
    reader = csv.reader(f, delimiter=",", quotechar="\n")
    root = []
    for i in reader:
        root.append(i)

with open(pathGime, encoding="utf-8", mode="r", newline="")as f:
    gime = f.read().splitlines()

outTable = []
for shiftRow in root:
    outRow = []
    for shiftItem in shiftRow:
        for gi in gime:
            if not "\t" in gi:
                continue
            CIn, COu = gi.split("\t")
            if shiftItem == CIn:
                outRow.append(COu)
                break
    outTable.append(outRow)

print(outTable)

with open(pathOut, "w", newline="", encoding="utf-8")as f:
    writer = csv.writer(f, delimiter=",", quotechar="\n")
    writer.writerows(outTable)
