import PyPDF2
from pathlib import Path

targetFolder="高校入試過去問/"
targetFolder+="mondaikoukai300307"+"/"
targetFolder+="問題"


pdf_dir = Path(targetFolder)
pdf_files = sorted(pdf_dir.glob("*.pdf"))

# １つのPDFファイルにまとめる
pdf_writer = PyPDF2.PdfFileWriter()
for pdf_file in pdf_files:
    print(pdf_file)
    pdf_reader = PyPDF2.PdfFileReader(str(pdf_file))
    for i in range(1,pdf_reader.getNumPages()-1):
        pdf_writer.addPage(pdf_reader.getPage(i))

# 保存ファイル名（先頭と末尾のファイル名で作成）
merged_file = pdf_files[0].stem + "-" + pdf_files[-1].stem + ".pdf"

# 保存
f=open(merged_file, "wb")
pdf_writer.write(f)
f.close()

