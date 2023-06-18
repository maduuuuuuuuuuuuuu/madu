int numero;
Console.WriteLine("digite um numero");
numero =Convert.ToInt32(Console.ReadLine());
int resultado;
resultado =numero % 2;
if (resultado== 0){
    Console.WriteLine($"{numero} é par");
}
else{
    Console.WriteLine($"{numero} é impar");
}