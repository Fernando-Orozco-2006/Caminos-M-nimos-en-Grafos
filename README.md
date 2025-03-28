# Caminos-M-nimos-en-Grafos
La actividad de Caminos Mínimos de Grafos con C#, realizado para la clase de estructura de datos.

README:

## Descripción
Este programa realizado en C# perimite el usuario en definir grafos dirigidos y ponderados, a lado de visualizar la matriz de adyacencia y realizar la ejecución de Floyd-Warshall para ayudar encontrar las distancias más cortas entre todos los pares de nodos que sean insertados al programa.

Deja el usuario ingresar una cantidad cualquiera de nodos y aristas, que seran necesarias para poder insertar el tipo de origen, destino y peso que tendra la matriz, y asi poder encontrar el resultado de los caminos más cortos de la matriz creada con los datos insertados.

## Uso
1. Ejecutar el programa.
2. Ingresar el número de nodos y aristas.
3. Definir conexiones (origen, destino y peso).
4. Ver la matriz de adyacencia y los resultados de Floyd-Warshall.

## Ejemplo
Aqui se muestra un ejemplo del tipo de resultados que puedes obtener al utilizar el programa;

- Entrada:
```
Nodos: 4, Aristas: 5
0 1 5
0 2 10
1 2 3
1 3 2
2 3 1
```
- Salida:
```
Matriz de distancias más cortas:
0 5 8 7
INF 0 3 2
INF INF 0 1
INF INF INF 0
```
## Algoritmo Floyd-Warshall
Este algoritmo ayuda a encontrar las distancias más cortas entre todos los pares de nodos con complejidad **O(V³)**, ya que implementa las funciones de Dijkstra y Warshall para agregar su interfaz gráfica e importar los grafos utilizados desde sus respectivos archivos.
