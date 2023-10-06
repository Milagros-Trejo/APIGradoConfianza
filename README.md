# APIGradoConfianza

Esta API tiene como objetivo calcular el grado de confianza de los miembros de una comunidad y de las comunidades asociadas.

## Atributos del json
```bash
{
      "idUsuario": 0,
      "gradoActualConfianza": 0,
      "cantidadCierresFraudulentos": 0,
      "cantidadAperturasFraudulentas": 0,
      "cantidadInteraccionesCorrectas": 0
}
```
  - idUsuario: un entero para identificar al usuario que se va a evaluar
  - gradoActualConfianza: el valor del grado actual de confianza
  - cantidadCierresFraudulentos: cantidad de cierres probablemente fraudulentos desde la última vez que se evaluó el grado de confianza
  - cantidadAperturasFraudulentas: cantidad de aperturas probablemente fraudulentas desde la última vez que se evaluó el grado de confianza
  - cantidadInteraccionesCorrectas: cantidad de interacciones probablemente correctas desde la última vez que se evaluó el grado de confianza

```bash
{
     "idComunidad": 0,
      "gradosConfianzaUsuarios": [
        0
      ]
}
```
  - idComunidad: un entero para identificar la comunidad que se va a evaluar
  - gradosConfianzaUsuarios: lista de números que representan los grados de confianza de todos los integrantes de la comunidad a evaluar al momento del request

## Ejemplo de Uso

```bash
POST https://localhost:8000/GradoDeConfianza/Usuario

  RequestBody:
  {
      "idUsuario": 0,
      "gradoActualConfianza": 0,
      "cantidadCierresFraudulentos": 0,
      "cantidadAperturasFraudulentas": 0,
      "cantidadInteraccionesCorrectas": 0
  }
  
  Response:
  {
      "idUsuario": 0,
      "gradoConfianzaFinal": 0
  }

POST https://localhost:8000/GradoDeConfianza/Comunidad

  RequestBody:
  {
      "idComunidad": 0,
      "gradosConfianzaUsuarios": [
        0
      ]
  }
  
  Response:
  {
      "idComunidad": 0,
      "gradoConfianzaFinal": 0
  }

POST https://localhost:8000/GradoDeConfianza/Usuarios

  RequestBody:
  [
    {
      "idUsuario": 0,
      "gradoActualConfianza": 0,
      "cantidadCierresFraudulentos": 0,
      "cantidadAperturasFraudulentas": 0,
      "cantidadInteraccionesCorrectas": 0
    }
  ]
  
  Response:
  [
    {
      "idUsuario": 0,
      "gradoConfianzaFinal": 0
    }
  ]

POST https://localhost:8000/GradoDeConfianza/Comunidades

  RequestBody:
  [
    {
      "idComunidad": 0,
      "gradosConfianzaUsuarios": [
        0
      ]
    }
  ]
  
  Response:
  [
    {
      "idComunidad": 0,
      "gradoConfianzaFinal": 0
    }
  ]
