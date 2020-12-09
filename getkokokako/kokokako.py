from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import os
import urllib3
import time

option=Options()
option.add_argument("--headless")
driver = webdriver.Chrome(options=option)

urls=[
    # "https://www.pref.fukuoka.lg.jp/contents/kensamondai29.html",
    # "https://www.pref.fukuoka.lg.jp/contents/mondaikoukai300307.html",
    "https://www.pref.fukuoka.lg.jp/contents/mondaikoukai310306.html",
    "https://www.pref.fukuoka.lg.jp/contents/mondaikoukai020310.html"
    ]

for url in urls:
    print(url)
    driver.get(url)

    dfileTex = url.split("/")[-1].replace(".html", "")
    if not os.path.exists(dfileTex):
        os.mkdir(dfileTex)

    hrefs = driver.find_elements_by_tag_name("a")
    pdfs = [i.get_attribute("href") for i in hrefs if ".pdf" in i.get_attribute("href")]
    print(pdfs)


    for i in pdfs:
        print(i)
        remd = urllib3.PoolManager()
        res = remd.request("GET", i)
        with open(dfileTex + "/" + i.split("/")[-1], "wb")as f:
            f.write(res.data)
        time.sleep(3)

driver.close()
driver.quit()