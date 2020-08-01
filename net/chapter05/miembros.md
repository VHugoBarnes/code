# Entendiendo miembros

Los miembros pueden ser campos, metodos, o versiones especializadas de ambas. Vas a encontrar una descripción de ellos debajo.   

- **Campos**, son usados para almacenar datos. También hay tres categorías especializadas de campo, como se muestra a continuación.   
    * **Constante**: Los datos nunca cambian. El compilador literamente copia el dato a cualquier código que lo lea.
    * **Sólo lectura**: El dato no puede cambiar después de que la clase está instanciada, pero el dato puede ser calculado o cargado de una fuente externa al momento de la instanciación.
    * **Evento**: El dato referencía a uno o más métodos que quieres ejecutar cuando algo ocurra, como oprimir un botón, o responder a una petición de otro código.
- **Métodos**, son usados para ejecutar sentencias. Hay cuatro categorías especializadas del método.
    * **Constructor**: Las sentencias se ejecutan cuando utilizas la palabra clave `new` para asignar memoria e instanciar una clase.
    * **Propiedad**: Las sentencias se ejecutan cuando obtienes o estableces datos. Los datos comunmente están almacenados en un campo, pero pueden ser almacenados externamente o calculados en tiempo de ejecución. Las **Propiedades** son la manera preferida de encapsular campos a menos de que la dirección de memoria del campo necesite estar expuesta.
    * **Indexer (indexador)**: Las sentencias se ejecutan cuando obtienes o estableces datos usando la sintaxis del array [].
    * **Operador**: Las sentencias se ejecutan cuando usas un operador como + y / en operandos de tu tipo.