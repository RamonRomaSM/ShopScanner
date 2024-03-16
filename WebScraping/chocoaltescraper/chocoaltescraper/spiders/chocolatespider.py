import scrapy


class ChocolatespiderSpider(scrapy.Spider):
    name = "chocolatespider"
    allowed_domains = ["compraonline.alcampo.es"]
    start_urls = ["https://www.compraonline.alcampo.es/categories"]

    def parse(self, response):
        pass
