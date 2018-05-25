# Calculadora Docker

Ejercicio de un servicio REST en AspNet Core 2.0 para la implementación de una calculadora con las operaciones de SUMA, RESTA, MULTIPLICACION y DIVISION.

La calculadora recibe por parámetros la cantidad N de numeros que se usarán en la operación soliciada. 

## Métodos:
* Sumar
```
http://localhost:5326/api/v1/calculator/add/1/5/8
```
* Restar
```
http://localhost:5326/api/v1/calculator/subs/1/5/8
```
* Multiplicar
```
http://localhost:5326/api/v1/calculator/mult/1/5/8
```
* Dividir
```
http://localhost:5326/api/v1/calculator/div/1/5/8
```

## Control de errores
Los métodos pueden validar que los parámetros sean numéricos y viables para realizar la operación solicitada (Incluyendo la división por cero para tipos **double**).
También permiten valores negativos y de punto flotante para la operación solicitada.


## Acerca de
* version: 1.0.0
* Autor: Joac Aguilar - joac.aguilar@hotmail.com
