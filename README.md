## Proyecto integrador de la materia Algoritmos y Programación

#### Asignación de proyecto: Proyecto 3, La Biblioteca.

---

### Pautas de desarrollo

**En cada proyecto se espera que:**

- Se haga el **diagrama de clases UML**
- Se diseñe e implemente cada una de las clases completas:
  - Variables de instancia, constructores, propiedades y métodos de instancia básicos (es decir, con los métodos completos aún cuando en la aplicación no se los utilice)
- Se haga la **aplicación** donde se crean y cargan los objetos intervinientes (se puede usar carga desde archivo de texto, NO es obligatorio).
  - Ejemplo: si el proyecto es sobre un supermercado que tiene productos y proveedores, deberán crear el supermercado, cargarle algunos productos y algunos proveedores para luego poder dar respuesta a las opciones del menú solicitado.
  - Si el enunciado no lo solicita, no deben simular atención de clientes y proveedores, ni ventas, ni reposiciones, etc. (para acotar la longitud del desarrollo)
- Se presenta el **menú de opciones solicitado** en el problema y se implementan las funciones que dan respuesta a esos ítems.
  - En la mayoría de los casos, deben desarrollar funciones del Main que invocan a los métodos de las clases diseñadas.
  - En menor escala, se invocan desde el menú los métodos ya implementados en las clases.
  - La idea es que NO pongan adentro de las clases como métodos todos los requerimientos del menú, ya que esto simplifica la solución y personaliza las clases en base al enunciado (y conceptualmente es erróneo). La aplicación debe plantear la lógica de resolución del problema haciendo uso de las clases intervinientes.
- Deben usar **herencia** reflejada en el código y en el diagrama UML.
- Es obligatorio que implementen al menos **un manejador de excepciones**, que se pide explícitamente en cada proyecto. Si desean agregar otros, no hay problema.

---

### Proyecto 3

Una **Biblioteca** tiene un archivo con la información de los libros para préstamo que posee y de los socios lectores. 

- De cada **libro** se almacena su código, título, autor, editorial y estado (prestado o disponible), DNI del socio que lo pidió (0 si no está prestado), fecha del préstamo y fecha de devolución.
- De cada **socio** se registra su DNI, nombre y apellido, teléfono, dirección y cantidad de libros prestados. Solo puede pedir un libro prestado por vez.
- Los **libros se prestan por 15 días**.
- Un **lector de sala** es un socio lector que puede pedir varios libros para leer en la sala y los devuelve antes de retirarse de la biblioteca. Se registra la lista de libros que pide para la sala.

---

### Requerimientos de la Aplicación

La aplicación debe desarrollarse utilizando las clases necesarias, implementando herencia cuando corresponda. Además, debe proveer, mediante un menú, las siguientes funcionalidades:

1. **Agregar un libro nuevo a la biblioteca.** El sistema le asigna un código.
2. **Eliminar un libro de la biblioteca.** Se debe verificar que el libro no esté prestado.
3. **Dar de alta un socio o socio lector.**
4. **Dar de baja un socio o socio lector.**
5. **Prestar un libro:** Se ingresa el DNI del socio solicitante y el código del libro deseado.
   - **I.** Si quien lo pide es un socio lector, el sistema debe verificar que el libro esté disponible y que el socio no tenga ya un libro prestado. En caso de éxito, se modifica el estado del libro y se incrementa el contador de libros del socio. Si el libro está prestado o el socio ya tiene otro libro en préstamo, se debe levantar una excepción indicando que el préstamo no se puede realizar.
   - **II.** Si quien lo pide es un lector de sala, el sistema debe verificar que el libro esté disponible. En caso de éxito, se modifica el estado del libro, se incrementa el contador de libros del socio y se agrega el libro a la lista de libros prestados del socio. Si el libro está prestado, se debe levantar una excepción indicando que el préstamo no se puede realizar.
6. **Devolver un libro:** Se modifica el estado del libro y se actualiza la información en el socio (según corresponda en base a si es un socio lector o un lector de sala).
7. **Submenú de impresión:** Listado de libros prestados, de libros de la biblioteca y de socios.

