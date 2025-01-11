Console.WriteLine("CALCULADORA BASICA");

// VARIABLES

double num1, num2;  
char operador;

        
// ENTRADA
        
Console.Write("Ingresa el primer número: ");   
num1 = Convert.ToDouble(Console.ReadLine());      
Console.Write("Ingresa el segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresa el operador (+, -, *, /): ");        
operador = Console.ReadKey().KeyChar;
Console.WriteLine();  



// CASE SEGUN EL OPERADOR

            
    switch (operador)
            
    
{     
    case '+':
 
        Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                  
       break;
                
        
    case '-':
 
        Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
    break;
                
        
    case '*':
                    
            
        Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
    break;
                
        
    case '/':
                    
            
        if (num2 == 0)
                    
            
        {
                        
                
            Console.WriteLine("Error: No se puede dividir por cero.");
                    
            
        }
                    
            
        else
                    
            
        {

            Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
        }        
    break;


    default:
        Console.WriteLine("Operador no válido. Usa +, -, * o /.");
    break;

}
  

