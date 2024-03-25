import mysql

def borrarBdd():
    print("[SISTEMA] Base de datos borrada")

def guardarProducto(Producto):
    print('[SISTEMA] producto guardado:    ' + Producto.nombre + '  :  ' + Producto.precio + '  :  ' + Producto.URL + '  :  ' + Producto.imagen + '  :  ' + Producto.oferta + '  :  ' + Producto.supermercado)