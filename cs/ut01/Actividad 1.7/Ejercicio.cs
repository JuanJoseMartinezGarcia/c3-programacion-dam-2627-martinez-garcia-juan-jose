double numero1 = -10;
double numero2 = -6.5;

Console.WriteLine("Primer numero: " + numero1);
Console.WriteLine("Segundo numero: " + numero2);

double suma = numero1 + numero2;
double resta = numero1 - numero2;
double multiplicacion = numero1 * numero2;
double division = numero1 / numero2;

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicacion: " + multiplicacion);
Console.WriteLine("Division: " + division);

bool es_cero = numero1 == 0;
bool es_negativo = numero1 < 0;
bool es_menor_que_10 = numero1 < 10;
bool es_mayor_igual_100 = numero1 >= 100;
bool esta_entre_5_y_10 = numero1 >= 5 && numero1 <= 10;

Console.WriteLine("Es cero: " + es_cero);
Console.WriteLine("Es negativo: " + es_negativo);
Console.WriteLine("Es menor que 10: " + es_menor_que_10);
Console.WriteLine("Es mayor o igual que 100: " + es_mayor_igual_100);
Console.WriteLine("Esta entre 5 y 10: " + esta_entre_5_y_10);