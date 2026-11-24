# Sistema de Gestión de Trámites - Nido Estrellita de Fátima
## Descripción
Sistema con interfaz gráfica (Windows Forms) desarrollado en C# para administrar los registros académicos de los alumnos del Nido Estrellita de Fátima mediante operaciones CRUD. Utiliza archivos para el almacenamiento permanente de los datos y control de versiones con Git y GitHub.

## Integrantes
| Nombre | Usuario de GitHub | Módulo a cargo |
|---|---|---|
| Franchesca Paola Cherrez Espinoza | Franches-upn | Ordenamiento, control de versiones con Git y estructura de las clases |
| Gianpiero Torres Casachahua | GTC207 | Desarrollo del sistema: clases gestortramites y tramites |
| Karen Judith Paucar Mendieta | | Implementación de métodos |
| Leyla Andrea Poma Arroyo | andrea-an037 | Implementación de archivos de texto y binarios para conservar los registros |
| Alexis Michael Cercado Cruzado | | Pruebas del sistema y detección de errores en el registro de alumnos |

## Tecnologías
- C# (Windows Forms, .NET Framework)
- Visual Studio
- Serialización de archivos (texto y binario)
- Git y GitHub

## Funcionalidades
- Registrar alumnos con validación de DNI, código único y nota.
- Mostrar la lista de alumnos registrados.
- Buscar por código, nombre, apellidos, profesora, curso o nota (búsqueda recursiva).
- Modificar los datos de un alumno.
- Eliminar el registro de un alumno.
- Ordenar los registros por nota con los métodos burbuja y selección.
- Mostrar el alumno con la mayor nota.
- Generar y mostrar en pantalla el reporte de notas de un alumno.
- Guardar y leer los datos desde archivo.

## Estructura del proyecto

ProyectEF1/
├── tramites.cs // Datos del alumno
├── gestortramites.cs // Lógica del sistema (CRUD, búsqueda, ordenamiento)
├── ArchivoTramites.cs // Guardado y lectura en archivo
├── Program.cs // Punto de entrada de la aplicación
├── frmLogin // Pantalla de bienvenida
├── frmInicio // Formulario principal (menú)
├── frmRegistrar // Registro de alumnos
├── frmLista // Lista de alumnos y ordenamiento
├── frmBuscar // Búsqueda de alumnos
├── frmModificar // Modificación de registros
├── frmEliminar // Eliminación de registros
├── frmMayorNota // Alumno con la mayor nota
├── frmImpresion // Reporte de notas
└── App.config



## Instalación y ejecución
1. Clonar el repositorio:
   `git clone [URL del repositorio del formulario]`
2. Abrir el archivo de solución (`ProyectEF1.slnx`) con Visual Studio.
3. Compilar con Ctrl + Shift + B.
4. Ejecutar con F5.

## Evidencias
Capturas del sistema en funcionamiento: pantalla de bienvenida, formulario principal, registro, búsqueda y reporte.
<img width="942" height="477" alt="image" src="https://github.com/user-attachments/assets/a8739b60-f516-47f9-bf54-97ee6d6efb86" />
Clase tramites implementada
<img width="1072" height="646" alt="image" src="https://github.com/user-attachments/assets/1617d3b4-a781-45f9-ad8c-02fc465da2f0" />
gestortramites
<img width="1027" height="493" alt="image" src="https://github.com/user-attachments/assets/59744b28-0cd7-4fce-959c-f260bbd21763" />
Desarrollo del codigo registrar alumno:
código del profesor y tutor: 
<img width="1075" height="652" alt="image" src="https://github.com/user-attachments/assets/a59985f7-75cf-4627-bc43-f8ebb93f6aba" />
para mostrar el registro:
implementación de poder modificar el registro
<img width="1072" height="684" alt="image" src="https://github.com/user-attachments/assets/745959d2-6c0b-4a28-9bff-7adfda8aa9f1" />

Guardar en archivo de texto
<img width="1078" height="527" alt="image" src="https://github.com/user-attachments/assets/9b328e2c-edb3-4ac9-8da9-ece046caa73e" />

implementación de poder eleiminar el registro:
<img width="1065" height="675" alt="image" src="https://github.com/user-attachments/assets/34d12d90-b710-4e13-b076-272b42d1f896" />

implementacion de buscar por codigo, nombre,apellido,profesor, nota:
<img width="1041" height="673" alt="image" src="https://github.com/user-attachments/assets/9fda69ed-a174-41a6-92b0-d071d5aec6b8" />
Ordenar los tramites por seccion utilizando el metodo burbuja y seleccion:
<img width="1062" height="660" alt="image" src="https://github.com/user-attachments/assets/068b0946-7c05-4059-bb8b-01f0cde74b3c" />
Ordenar los tramites por seccion utilizando el metodo Seleccion:
Mayor Nota
<img width="1074" height="680" alt="image" src="https://github.com/user-attachments/assets/d78cf384-9ce3-4815-8d3d-28325d1b107a" />

## Repositorio
https://github.com/GTC207/ProyectoEF1





