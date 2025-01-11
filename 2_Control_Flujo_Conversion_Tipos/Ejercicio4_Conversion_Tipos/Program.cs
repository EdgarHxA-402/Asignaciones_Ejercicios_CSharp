Console.WriteLine("CINVERSION DE TIPOS");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// ENTRADA ENTERO
Console.Write("Ingresa un número entero: ");
int numeroEntero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// A DECIMAL
decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
Console.WriteLine($"Número convertido a decimal: {numeroDecimal}");
Console.WriteLine();

// DEVUELTA A ENTERO
int numeroConvertido = Convert.ToInt32(numeroDecimal);
Console.WriteLine($"Número convertido de nuevo a entero: {numeroConvertido}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Las conversiones explícitas son útiles en varios casos:\r\n - Preservar precisión: Para trabajar con fracciones en operaciones financieras.\r\n - Reducción de datos: Para simplificar resultados o ahorrar espacio al convertir decimales a enteros.\r\n - Prevención de errores: Para evitar pérdida de datos al convertir tipos más grandes (double, decimal) a más pequeños (int).\r\n");

