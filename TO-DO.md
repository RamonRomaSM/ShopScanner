# Falta:

'*' = Hacer hoy 

## UI:
+ fragents (Mi carrito, mi perfil) *
+ Mantener seleccionado *
+ las tarjetas
+ animaciones 
+ Barra de busqueda (y desplegable de filtros) *
## Logica UI:
+ Carrito:
+ Cargar items en el carrito desde una lista de la compra
+ añadir items al carro
+ guardar carrito (o sobreescribir)
+ Barra de busqueda (y logica de filtros)
+ Ver tus listas de la compra en el perfil

## API

spring tiene forma de mandar correos

https://spring.io/guides/tutorials/rest

sesiones de spring?

https://docs.spring.io/spring-session/reference/guides/java-rest.html

seguridad en la api:

https://www.baeldung.com/spring-boot-api-key-secret (como asegurar la conexion   cliente-server)

ver lo de OW

lombook para pasar a jsons 

Mas contenido:

https://www.jetbrains.com/help/idea/your-first-spring-application.html#what-next

## Seguridad:
Creacion de claves:

Un par de keys
Mandas la cpub al server, y este te contesta ok (y lo guarda en una bdd)

Establecer conexion:

Mandar los datos encript y esperar ok + clave de sesion (para encriptar los mensajes actuales) + token de sesion (el token va al final de las peticiones, ara asegurarse de que eres tu el que hace las peticiones)

(Igual podria, cada vez que te conectas, que se te renueve el par de claves)



