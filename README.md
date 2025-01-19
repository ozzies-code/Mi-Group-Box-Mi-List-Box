# Project Title

 Mi Group Box Mi List Box
 Proyecto que emplea Groupbox y ListBox

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 los objetos ListBox y GroupBox para agregar los campos nombres y 
 apellidos contenidos en sus correspondientes cuadros de texto a un 
 objeto lista para posteriormente mostrarlos una vez que se activa el
 evento SelectedItem.
 
 # Actualizacion: 19/01/2025
 # Hora: 05:36

Detalles técnicos del proyecto:
Idioma: Visual C#.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo de listas y groupbox
- eventos
- manejo del evento SelectedItem
- manejo de Message Box

## image of the Project

![imagen](https://github.com/user-attachments/assets/bb4e2684-b2f9-4d4f-9b29-d3bc2b13c921)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim persona As String = txtNombres.Text & " " & txtApellidos.Text
        liPersonas.Items.Add(persona)

        txtNombres.Clear()
        txtApellidos.Clear()
        'Se concatenan los nombres y apellidos y se almacenan en la variable persona
        'el contenido de la variable persona se almacena en la lista y los campos se limpian
    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click

        Dim personas As String = TryCast(liPersonas.SelectedItem, String)
        'convierte un objeto a una cadena con TryCast
        MsgBox(personas)
        'se muestra el contenido seleccionado de la lista por medio de la propiedad SelectedItem
    End Sub
End Class
