# Descripcion de la intefaz

el objetivo es ir añadiendo cosas a la cesta, cuando ya lo tengas, 
te metes en la cesta y generas la lista de la compra

Acuerdate de que lo primero que pide la app es que te logees/registres como en el supercole.

Como no se lo que tardare ahi van las funcionalidaddes/requisitos:
Productos y perfil estan en una barra de navegacion en la parte superior, estas por dentro tienen barras laterales en a izquierda.

+ Infinite scroll de los productos:
Como no se lo que tardare ahi van las funcionalidaddes/requisitos por prioridad:

+ Infinite scroll de los productos: **(1)**  
    https://www.youtube.com/watch?app=desktop&v=_4qej7q6x30
    https://stackoverflow.com/questions/7581732/wpf-datagrid-lazy-loading-inifinite-scroll
+ Poder acceder a mi cuenta
  + Mi nombre
  + Mi correo ( si me diera tiempo )
  + Mis listas:
    + Poder modificarlas (si cliko en un lapiz al lado del nombre la re nombro, si aprieto una papelera al lado del producto        lo borro)
    Barra lateral:
      + filtrar por precio

+ Poder acceder a mi cuenta  **(1)**
  + Mi nombre  
  + Mi correo ( si me diera tiempo )  **(3)**
  + Mis listas:  **(1)**
    + Poder modificarlas (si cliko en un lapiz al lado del nombre la re nombro, si aprieto una papelera al lado del producto        lo borro)  **(3)**
    + Mandarmela por correo (si me da tiempo a implementar lo del correo)

    + Borrarlas **(1)**
   
## Barra de navegacion Izquierda

+ Productos
    + Barra de busqueda arriba
      + Boton del desplegable de filtros a la derecha del boton de buscar
        + Filtrar por: supermercado    /    ordenar por precio    /    rango de precios    /    mostrar ofertas
    + Infinite Scroll en el centro
        + Cada vez que se aplica un filtro vuelve arriba y se reinicia
        + los items:
            + Foto / nombre / precio / oferta ( si es de mercadona aparece con el precio antiguo tachado, si es de alcampo dice el catalogo o lo que sea)
            + Si le haces click al item te lleva al componente que muestra al item:
                + Foto / Nombre / supermercado / precio / rebaja / pagina / añadir al carrito

+ Perfil
    + Datos mios (nombre correo)
    + ListView con mis listas
        + Por fuera se ve el nombre , el precio total, el numero de items
        + Cuando clicas: te abre el pdf?, la despliega hacia abajo?
+ Carrito
  
+ Ayuda


# Planificacion
+    Barra superior con una x y boton de minimizar y maximizar, color negro, para diferenciarlo del resto, que respete      las esquinas redondedas
+    antes del 6 tener el inicio de sesion (al menos el user control) (al principio te pide logearte / registrarte)
     de paso darle funcionalidad al boton de cerrar sesion (nomas que te devuelve al userControl del login)
     
+    entre el 6-8 hacer el infinite scroll (poner la barra de busqueda (si contiene el string te lo muestro  SELECT         *FROM yourTableName where yourColumnName like '%yourPattern%'; )(recuerda que si el input text esta
     focuseado, al apretar enter se realiza la accion de buscar))
    






