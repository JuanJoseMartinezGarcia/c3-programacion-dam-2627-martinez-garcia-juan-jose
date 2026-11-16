#define LED 13
#define HCSR04_TRIGGER 10
#define HCSR04_ECHO 9
#define ESPERA_ENCENDIDO 100
#define ESPERA_MS_POR_CM 2

void setup()
{
  pinMode(LED,OUTPUT);
  pinMode(HCSR04_TRIGGER,OUTPUT);
  pinMode(HCSR04_ECHO,INPUT);
  digitalWrite(LED,LOW);
  digitalWrite(HCSR04_TRIGGER,LOW);  
  Serial.begin(9600);
}

void loop()
{
  int distancia = round(GetDistancia());
  Serial.println(distancia);
  digitalWrite(LED, HIGH);
  delay(ESPERA_ENCENDIDO);
  digitalWrite(LED, LOW);
  delay(distancia * ESPERA_MS_POR_CM);
}


float GetDistancia()
{
  // manda un pulso cuadrado de 10ms por el pin del trigger
  digitalWrite(HCSR04_TRIGGER, LOW);
  delayMicroseconds(2);
  digitalWrite(HCSR04_TRIGGER, HIGH);
  delayMicroseconds(10);
  digitalWrite(HCSR04_TRIGGER, LOW);
  // pasa a escuchar el eco de ese pulso
  float duration = pulseIn(HCSR04_ECHO, HIGH);
  float distance = (duration*.0343)/2;  
  return distance;
}