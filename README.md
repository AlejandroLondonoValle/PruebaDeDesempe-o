---

# <div align="center">Hotel RestFull API</div>

![Logo](https://3.imimg.com/data3/JV/KJ/MY-15827078/hotels-booking.jpg)


Hotel RestFull API es un sistema integral para la gestión de reservas en el sector hotelero. Es una API RESTful desarrollada en C# y .NET, que utiliza Swagger para la documentación. El sistema permite a los empleados gestionar reservas de manera eficaz y cuenta con funcionalidades CRUD (Crear, Leer, Actualizar, Eliminar) y consultas especializadas a la base de datos.


## Licencia
MIT License


## Índice
- [Descripción](#descripción)
- [Características](#características)
- [Tecnologías](#tecnologías)
- [Instalación](#instalación)
- [Uso](#uso)
- [Contribución](#contribución)
- [Licencia](#licencia)
- [Créditos](#créditos)
- [Contacto](#contacto)


## Descripción
HotelBookingAPI es una solución para la gestión de reservas en hoteles, que permite a empleados y huéspedes crear, consultar, actualizar y eliminar reservas. La API facilita la disponibilidad de habitaciones, mejora la atención al huésped y proporciona una interfaz intuitiva a través de Swagger.


## Características
- **Gestión de Reservas**: Permite a empleados y huéspedes gestionar reservas de manera efectiva.
- **Disponibilidad de Habitaciones**: Facilita la consulta de habitaciones disponibles y sus tipos.
- **Detalles de Huéspedes**: Proporciona información de los huéspedes para mejorar la atención.
- **Interfaz en Swagger**: Garantiza una experiencia intuitiva y bien documentada para el uso de la API.


## Tecnologías
- **Lenguajes**: C#
- **Frameworks**: .NET Core
- **Documentación**: Swagger
- **Base de Datos**: MySQL
- **ORM**: Entity Framework Core
- **Autenticación**: JWT (JSON Web Tokens)


## Instalación


### Prerrequisitos
- **.NET Core SDK**: Asegúrate de tener instalado el SDK de .NET Core (versión 3.1 o superior).
- **MySQL**: Debes tener MySQL instalado y configurado en tu máquina.


### Clonando el Repositorio
```bash
git clone https://github.com/tu_usuario/hotelbookingapi.git
```


### Instalando Dependencias
```bash
cd hotelbookingapi
dotnet restore
```


### Configuración
1. **Base de Datos**:
   - Crea una base de datos en MySQL y configura la cadena de conexión en `appsettings.json`.

2. **Migraciones**:
   - Ejecuta las migraciones para crear las tablas en la base de datos:
   ```bash
   dotnet ef database update
   ```


### Ejecución
Para ejecutar la API localmente:
```bash
dotnet run
```
La API estará disponible en `http://localhost:5000`. Puedes acceder a la página oficial en `www.hotelbookingapi.com`.


## Uso
Para interactuar con la API, puedes usar herramientas como Postman o la interfaz integrada de Swagger. Aquí tienes un ejemplo de cómo hacer una solicitud GET para consultar todas las reservas:

```bash
curl -X GET "http://localhost:5000/api/v1/bookings"
```


## Contribución
Si deseas contribuir al proyecto, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tu característica:
   ```bash
   git checkout -b feature/nueva-caracteristica
   ```
3. Realiza tus cambios y haz commit:
   ```bash
   git commit -am 'Agregada nueva característica'
   ```
4. Envía la rama:
   ```bash
   git push origin feature/nueva-caracteristica
   ```
5. Crea una pull request en GitHub.


### Código de Conducta
Por favor, sigue el código de conducta establecido para mantener un ambiente colaborativo.


## Licencia
Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo LICENSE para más detalles.


## Créditos
**Autor**: Luis Alejandro Londoño Valle



**Bibliotecas o Recursos**: Agradecimientos a cualquier biblioteca o recurso utilizado en el proyecto.

## Contacto
Luis Alejandro Londoño Valle: [GitHub](https://github.com/AlejandroLondonoValle)

---
