// Juan José Martínez García
// Definición de pins utilizados
#define BTN1 3
#define LED1 4
#define LED2 5

#define BLINK_MS 200 // Periodo de tiempo de parpadeo

// Estados en los que pueden estar las luces
#define EST_APAGADO    0
#define EST_FIJO_1     1
#define EST_FIJO_2     2
#define EST_PARPADEO_1 3
#define EST_PARPADEO_2 4

int estado;

void setup()
{
  estado = EST_APAGADO;
  // Configuración de pines como entrada o salida
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);

  // Inicialmente, ambos LED estarán apagados
  digitalWrite(LED1, LOW);
  digitalWrite(LED2, LOW);
  Serial.begin(9600);
  
}

void loop()
{
  delay(10); // Pequeña espera para no saturar el emulador
  CheckBtn1();
  

  if (!digitalRead(BTN1))
  {
    // Encender ambos LED
    digitalWrite(LED1, HIGH);
    digitalWrite(LED2, HIGH);
    delay(BLINK_MS);
    // Apagar ambos LED
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, LOW);
    delay(BLINK_MS);
    // Espera a que el botón se libere, para seguir
    EsperaBtn1();
    delay(10);
    
  }

}

// Queda esperando en bucle hasta que el botón se suelta
void EsperaBtn1()
{
  do
  {
    delay(10); // entre comprobación y comprobacion espera un poco
  }
  while (!digitalRead(BTN1));
}


void CheckBtn1()
{
  delay(10); 
  if (!digitalRead(BTN1))
  {
  
    for(int estado = 0; estado < 5; estado++)
    {
      delay(100);
      Serial.println(estado);
    if(estado==0)
    {
      digitalWrite(LED1, LOW);
      digitalWrite(LED2, LOW);
    }
    else if(estado==1)
    {
      digitalWrite(LED1, HIGH);
      digitalWrite(LED2, LOW);

    }
    else if(estado==2)
    {
      digitalWrite(LED1, HIGH);
      digitalWrite(LED2, HIGH);
    }
    else if(estado==3)
    {
      digitalWrite(LED1, HIGH);
      digitalWrite(LED2, HIGH);
      delay(BLINK_MS);
      digitalWrite(LED1, LOW);
      digitalWrite(LED2, LOW);
    }
    else if(estado==4)
    {
      digitalWrite(LED1, LOW);
      digitalWrite(LED2, HIGH);
      delay(BLINK_MS);
      digitalWrite(LED1, HIGH);
      digitalWrite(LED2, LOW);
    }
    }

    
    EsperaBtn1();
  }



}