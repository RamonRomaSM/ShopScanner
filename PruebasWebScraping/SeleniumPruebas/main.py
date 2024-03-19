import time

from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import json

browser = webdriver.Chrome()
browser.get('https://www.compraonline.alcampo.es/categories')

last_height = browser.execute_script("return document.body.scrollHeight")


browser.execute_script("window.scrollTo(0, document.body.scrollHeight)")

time.sleep(1)

elements = browser.find_elements(By.CSS_SELECTOR, "#product-page > div > div > div.Col-sc-1ia5hrt-0.ijpbiH > div > div > div")

ids = []

for element in elements:

    id=element.get_attribute("data-visibility-id")
    if str(id) != "None":
        ids.append(id)


browser.close()

# TODO:     en items tengo todos los ids ahora toca hacer la peticion
#peticion:
#www.compraonline.alcampo.es/api/v5/products/decorate?productIds=cddc46c1-7884-4a66-a7f6-ae2533188415,aaa39a2d-7f5b-4627-a92e-6b0950331b72
print(ids)
print(str(len(ids)))





