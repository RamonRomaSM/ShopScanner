class Producto:
    nombre = ''
    precio = 0
    imagen = ''
    supermercado = ''
    URL = ''
    oferta = False

    def __int__(self,nombre,precio,imagen,supermercado,URL,oferta):
        self.nombre = nombre
        self.URL = URL
        self.precio = precio
        self.oferta = oferta
        self.imagen = imagen
        self.supermercado = supermercado

    def guardarEnBdd(self):
        print('guardado')