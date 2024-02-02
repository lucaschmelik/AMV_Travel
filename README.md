# Proyecto de Reservas de Paquetes - README

## Introducción

Este proyecto se centra en el desarrollo de un sistema de reservas de paquetes con microservicios destinados a la industria de viajes. Se crean dos microservicios: uno para gestionar las reservas y otro para gestionar la información de los hoteles. La reserva se realiza mediante una API REST, y se utiliza un intermediario de mensajes como Kafka o RabbitMQ para notificar al microservicio de Hoteles sobre las reservas realizadas.

## Instrucciones

1. Crea un repositorio en GitHub.
2. Desarrolla las soluciones en C# .NET en el repositorio.
3. Sube los cambios a tu repositorio en GitHub.
4. Envía el enlace del repositorio.

## Microservicio de Reservas

### 3.1 Modelado de Datos

Diseña una estructura de datos para representar la información de las reservas de paquetes, incluyendo entidades como Cliente, Reserva, Paquete, y otras entidades relevantes utilizando clases y relaciones. Puedes agregar un diagrama de entidad-relación para visualizar las relaciones entre las entidades.

### 3.2 Implementación del Sistema con API

Implementa el sistema de reservas de paquetes con una API utilizando ASP.NET. Crea puntos de conexión para operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en las entidades. Asegúrate de que la API sea segura y accesible a través de métodos HTTP adecuados. Proporciona una breve explicación sobre la arquitectura general del sistema y cómo se estructuran las capas.

### 3.3 Documentación de la API (No excluyente)

Documenta la API utilizando Swagger o algún otro framework de documentación de API en C#. Proporciona descripciones claras de los puntos de conexión, los parámetros requeridos y las respuestas esperadas.

### 3.4 Pruebas Unitarias y de Integración (No excluyente)

Implementa pruebas unitarias para al menos una parte de tu código. Además, realiza pruebas de integración para verificar la interoperabilidad del sistema con el proveedor externo.

## Microservicio de Hotel

### 4.1 Integración de Microservicios

Crea un nuevo proyecto que contenga el modelo de Hotel y realiza la integración desde el microservicio de Reservas. Diseña e implementa un módulo que envíe la información con los detalles necesarios para crear la Reserva del hotel.