# Calculadora Docker

Ejercicio de un servicio REST en AspNet Core 2.0 para la implementación de una calculadora con las operaciones de SUMA, RESTA, MULTIPLICACION y DIVISION.

La calculadora recibe por parámetros la cantidad N de numeros que se usarán en la operación soliciada. 

## Métodos:
* Sumar
```
http://localhost:7593/api/v1/calculator/add/1/5/8
```
* Restar
```
http://localhost:7593/api/v1/calculator/subs/1/5/8
```
* Multiplicar
```
http://localhost:7593/api/v1/calculator/mult/1/5/8
```
* Dividir
```
http://localhost:7593/api/v1/calculator/div/1/5/8
```

## Control de errores
Los métodos pueden validar que los parámetros sean numéricos y viables para realizar la operación solicitada (Incluyendo la división por cero para tipos **double**).
También permiten valores negativos y de punto flotante para la operación solicitada.

## Docker
Le ejercicio cuenta con el archivo **Dockerfile** para poderlo subir a contenedores **Docker** y poder experimentar.

Comandos para bajar la imagen docker ubicada en DockerHub
```
$ docker pull joac89/calculator
```

Comandos para subir el contenedor
```
$ sudo docker run -ti -p 7593:80 joac89/calculator
```

