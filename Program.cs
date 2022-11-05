Console.WriteLine("Números pares entre 0 e ? ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());


if (numeroDigitado >=1 )
{
   int numeropar = 0;

    while (numeropar <= numeroDigitado)
     {
      Thread.Sleep(500);
       Console.WriteLine($"{numeropar}"); 
       numeropar += 2; 
      

    }
                 
}
else
{
   Console.WriteLine($"o numero{numeroDigitado}não é possivel .");
}

Console.WriteLine("tchau  !!");
Thread.Sleep(500);
Console.WriteLine("e");
Thread.Sleep(650);
Console.WriteLine("obrigado !!");
Thread.Sleep(500);

