#define BUTTON 2
#define LED 13

#define ESTADO_INICIAL 0
#define ESTADO_ESPERANDO_LUZ 1
#define ESTADO_LUZ_ENCENDIDA 2

byte estado = ESTADO_INICIAL; // nos ayuda a saber en qué momento pulsamos el botón, para actuar según dicho estado
bool boton_pulsado = false; // nos ayuda a detectar que el botón no estaba pulsado, de forma que sólo atendamos su pulsación una vez, hasta que se vuelva a liberar
int ticks = 0;

void setup()
{  
  pinMode(BUTTON, INPUT_PULLUP);
  pinMode(LED, OUTPUT);
  digitalWrite(LED,LOW);
  Serial.begin(9600);
  randomSeed(analogRead(A0));
  Serial.println("Pulsa el botón para iniciar. Permanece atento y pulsa el botón tan rápido como veas que se enciende la luz.");
}

void loop()
{
  //evitamos que se sobrecarge el emulador
  delay(10);
  // si se pulse el botón 
  if (!digitalRead(BUTTON))
  {
    if (!boton_pulsado) // si previamente no estaba pulsado
    {
      boton_pulsado = true; // recordamos que se ha pulsado, para evitar que el switch se ejecute repetidamente      
      switch (estado)
      {
        case ESTADO_INICIAL:
          Serial.println("Has pulsado en estado inicial.");
          ticks = random(200, 501);
          estado = ESTADO_ESPERANDO_LUZ;
          break;
        case ESTADO_ESPERANDO_LUZ:
          Serial.println("Has perdido por adelantarte al encendido");
          estado = ESTADO_INICIAL;
          break;
        case ESTADO_LUZ_ENCENDIDA:
          Serial.print("Has tardado ");
          Serial.print(-ticks);
          Serial.println(" centésimas");
          digitalWrite(LED, LOW);
          estado = ESTADO_INICIAL;
          break;
      }
    }    
  }
  else if (boton_pulsado) // borramos el flag de botón pulsado
  {
    boton_pulsado = false;
  }

  if (estado != ESTADO_INICIAL)
  {
    ticks--;

    if (estado == ESTADO_ESPERANDO_LUZ && ticks == 0)
    {
      digitalWrite(LED, HIGH);
      estado = ESTADO_LUZ_ENCENDIDA;
    }
    else if (estado == ESTADO_LUZ_ENCENDIDA && ticks == -200)
    {
      Serial.println("Has perdido por no actuar sobre el botón durante demasiado tiempo");
      digitalWrite(LED, LOW);
      estado = ESTADO_INICIAL;
    }
  }
}