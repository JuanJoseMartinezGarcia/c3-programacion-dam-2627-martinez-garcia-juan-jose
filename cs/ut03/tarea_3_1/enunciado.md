# UT03 – Tarea 1. Estructuras de control y tratamiento de excepciones

En esta tarea deberás desarrollar los diferentes apartados del enunciado, utilizando las estructuras de control indicadas en cada uno de ellos. El proyecto inicial incluye un archivo `Program.cs` con espacios reservados para implementar el código correspondiente.

**Puedes resolver los apartados en el orden que prefieras.** No es necesario seguir la secuencia `a`, `b`, `c`… ni realizar los commits en ese orden.

No obstante, se recomienda realizar **un único commit por apartado**, utilizando la descripción indicada en el enunciado e incluyendo exclusivamente los cambios relacionados con ese apartado. De esta forma, cada commit permitirá identificar y evaluar fácilmente el trabajo realizado.

### Apartado a. Preparación del proyecto

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| a.1 | Copia el directorio `src/cs/ut03/tarea_3_1` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. |
| **Commit:** | `UT03T1a Copiado proyecto proporcionado por el profesor` |

### Apartado b. Estructuras condicionales

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| b.1 | Comprueba que la cadena introducida por el usuario tenga **exactamente un carácter** (ver TIP 1). En caso contrario, muestra por consola el mensaje `"Debes introducir solo una letra"`. |
| b.2 | Mejora el apartado anterior para que el mensaje de error sea diferente según el caso: muestra `"No puedes dejar el texto en blanco"` si la cadena está vacía, o `"No puedes indicar un texto con más de una letra"` si contiene más de un carácter. |
| b.3 | Mejora el programa para que, **en el caso de no detectar los errores previos**, muestre por consola el mensaje `"Tu letra en mayúscula es X"`, donde `X` será la letra introducida convertida a mayúscula mediante `letra.ToUpper()`. |
| **Commit:** | `UT03T1b Condicionales` |

### Apartado c. Bucle `for`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| c.1 | Utiliza un bucle `for` para mostrar por consola **una cuenta atrás de porcentajes, descendiendo de 10 en 10**, desde `"100%"` hasta `"0%"`, ambos incluidos. Cada porcentaje deberá aparecer en una línea independiente. **Una vez finalizado el bucle**, muestra el mensaje `"Finalizado"`. |
| c.2 | Mejora el programa para que solicite al usuario **cuánto debe disminuir el porcentaje en cada paso**. Por ejemplo, si introduce `5`, la cuenta atrás será `100%`, `95%`, `90%`… **El bucle deberá finalizar cuando el valor actual sea igual o inferior al número introducido por el usuario**, evitando que se muestren porcentajes negativos. |
| **Commit:** | `UT03T1c Bucle for` |

### Apartado d. Bucle `while`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| d.1 | Utiliza un bucle `while` para solicitar repetidamente al usuario que introduzca una palabra y **mostrar por consola su longitud (número de caracteres)**. El bucle deberá finalizar cuando el usuario introduzca una cadena vacía (`""`). |
| d.2 | Mejora el programa para que, en cada iteración, además de mostrar la longitud de la palabra introducida, **muestre la longitud total acumulada**, sumando las longitudes de todas las palabras introducidas hasta ese momento. |
| **Commit:** | `UT03T1d Bucle while` |

### Apartado e. Bucle `do-while`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| e.1 | Utiliza un bucle `do-while` para solicitar repetidamente al usuario que introduzca **números enteros**. El bucle deberá finalizar cuando se cumpla **cualquiera de estas dos condiciones**: que el número introducido sea `0` o que la suma acumulada de todos los números introducidos sea **mayor que 100**. |
| e.2 | Mejora el programa para que, al finalizar el bucle, muestre **cuánto ha sobrepasado la suma acumulada el valor 100**. Por ejemplo, si se introducen `20`, `30`, `40` y `25` (que suman `115`), deberá mostrar `"Sobran 15"`. |
| **Commit:** | `UT03T1e Bucle do-while` |

### Apartado f. Combinación de condicionales y bucles

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| f.1 | Utiliza el bucle que prefieras para solicitar repetidamente al usuario que introduzca una palabra (`string`), hasta que introduzca una cadena vacía (`""`). En cada iteración, **ignora los textos que contengan espacios** (ver TIP 2). Si el texto no contiene espacios, considéralo válido y muestra por consola si la palabra es `"larga"` o `"corta"` (menos de 8 caracteres, por ejemplo), antes de solicitar la siguiente. |
| f.2 | Mejora el programa definiendo dos **constantes enteras**, llamadas `LONG_RANGO1` y `LONG_RANGO2`, con valores `5` y `10`, respectivamente. Utilízalas para clasificar las palabras válidas en tres categorías: `"corta"` (menos de 5 caracteres), `"media"` (entre 5 y 10 caracteres, ambos incluidos) y `"larga"` (más de 10 caracteres). Muestra por consola la categoría correspondiente a cada palabra. |
| **Commit:** | `UT03T1f Condicionales y bucles combinados` |

### Apartado g. Tratamiento de excepciones (`try-catch-finally`)

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| g.1 | Incorpora la **captura de excepciones** necesaria para evitar que el programa aborte su ejecución si se produce algún error. En ese caso, deberá mostrar por consola el mensaje `"Los datos indicados no son válidos"`. |
| g.2 | Mejora el programa utilizando `finally` para garantizar que, **se produzca o no algún error**, siempre se muestre por consola el mensaje `"El procedimiento de reparto ha finalizado, compruebe si hay errores:"`. |
| **Commit:** | `UT03T1g Tratamiento de excepciones` |

### TIPS

**TIP 1. Longitud de una cadena**

Recuerda que, en C#, la propiedad `Length` devuelve el número de caracteres de una cadena.

Por ejemplo, si `letra` es una variable de tipo `string`, puedes consultar su longitud mediante `letra.Length`.

**TIP 2. Comprobar si una cadena contiene otra subcadena**

En C#, el método `Contains()` permite comprobar si una cadena contiene un texto determinado. Devuelve `true` si lo encuentra y `false` en caso contrario.

Por ejemplo, para comprobar si la variable `palabra` contiene algún espacio:

```csharp
palabra.Contains(" ")
```

Esta expresión devuelve `true` si encuentra al menos un espacio dentro de `palabra`, y `false` si no contiene ninguno.
