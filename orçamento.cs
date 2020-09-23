using System;

class orca{

  public static string calculo_consu(int especialidade,int plano){
    double valor_consul;

    switch(especialidade){
      
      case 1:
        if (plano == 1){
          return $"O Valor da Consulta com desconto >> {100-(100*0.15)}";
        }
        else
          return $"O Valor da Consulta Integral >> {100}";
      
      case 2:
        if (plano == 1){
        return Console.Write($"O Valor da Consulta com desconto >> {69-(69*0.15)}");
        
        }
        else
          return Console.Write($"O Valor da Consulta Integral >> {69}");

      case 3:
          if (plano == 1){
          return Console.Write($"O Valor da Consulta com desconto >> {78-(78*0.15)}");
          
          }
          else
            return Console.Write($"O Valor da Consulta Integral >> {78}");

      case 4:
          if (plano == 1){
          return Console.Write($"O Valor da Consulta com desconto >> {95-(95*0.15)}");
          
          }
          else
            return Console.Write($"O Valor da Consulta Integral >> {95}");
      
      
      
    }
  }
}