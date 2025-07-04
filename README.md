# ProyectoBD2

## Descripci�n

ProyectoBD2 es una aplicaci�n de escritorio desarrollada en C# (.NET 8, WinForms) para la gesti�n de productores y fincas. El proyecto est� dise�ado siguiendo principios y patrones de arquitectura modernos, priorizando la mantenibilidad, escalabilidad y calidad del c�digo.

---

## Principales patrones y principios aplicados

### 1. Patr�n de Dise�o MVP (Model-View-Presenter)

- **Separaci�n de responsabilidades:**  
  La l�gica de presentaci�n est� desacoplada de la interfaz de usuario.  
  - **View:** Interfaces y formularios WinForms (`IProductorView`, `ProductoresForm`).
  - **Presenter:** Orquesta la l�gica de presentaci�n y la interacci�n entre la vista y el modelo (`ProductorPresenter`).
  - **Model:** Entidades de dominio y acceso a datos (`Productor`, `ProductoresRepository`).

### 2. Principios SOLID

- **S - Single Responsibility Principle:**  
  Cada clase tiene una �nica responsabilidad clara (por ejemplo, `ProductoresRepository` solo gestiona acceso a datos de productores).
- **O - Open/Closed Principle:**  
  Las interfaces (`IProductorView`, `IProductorRepository`) permiten extender funcionalidades sin modificar el c�digo existente.
- **L - Liskov Substitution Principle:**  
  Las implementaciones pueden ser sustituidas por sus interfaces sin afectar el funcionamiento.
- **I - Interface Segregation Principle:**  
  Las interfaces son espec�ficas y no fuerzan a implementar m�todos innecesarios.
- **D - Dependency Inversion Principle:**  
  El `Presenter` depende de abstracciones (interfaces), no de implementaciones concretas.

### 3. Clean Code

- **Nombres descriptivos:**  
  Clases, m�todos y variables con nombres claros y autoexplicativos.
- **M�todos cortos y enfocados:**  
  Cada m�todo realiza una �nica tarea.
- **Manejo de errores:**  
  Uso de excepciones controladas y mensajes claros para el usuario.
- **Separaci�n de capas:**  
  El acceso a datos, la l�gica de negocio y la presentaci�n est�n claramente separados.

### 4. Buenas pr�cticas adicionales

- **Uso de Entity Framework Core:**  
  Para el acceso a datos, facilitando la mantenibilidad y portabilidad.
- **Inyecci�n de dependencias manual:**  
  Los presenters reciben sus dependencias por constructor, facilitando el testeo y la extensi�n.
- **Configuraci�n externa:**  
  Uso de `appsettings.json` y clase `AppConfig` para la gesti�n de configuraciones y cadenas de conexi�n.
- **Validaciones de datos:**  
  Uso de anotaciones de datos (`DataAnnotations`) en los modelos para asegurar la integridad.

---

## Estructura del proyecto

- `Models/` � Entidades de dominio.
- `Views/` � Formularios y vistas (WinForms).
- `Presenters/` � L�gica de presentaci�n (MVP).
- `Repositories/` � Acceso a datos (interfaces e implementaciones).
- `Config/` � Configuraci�n de la aplicaci�n.
- `Data/` � Contexto de base de datos (Entity Framework).

---

## �Por qu� es relevante para reclutadores?

- **Arquitectura limpia y desacoplada:** Facilita el mantenimiento y la escalabilidad.
- **Aplicaci�n de patrones y principios reconocidos:** Demuestra conocimiento de buenas pr�cticas de ingenier�a de software.
- **C�digo preparado para pruebas y extensi�n:** Gracias al uso de interfaces y separaci�n de responsabilidades.
- **Uso de tecnolog�as modernas:** .NET 8, Entity Framework Core, WinForms.

---

## Requisitos

- .NET 8 SDK
- SQL Server (o modificar la cadena de conexi�n en `appsettings.json`)

---

## Ejecuci�n

1. Clonar el repositorio.
2. Configurar la base de datos en `appsettings.json`.
3. Compilar y ejecutar desde Visual Studio 2022 o superior.

