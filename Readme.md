# Layout

# Proyecto 1

Estos nos ayudan a agrupar y organizar los controles de interfaz de usuario.

![1698429860784](image/Seccion4Layout/1698429860784.png)

## Stack layout `<StackLayout>` `</StackLayout>`

Este tipo organiza los elementos de forma unidimensional, ya que verticalmente o horizontalmente

# Propiedades para etiquetas XAML

| Etiqueta          | Description                               | col3 |
| ----------------- | ----------------------------------------- | ---- |
| HorizontalOptions |                                           |      |
| Spacing           | Espaciado entre cada uno de los elementos |      |
|                   |                                           |      |
|                   |                                           |      |
|                   |                                           |      |
|                   |                                           |      |
|                   |                                           |      |
|                   |                                           |      |

# Resultado final

![1698494746224](image/Seccion4Layout/1698494746224.png)

# Proyecto 2 - VerticalStackLayout y HorizontalStackLayout

Cuando tegamos un contenedor y quieramos que los elementos se pongan
de forma vertical o horizontal, lo podemos hacer con las etiquetas
`<VerticalStackLayout>` o  `<HorizontalStackLayout>` ya que estos estan optimizados.

* Vertical Stack Layout

![1698498321510](image/Seccion4Layout/1698498321510.png)

* Horizontal Stack Layout

![1698498438402](image/Seccion4Layout/1698498438402.png)

# Proyecto 3 - Grid Layout

* Grid Layout
  Tipo de layout que organiza los diferentes tipos de controles en filas y columnas
  que pueden tener tamaños proporcionales o absolutos, por defecto
  este contiene una fila y una columna y ademas puede utilizarse como un diseño
  padre que pueda tener otros diseños hijos

  ![1698499592173](image/Seccion4Layout/1698499592173.png)

  ![1698499803922](image/Seccion4Layout/1698499803922.png)
* A Traves de la propiedad Grid.Row y Grid.Column podemos indicarle al elemento su posicion

  ![1698500058176](image/Seccion4Layout/1698500058176.png)
* Si queremos que una columna ocupe el ancho de 2 columnas se puede hacer a traves de `Grid.ColumnSpan o Grid.RowSpan` y esta propiedad toma las columnas hacia la derecha o filas hacia abajo

  ![1698500356023](image/Seccion4Layout/1698500356023.png)
* Tambien podemos especificar un tamaño a las filas con la propiedad `Height` y columnas con `Width` y el valor pueden ser

  * Unidades
  * `Auto` - Solo toma el espacio de los elementos dentro de la fila
  * `*` - Con este valor estrella indicamos que utilize todo el espacio disponible
  * `0.6*` - Con este valor especifico un porcentaje, en este caso es 60%
* Para cambiar el tamaño de un elemento ya sea Button, etc. lo
  hacemos con la propiedad `HeightRequest`

  ![1698500989530](image/Seccion4Layout/1698500989530.png)

  ![1698501710337](image/Seccion4Layout/1698501710337.png)
* Otra Forma de especificar filas y columnas
  ![1698502146284](image/Seccion4Layout/1698502146284.png)

# Proyecto 4 - Absolute Layout

Este layout se utiliza para posicionar y dimensionar los controles utilizando
valores explicitos, la posicion se especifica mediante la esquina superior
izquierda de cada uno de los controles en relacion con la esquina superior
izquierda de absolute layout en unidades independientes del dispositivo.

* Para posicionar un elemento con valores absolutos necesitamos acceder a la
  propiedad `AbsoluteLayout.LayoutBounds="ValX, ValY, ValWidth, ValHeight"`

  ![1698546296964](image/Seccion4Layout/1698546296964.png)
* Para posicionar un elemento con porcentajes lo hacemos de la siguiente
  manera `AbsoluteLayout.LayoutFlags="VariosValoresComoConstantes"` y cuando utilizamos este, tambien depende del anterior propiedad.

  ![1698546416190](image/Seccion4Layout/1698546416190.png)
  ![1698546547599](image/Seccion4Layout/1698546547599.png)
* Asi como podemos cambiar las dimensiones, tambien podemos posicionar los elementos

  ![1698546791625](image/Seccion4Layout/1698546791625.png)
* Y si quiseramos que todos los valores fueran proporcionales, deberiamos
  de utilizar el valor de ``All``

  ![1698546954408](image/Seccion4Layout/1698546954408.png)

# Proyecto 5 - FlexLayout

Es un layout que puede organizar los controles horizontalemente y verticalmente
en una pila y tambien pueden volver sus hijos si hay demasiados, para que
quepan en una sola fila o columna.
Este layout puede controlar la orientacion y alineacion y adaptarse a diferentes
tamaños de pantalla

* Tenemos una propiedad en FlexLayout llamada `Direction` al cual le podemos asignar
  * `Column` los elementos se alinearan en una sola columna.
    ![1698554181147](image/Seccion4Layout/1698554181147.png)
  * `ColumnReverse` los elementos son apilados desde la parte inferior hasta la parte
    superior
    ![1698554248700](image/Seccion4Layout/1698554248700.png)
  * `Row` es el valor por default
    ![1698554396834](image/Seccion4Layout/1698554396834.png)
  * `RowReverse`
    ![1698554339338](image/Seccion4Layout/1698554339338.png)

Tenemos tambien la propiedad `AlignItems` y nos va a servir para modificar como
se van a distribuir los diferentes elementos que formen parte del
FlexLayout y podemos utilizar el valor.

* `Stretch` comportamiento por default
  ![1698557902858](image/Seccion4Layout/1698557902858.png)
* `Center` posiciona los elementos en el centro de este FlexLayout
  ![1698557785797](image/Seccion4Layout/1698557785797.png)
* `Start`
  ![1698557724909](image/Seccion4Layout/1698557724909.png)
* `End`
  ![1698557840719](image/Seccion4Layout/1698557840719.png)
* `FlexLayout.Grow = "1"` significa que queremos utilizar todo el espacio disponible entre 2 elementos
* `FlexLayout.Basis="50"` nos permite indicar que queremos que se utilize una cantidad fija, es decir que que queremos que el elemento tenga un
  ancho especifico baso en el valor
  de la propiedad
* `FlexLayout.Order="-1"` la propiedad es para ponerle un orden a los elementos del FlexLayout, y como le ponemos -1 significa que siempre va a a estar ordenado antes de zero. Es decir que queremos posicionarlo los mas a la izquierda que podamos.

![1698559625608](image/Seccion4Layout/1698559625608.png)
