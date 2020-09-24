using System;

class orca{

  public static string calculo_consu(int especialidade,int plano){

    switch(especialidade){
      
      case 1:
        if (plano == 1){
          return $"O Valor da Consulta com desconto >> R${100-(100*0.15)}";
        }
        else
          return $"O Valor da Consulta Integral >> R${100}";
      
      case 2:
        if (plano == 1){
          return $"O Valor da Consulta com desconto >> R${69-(69*0.15)}";
        }
        else
          return $"O Valor da Consulta Integral >> R${69}";

      case 3:
          if (plano == 1){
            return $"O Valor da Consulta com desconto >> R${78-(78*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${78}";

      case 4:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${95-(95*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${95}";
      
      case 5:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${120-(120*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${120}";
      
      case 6:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${95-(95*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${95}";
      
      case 7:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${95-(95*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${95}";
      
      case 8:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${95-(95*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${95}";
      
      case 9:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${82-(82*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${82}";
      
      case 10:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${98-(98*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${98}";
      
      case 11:
          if (plano == 1){
           return $"O Valor da Consulta com desconto >> R${120-(120*0.15)}";
          }
          else
            return $"O Valor da Consulta Integral >> R${120}";
      
      
      default:
        return "Um Valor Indesejado foi inserido";
      
      
      
    }
  }
}