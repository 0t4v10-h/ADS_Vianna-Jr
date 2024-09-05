int segundos;
Console.Write("Total de segundos: ");
segundos = Convert.ToInt32(Console.ReadLine());

Console.Write("{0} segundos corresponde a ", segundos);

int hora; 
int minuto; 
int seg;
int resto;

hora = segundos / 3600;
resto = segundos % 3600;
minuto = resto / 60;
seg = resto % 60;


Console.WriteLine("{0} horas, {1} minutos e {2} segundos", hora, minuto, seg);
