#define LEDR 4 // led rojo
#define LEDA 3 // led amarillo
#define LEDV 2 // led verde
#define BTN1 7 // botón de pulsación

void setup() //Método que se ejecuta al inicio
{
  //Establecer modos de cada puerto
  //Salidas para leds
  pinMode(LEDR, OUTPUT);
  pinMode(LEDA, OUTPUT);
  pinMode(LEDV, OUTPUT);
  //Entrada para botón
  pinMode(BTN1, INPUT);

  //Apagar todos leds inicialmente
  digitalWrite(LEDR,LOW);
  digitalWrite(LEDA,LOW);
  digitalWrite(LEDV,LOW);
}

void loop() // Método que se ejecuta en bucle
{
  if (digitalRead(BTN1))
  {
    for (int i=0;i<5;i++)
    {
      digitalWrite(LEDR, HIGH);
      delay(300);
      digitalWrite(LEDR, LOW);
      delay(300);
    }
  }
  
}

// 1. Los #define sirven para poner un nombre a un número, por ejemplo LEDR
// en vez de 4. Así es más fácil saber qué es cada pin.

// 2. setup() sirve para configurar los pines y apagar los leds al empezar.
// Se ejecuta solo una vez cuando se enciende el Arduino.

// 3. loop() es donde va el programa principal. Se ejecuta después de setup()
// y se repite todo el rato.

// 4. pinMode() dice si un pin es de entrada o de salida.
// digitalWrite() enciende (HIGH) o apaga (LOW) un pin.
// digitalRead() lee si el botón está pulsado o no.
// delay() hace que el programa espere un tiempo en milisegundos.

// 5. Cuando se pulsa el botón, el led rojo parpadea 3 veces (medio segundo
// encendido y medio apagado). Se usa un if para ver si el botón está
// pulsado y un for para repetir el parpadeo 3 veces.