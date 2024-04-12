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
El viernes que viene tener la ui terminada:
 + Infinite scroll
 + Fragments
 + Detalles visuales

Intentar tener las modificaciones del python script:
+ Que recoja los datos de la conexion de un fichero (la primera vez que se ejecuta pedirlos?)

### Futuro si eso

+ Meter mas scrapers
+ Subir a la nube (pero si uso algo tipo mongodb tendre que usar ademas una nube basada en json (firebase) la otra de sql)
+ Chatbot? (meh, ns en que podria ayudarte)
+ App del movil (Seria en principio una app sencilla para recibir tus listas de la compra e ir marcando irl lo que llevas comprado) (si hago esto, usar firebase me va a ahorrar MUCHOS DOLORES DE CABEZA)
+ Mandarte el pdf por correo (evidentemente si ya tienes la app esto es un poco meh, asi que o una u otra (o quizas las 2))
+ Hay alguna forma de redirigirte a las paginas de compra con la cesta que tienes? (claro que saber el sobrecoste del pedido a domicilio sera una movida (no se donde vive el usuario))
+ 
