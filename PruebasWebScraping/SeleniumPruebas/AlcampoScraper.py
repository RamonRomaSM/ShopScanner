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
    #ids mide 300 una vez lleno (pero podria cambiar)
    peticion = 'https://www.compraonline.alcampo.es/api/v5/products/decorate?productIds='


"""
num=20
act=0

peticionAct = 'https://www.compraonline.alcampo.es/api/v5/products/decorate?productIds='

while act < len(ids):  
    if (act+num) < len(ids):
        
        for x in range(act , (act + num)):
            peticionAct = peticionAct + ids[act]
            if x != (num-1):
                  peticionAct = peticionAct + ','
            act=act+1
            
        #aqui hacer peticion
        #reinicio la peticion
        peticionAct = 'https://www.compraonline.alcampo.es/api/v5/products/decorate?productIds='
    
    else:
        
        for x in range(act , len(ids)):
            peticionAct = peticionAct + ids[act]
            if x != (len(ids)-1):
                  peticionAct = peticionAct + ','
            act=act+1
            
        #aqui hacer peticion
        #reinicio la peticion
        peticionAct = 'https://www.compraonline.alcampo.es/api/v5/products/decorate?productIds='
         
    
    
"""

    for id in ids:
        browser2 = webdriver.Chrome()
        peticionAct = str(peticion) + str(id)

        browser2.get(peticionAct)

        productJson=browser2.find_element(By.XPATH,'/html/body/pre')
        parseJsonIntoProducto(productJson.text)

        browser2.close()

    print('[ALCAMPO SCRAPER] Base de datos actualizada')


""" 
TODO: a ver cuanas ids puedo meter de una.

import json

# some JSON:
x = '{"products":[{"productId":"cddc46c1-7884-4a66-a7f6-ae2533188415","retailerProductId":"77081","name":"Mandarina a granel ALCAMPO PRODUCCION CONTROLADA","available":true,"maxQuantityReached":false,"alternatives":[],"price":{"current":{"amount":"1.99","currency":"EUR"},"unit":{"label":"fop.price.per.kg","current":{"amount":"1.99","currency":"EUR"}}},"isInCurrentCatalog":true,"isInProductList":false,"brand":"MIS FRUTAS SELECCIONADAS","retailerFinancingPlanIds":["022","025","026","027","016","021"],"image":{"src":"https://www.compraonline.alcampo.es/images-v3/37ea0506-72ec-4543-93c8-a77bb916ec12/05de9e40-7a00-4895-a766-e149cb4f50d7/300x300.jpg","description":"Mandarina a granel ALCAMPO PRODUCCION CONTROLADA"},"images":[{"src":"https://www.compraonline.alcampo.es/images-v3/37ea0506-72ec-4543-93c8-a77bb916ec12/05de9e40-7a00-4895-a766-e149cb4f50d7/500x500.jpg","description":"Mandarina a granel ALCAMPO PRODUCCION CONTROLADA"}],"icons":{"certification":[],"legal":[]},"attributes":[{"icon":"icon_variable_weight","label":"Peso variable"}],"size":{"value":"1000","uom":"G","catchWeight":true},"catchweight":{"minQuantity":{"value":"750","uom":"G"},"typicalQuantity":{"value":"1000","uom":"G"},"maxQuantity":{"value":"1250","uom":"G"}},"featured":"false"},{"productId":"aaa39a2d-7f5b-4627-a92e-6b0950331b72","retailerProductId":"77074","name":"Filetes de cinta de lomo de categoria extra","available":true,"maxQuantityReached":false,"alternatives":[],"price":{"current":{"amount":"3.23","currency":"EUR"},"unit":{"label":"fop.price.per.kg","current":{"amount":"6.45","currency":"EUR"}}},"isInCurrentCatalog":true,"isInProductList":false,"brand":"CERDO BLANCO","retailerFinancingPlanIds":["022","025","026","027","016","021"],"image":{"src":"https://www.compraonline.alcampo.es/images-v3/37ea0506-72ec-4543-93c8-a77bb916ec12/cf72bfd7-e1c0-4010-82e1-a5d2b5384216/300x300.jpg","description":"Filetes de cinta de lomo de categoria extra"},"images":[{"src":"https://www.compraonline.alcampo.es/images-v3/37ea0506-72ec-4543-93c8-a77bb916ec12/cf72bfd7-e1c0-4010-82e1-a5d2b5384216/500x500.jpg","description":"Filetes de cinta de lomo de categoria extra"}],"icons":{"certification":[],"legal":[]},"attributes":[{"icon":"icon_cooled","label":"Refrigerado"},{"icon":"icon_variable_weight","label":"Peso variable"}],"size":{"value":"500","uom":"G","catchWeight":true},"catchweight":{"minQuantity":{"value":"375","uom":"G"},"typicalQuantity":{"value":"500","uom":"G"},"maxQuantity":{"value":"625","uom":"G"}},"featured":"false"}],"missedPromotions":[]}'

# parse x:
y = json.loads(x)

# the result is a Python dictionary:
prod=y["products"][1]
print(prod)

"""
