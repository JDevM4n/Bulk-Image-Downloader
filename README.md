# Bulk Image Downloader 🚀

Análisis de rendimiento y concurrencia en operaciones I/O Bound utilizando el ecosistema moderno de **.NET (C#)**.

![.NET](https://img.shields.io/badge/.NET-10-purple)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Git](https://img.shields.io/badge/Git-Branching-orange)

---

## 📝 Descripción del Proyecto

Esta aplicación de consola está diseñada para resolver un problema clásico en el desarrollo de software: la optimización de tareas bloqueantes de Entrada/Salida (I/O Bound) mediante la descarga masiva de recursos web. 

El proyecto implementa y compara dos enfoques arquitectónicos:
1. **Enfoque Secuencial:** Procesamiento síncrono tradicional (en "fila india").
2. **Enfoque Concurrente/Asíncrono:** Procesamiento en paralelo utilizando el Pool de hilos de .NET.

El sistema genera una métrica exacta de tiempo con el fin de demostrar empíricamente cómo la correcta gestión de tareas asíncronas puede reducir el tiempo de ejecución en hasta un **80%**.

---

## 🛠️ Conceptos de Ingeniería Implementados

* **TAP (Task-based Asynchronous Pattern):** Uso estricto de las palabras clave `async` y `await` para liberar hilos del sistema operativo durante las peticiones de red.
* **Orquestación de Tareas:** Implementación de `Task.WhenAll` para disparar múltiples promesas de descarga en paralelo y controlar el punto de sincronización final.
* **Thread-Safety (Memoria Compartida):** Uso de la clase estática `System.Threading.Interlocked` para prevenir condiciones de carrera (*Race Conditions*) al modificar variables globales desde múltiples hilos.
* **Tolerancia a Fallos:** Diseño de bloques defensivos `try-catch` dentro de cada tarea para evitar que el fallo de un hilo (como un error HTTP 404 o timeout) colapse el resto de la ejecución.

---

## 📐 Flujo de Trabajo y Buenas Prácticas (Git)

El desarrollo del proyecto se estructuró bajo una estrategia estricta de **Git Branching** para mantener la integridad del código de producción:

* `main`: Rama de producción limpia y con código 100% funcional.
* `feature/secuencial`: Desarrollo aislado del algoritmo de descarga síncrona.
* `feature/concurrente`: Implementación experimental de la lógica de hilos y asincronía.

---

## 💻 Requisitos del Sistema

* .NET SDK 8.0 o superior.
* IDE de preferencia (Visual Studio / VS Code).

## 🚀 Ejecución

Para clonar y correr este proyecto localmente:

```bash
# Clonar el repositorio
git clone <URL_DE_TU_REPOSITORIO>

# Entrar a la carpeta
cd BulkImageDownloader

# Compilar y ejecutar la aplicación
dotnet run
