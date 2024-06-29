# Sistema-de-Registro-de-Redadas
Sistema con interfaz gráfica para registrar las redadas realizadas en RD.

Este sistema cuenta con una interfaz gráfica web para gestionar redadas y sus resultados. Incluye las siguientes funcionalidades:
- Gestión de Redadas: Permite listar, agregar, editar y eliminar registros de redadas.
- Gestión de Detenidos: Permite listar, agregar, editar y eliminar registros de personas detenidas.
- Visualización en el Mapa: Ofrece una vista interactiva en el mapa donde se muestran las ubicaciones donde fueron capturados los detenidos.

Toda la información se almacena en una base de datos local, asegurando que los datos sean fácilmente accesibles y gestionables.

## Tabla de Contenidos

- [Instalación](#Instalación)
- [Tecnologias](#Tecnologias-Utilizadas)
- [Imagenes del sistema](#Imagenes-del-sistema)


## Instalación

1. Clona el repositorio:
    ```bash
    git clone https://github.com/saulsantana0412/Sistema-de-Redadas.git
    ```
2. Entra en el directorio del proyecto:
    ```bash
    cd Sistema-de-Redadas
    ```
3. Instala las dependencias:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet tool install --global dotnet-ef
    ```
4. Corre el programa:
    ```bash
    dotnet watch run
    ```

## Tecnologias-Utilizadas
- C# - Blazor
- MySql
- HTML
- CSS

## Imagenes-del-sistema

### Página Principal
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/b63acd72-4b3b-4245-8981-0aa5d15789cc)

### Listado de todas las redadas
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/658496e1-7ac7-4733-94b7-54bf8abb1edb)

### Formulario para agregar redada
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/d3194c82-af9b-4e1d-a9ca-c21040ef2e62)

### Detalle de redada
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/3a1170c8-7e0e-44dc-a597-d2027007c205)

### Gestion de redada
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/e404f814-815e-403c-a979-2a85b1725e3c)

### Listado de todos los detenidos
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/f832bb3d-dcaf-45e4-9a76-5215862c0628)

### Mapa que muestra la ubicacion de cada detenido
![image](https://github.com/saulsantana0412/Sistema-de-Redadas/assets/103664258/86accba3-8202-4d4b-8054-2c477f7151a0)





