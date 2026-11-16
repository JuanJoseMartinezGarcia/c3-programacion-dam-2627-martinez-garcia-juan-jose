const unsigned long BLINK_MS = 500; //3.1

const byte LED_IZQ = 2; //3.2
const byte LED_DER = 3; //3.2
const byte BOTON_IZQ = 4;
const byte BOTON_DER = 5;
const byte PULSADO = HIGH;

const byte ESTADO_TODO_APAGADO = 0;
const byte ESTADO_PARPADEA_IZQUIERDA = 1;
const byte ESTADO_PARPADEA_DERECHA = 2;
const byte ESTADO_EMERGENCIA = 3;

byte estado;
bool botonesLibres = true;
bool ledEncendido = false;
unsigned long ultimoCambio = 0;

void setup() // Runs only once, at startup
{
  pinMode(LED_IZQ, OUTPUT);
  pinMode(LED_DER, OUTPUT);
  pinMode(BOTON_IZQ, INPUT);
  pinMode(BOTON_DER, INPUT);

  estado = ESTADO_TODO_APAGADO;
}

void loop() // Runs continuously after setup()
{
  bool izq = digitalRead(BOTON_IZQ) == PULSADO;
  bool der = digitalRead(BOTON_DER) == PULSADO;

  if (botonesLibres && (izq || der))
  {
    delay(50);
    izq = digitalRead(BOTON_IZQ) == PULSADO;
    der = digitalRead(BOTON_DER) == PULSADO;

    if (izq && der)
    {
      if (estado == ESTADO_EMERGENCIA) estado = ESTADO_TODO_APAGADO;
      else estado = ESTADO_EMERGENCIA;
    }
    else if (izq)
    {
      if (estado == ESTADO_PARPADEA_IZQUIERDA) estado = ESTADO_TODO_APAGADO;
      else estado = ESTADO_PARPADEA_IZQUIERDA;
    }
    else if (der)
    {
      if (estado == ESTADO_PARPADEA_DERECHA) estado = ESTADO_TODO_APAGADO;
      else estado = ESTADO_PARPADEA_DERECHA;
    }

    botonesLibres = false;
    ledEncendido = true;
    ultimoCambio = millis();
  }
  else if (!izq && !der)
  {
    botonesLibres = true;
  }

  if (millis() - ultimoCambio >= BLINK_MS)
  {
    ledEncendido = !ledEncendido;
    ultimoCambio = millis();
  }

  if (estado == ESTADO_TODO_APAGADO)
  {
    digitalWrite(LED_IZQ, LOW);
    digitalWrite(LED_DER, LOW);
  }
  else if (estado == ESTADO_PARPADEA_IZQUIERDA)
  {
    digitalWrite(LED_IZQ, ledEncendido ? HIGH : LOW);
    digitalWrite(LED_DER, LOW);
  }
  else if (estado == ESTADO_PARPADEA_DERECHA)
  {
    digitalWrite(LED_IZQ, LOW);
    digitalWrite(LED_DER, ledEncendido ? HIGH : LOW);
  }
  else if (estado == ESTADO_EMERGENCIA)
  {
    digitalWrite(LED_IZQ, ledEncendido ? HIGH : LOW);
    digitalWrite(LED_DER, ledEncendido ? HIGH : LOW);
  }
}