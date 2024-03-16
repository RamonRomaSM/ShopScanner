import scrapy
#utilizar playwrith para el infinite scroll?

class AlcampospiderSpider(scrapy.Spider):
    name = "alcampospider"
    allowed_domains = ["compraonline.alcampo.es"]
    start_urls = ["https://www.compraonline.alcampo.es/categories"]
    #response.css('div._box_1u7pr_1._box--shadow_1u7pr_15.components__ProductCardContainer-sc-filq44-2.bweFpa') //aqui estan los productos de alcampo
    #response.text  //para cada json
    def parse(self, response):
        productos=response.css('div._box_1u7pr_1._box--shadow_1u7pr_15.components__ProductCardContainer-sc-filq44-2.bweFpa')
        x=0
        
        for producto in productos:
            #TODO sacar los product ids (en la carpeta del proyecto tengo unaimagen de donde estan las ids en el codigo)
            try:
                #'h3._text_f6lbl_1._text--m_f6lbl_23::text'
                print("NOMBRE: "+ str(producto.css('h3._text_f6lbl_1._text--m_f6lbl_23::text').get()))
                print("PRECIO: "+ producto.css('span._text_f6lbl_1._text--m_f6lbl_23.price__PriceText-sc-1nlvmq9-0.BCfDm::text').get() + str(x))
                x = x + 1
           # print("IMAGEN: ")
           # print("URL PRODUCTO: ")
            except:
               break

       #TODO: ahora toca iterar dentro de este array para sacar las ids
        placeholders=response.css('div.base__Wrapper-sc-1mnb0pd-6.base__FixedHeightWrapper-sc-1mnb0pd-41.fop__FixedHeightWrapper-sc-sgv9y1-0.gMlFiL.jqVEqi.dgnEcz.viewports-enabled-standard-fop__ViewportsEnabledFop-sc-zsokr2-0.eLImeH')
        print('sali ' + str(len(placeholders)))
        pass
