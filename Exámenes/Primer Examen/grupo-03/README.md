# Primer Parcial - Grupo 03

> 1.-Realice una aplicación en Windows Forms que le permita calcular el área de un cuadrado,
rectángulo, triangulo o una circunferencia, el usuario deberá poder seleccionar la forma para la cual quiere
Calcular el área. Validar que todos los datos sean ingresados y que estén en el formato válido. (60 ptos)

<b>Cuadrado:</b> A= lado*lado

<b>Rectángulo:</b> A=base*altura

<b>Triangulo:</b> A=base*altura/2

<b>Circunferencia:</b> A= PI * radio * radio


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

## Para crear la interfaz de usuario se usaron los siguientes controles :

* <b>cbForma</b> : "ComboBox" utilizado para contener las lista de Formas existentes("Cuadrado","Rectángulo",etc).

* <b>pbFormula</b> : "PictureBox" utilizado para visualizar la fotografia correspondiente a la fórmula de una determinada figura.

* <b>npN1</b> : "NumericUpDown" utilizado para introducir un número.

* <b>npN2</b> : "NumericUpDown" utilizado para introducir un número.

* <b>btnCalcular</b> : "Button" utilizado para Calcular el area de una determinada figura.