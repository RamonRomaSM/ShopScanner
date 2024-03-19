import time
from selenium import webdriver
from selenium.webdriver.common.by import By


def parseJsonIntoProducto (json):
    #TODO: saca los datos, crea el producto y lo guarda
    print('parseado')

def startScraping () :
    #TODO: antes de empezar a scrapear, borrar todo lo que hay en la bdd

    browser = webdriver.Chrome()
    browser.get('https://www.compraonline.alcampo.es/categories')

    time.sleep(1)

    elements = browser.find_elements(By.CSS_SELECTOR, "#product-page > div > div > div.Col-sc-1ia5hrt-0.ijpbiH > div > div > div")

    ids = []

    for element in elements:

        id=element.get_attribute("data-visibility-id")
        if str(id) != "None":
            ids.append(id)


    browser.close()

    #peticion:
    #www.compraonline.alcampo.es/api/v5/products/decorate?productIds=cddc46c1-7884-4a66-a7f6-ae2533188415,aaa39a2d-7f5b-4627-a92e-6b0950331b72

    peticion = 'https://www.compraonline.alcampo.es/api/v5/products/decorate?productIds='

    for id in ids:
        browser2 = webdriver.Chrome()
        peticionAct = str(peticion) + str(id)

        browser2.get(peticionAct)
        time.sleep(0.5)# TODO: aqui sacar el json y parsearlo

        browser2.close()

    print('[ALCAMPO SCRAPER] Base de datos actualizada')



