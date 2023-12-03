using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade19
    {
          public void atividade_19()
          {
              int a = 0;
              int b = 0;
              int c = 0;

              Console.WriteLine("Informe o valor do lado a: ");
              a = int.Parse(Console.ReadLine());

              Console.WriteLine("Informe o valor do lado b: ");
              b = int.Parse(Console.ReadLine());

              Console.WriteLine("Informe o valor do lado c: ");
              c = int.Parse(Console.ReadLine());

              if (a < (b + c) && b < (a + c) && c < (a + b))
              {
                  if (a == b && b == c)
                  {
                      Console.WriteLine("Triangulo equilatero.");
                  }
                  else if (a == b || a == c || b == c)
                  {
                      Console.WriteLine("Triangulo isosceles.");
                  }
                  else
                  {
                      Console.WriteLine("Triangulo escaleno.");
                  }
              }
                  
              else
              {
                  Console.WriteLine("Os valores fornecidos não caracterizam um triângulo.");
              }

              Console.ReadKey();
          }
     }
}

