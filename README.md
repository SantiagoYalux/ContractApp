# README - Aplicación Vue.js para Consulta de Contratos

Este repositorio contiene una aplicación desarrollada en Vue.js que permite consultar la información de un contrato a partir de un ID ingresado. La aplicación se conecta a una API desarrollada en .NET, la cual obtiene los datos necesarios desde una base de datos MySQL que contiene las siguientes tablas:

1. **`Contract`**: Almacena la información principal de los contratos.
2. **`Item`**: Contiene los items posibles a relacionar con contratos, indicando su nombre y su precio.
3. **`ContractItem`**: Tabla de relación entre contratos e items.

## Estructura del Proyecto

El proyecto se organiza de la siguiente manera:

- **`/ContractsApp`**: Contiene el código fuente de la API desarrollada en .NET.
- **`/ContractsAppClient`**: Contiene la aplicación Vue.js.

## Configuración y Ejecución

### IMPORTANTE 
-Importante. Debe previamente correr el script de base de datos, adjuntado en el archivo Dump.zip. 
Posterior a esto debe ir al proyecto `/ContractsApp` y debe agregar su path de conexión en el archivo "appsettings.json", debería quedar algo así:
"MySqlConnection": "server=localhost;database=contractcourse_db;uid=root;pwd=(TU CONTRASEÑA)"

### API (.NET)

1. Abra la carpeta `/ContractsApp` en la terminal.
2. Ejecute el comando `dotnet build` para compilar el proyecto.
3. Ejecute el comando `dotnet run` para iniciar el servidor API.

La API estará disponible posiblemente en `http://localhost:5000` (puede variar).

### Aplicación Vue.js

1. Abra la carpeta `/ContractsAppClient` en la terminal.
2. Ejecute el comando `npm install` para instalar las dependencias.
3. Ejecute el comando `npm run dev` para iniciar la aplicación Vue.js.

La aplicación estará disponible posiblemente en `http://localhost:8080` (puede variar).

## Uso de la Aplicación

1. Una vez iniciada la aplicación, en la página principal, encontrará un formulario con un solo campo numérico para ingresar el ID del contrato.
2. Después de ingresar el ID y hacer clic en "Consultar", la aplicación se conectará a la API y mostrará la información del contrato de manera readonly, siguiendo el formato especificado en el enunciado.


