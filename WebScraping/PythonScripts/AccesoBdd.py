import mysql.connector
import psycopg2

POSTGRES_URL="postgres://default:LgdV3Hc7UFKI@ep-quiet-feather-a2l8vl1h-pooler.eu-central-1.aws.neon.tech:5432/verceldb?sslmode=require"
POSTGRES_PRISMA_URL="postgres://default:LgdV3Hc7UFKI@ep-quiet-feather-a2l8vl1h-pooler.eu-central-1.aws.neon.tech:5432/verceldb?sslmode=require&pgbouncer=true&connect_timeout=15"
POSTGRES_URL_NO_SSL="postgres://default:LgdV3Hc7UFKI@ep-quiet-feather-a2l8vl1h-pooler.eu-central-1.aws.neon.tech:5432/verceldb"
POSTGRES_URL_NON_POOLING="postgres://default:LgdV3Hc7UFKI@ep-quiet-feather-a2l8vl1h.eu-central-1.aws.neon.tech:5432/verceldb?sslmode=require"
POSTGRES_USER="default"
POSTGRES_HOST="ep-quiet-feather-a2l8vl1h-pooler.eu-central-1.aws.neon.tech"
POSTGRES_PASSWORD="LgdV3Hc7UFKI"
POSTGRES_DATABASE="verceldb"

mydb = psycopg2.connect(
    host=POSTGRES_HOST,
    dbname=POSTGRES_DATABASE,
    user=POSTGRES_USER,
    password=POSTGRES_PASSWORD
)

"""
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="nosequeponer"
)
"""

def borrarBdd():

    #mycursor = mydb.cursor()

   # mycursor.execute("TRUNCATE TABLE productos")

    print("[SISTEMA] Base de datos vaciada")

def guardarProducto(Producto):
    mycursor = mydb.cursor()
    #sql = "INSERT INTO tfg.productos (idproductos, nombre, precio, supermercado, oferta, url, imagen) VALUES (%s, %s, %s, %s, %s, %s, %s)"
    sql = "INSERT INTO productos (idproductos, nombre, precio, supermercado, oferta, url, imagen) VALUES (%s, %s, %s, %s, %s, %s, %s)"
    val = (Producto.id, Producto.nombre, Producto.precio, Producto.supermercado, Producto.oferta, Producto.URL, Producto.imagen)
    mycursor.execute(sql, val)

    mydb.commit()
    print('[SISTEMA] producto guardado:    ' + Producto.nombre + '  :  ' + Producto.precio + '  :  ' + Producto.URL + '  :  ' + Producto.imagen + '  :  ' + Producto.oferta + '  :  ' + Producto.supermercado)