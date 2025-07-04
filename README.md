# ProyectoBD2

## Descripción

ProyectoBD2 es una aplicación de escritorio desarrollada en C# (.NET 8, WinForms) para la gestión de productores y fincas. El proyecto está diseñado siguiendo principios y patrones de arquitectura modernos, priorizando la mantenibilidad, escalabilidad y calidad del código.

---

## Principales patrones y principios aplicados

### 1. Patrón de Diseño MVP (Model-View-Presenter)

- **Separación de responsabilidades:**  
  La lógica de presentación está desacoplada de la interfaz de usuario.  
  - **View:** Interfaces y formularios WinForms (`IProductorView`, `ProductoresForm`).
  - **Presenter:** Orquesta la lógica de presentación y la interacción entre la vista y el modelo (`ProductorPresenter`).
  - **Model:** Entidades de dominio y acceso a datos (`Productor`, `ProductoresRepository`).

### 2. Principios SOLID

- **S - Single Responsibility Principle:**  
  Cada clase tiene una única responsabilidad clara (por ejemplo, `ProductoresRepository` solo gestiona acceso a datos de productores).
- **O - Open/Closed Principle:**  
  Las interfaces (`IProductorView`, `IProductorRepository`) permiten extender funcionalidades sin modificar el código existente.
- **L - Liskov Substitution Principle:**  
  Las implementaciones pueden ser sustituidas por sus interfaces sin afectar el funcionamiento.
- **I - Interface Segregation Principle:**  
  Las interfaces son específicas y no fuerzan a implementar métodos innecesarios.
- **D - Dependency Inversion Principle:**  
  El `Presenter` depende de abstracciones (interfaces), no de implementaciones concretas.

### 3. Clean Code

- **Nombres descriptivos:**  
  Clases, métodos y variables con nombres claros y autoexplicativos.
- **Métodos cortos y enfocados:**  
  Cada método realiza una única tarea.
- **Manejo de errores:**  
  Uso de excepciones controladas y mensajes claros para el usuario.
- **Separación de capas:**  
  El acceso a datos, la lógica de negocio y la presentación están claramente separados.

### 4. Buenas prácticas adicionales

- **Uso de Entity Framework Core:**  
  Para el acceso a datos, facilitando la mantenibilidad y portabilidad.
- **Inyección de dependencias manual:**  
  Los presenters reciben sus dependencias por constructor, facilitando el testeo y la extensión.
- **Configuración externa:**  
  Uso de `appsettings.json` y clase `AppConfig` para la gestión de configuraciones y cadenas de conexión.
- **Validaciones de datos:**  
  Uso de anotaciones de datos (`DataAnnotations`) en los modelos para asegurar la integridad.

---

## Estructura del proyecto

- `Models/` — Entidades de dominio.
- `Views/` — Formularios y vistas (WinForms).
- `Presenters/` — Lógica de presentación (MVP).
- `Repositories/` — Acceso a datos (interfaces e implementaciones).
- `Config/` — Configuración de la aplicación.
- `Data/` — Contexto de base de datos (Entity Framework).

---

## ¿Por qué es relevante para reclutadores?

- **Arquitectura limpia y desacoplada:** Facilita el mantenimiento y la escalabilidad.
- **Aplicación de patrones y principios reconocidos:** Demuestra conocimiento de buenas prácticas de ingeniería de software.
- **Código preparado para pruebas y extensión:** Gracias al uso de interfaces y separación de responsabilidades.
- **Uso de tecnologías modernas:** .NET 8, Entity Framework Core, WinForms.

---

## Requisitos

- .NET 8 SDK
- SQL Server (o modificar la cadena de conexión en `appsettings.json`)

---

## Ejecución

1. Clonar el repositorio.
2. Configurar la base de datos en `appsettings.json`.
3. Compilar y ejecutar desde Visual Studio 2022 o superior.

