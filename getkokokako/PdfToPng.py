import PyPDF2
from pathlib import Path

targetFolder="高校入試過去問/"
targetFolder+="mondaikoukai300307"+"/"
targetFolder+="問題"


pdf_dir = Path(targetFolder)
pdf_files = sorted(pdf_dir.glob("*.pdf"))

import os
from pathlib import Path
from pdf2image import convert_from_path

# poppler/binを環境変数PATHに追加する
# poppler_dir = Path(__file__).parent.absolute() / "poppler/bin"
# os.environ["PATH"] += os.pathsep + str(poppler_dir)

pagess=[]
for file in pdf_files:
    print(file)
# PDF -> Image に変換（150dpi）
    pages = convert_from_path(str(file), 300)
    for p in pages:
        pagess.append(p)

# 画像ファイルを１ページずつ保存
if not os.path.exists("image_file"):
    os.mkdir("image_file")
image_dir = "image_file/"
for i, page in enumerate(pagess):
    print(len(pagess)-i)
    file_name = "_{:02d}".format(i + 1) + ".jpeg"
    image_path = image_dir +"/"+ file_name
    # JPEGで保存
    page.save(str(image_path), "JPEG")

import img2pdf
from pathlib import Path

lists = Path("image_file").glob("*")
with open(targetFolder.replace("/","-")+".pdf", "wb") as f:
    # jpg,pngファイルだけpdfに結合
    # Pathlib.WindowsPath()をstring型に変換しないとエラー
    f.write(img2pdf.convert([str(i) for i in lists]))

import shutil
shutil.rmtree("image_file")