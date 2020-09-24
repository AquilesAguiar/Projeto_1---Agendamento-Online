class comprovante{
  public static string gera_compro(string nome,string horario,string data_consul,int especialidade){

    switch(especialidade){
      case 1:
        return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Alergia e Imunologia";
        
       
      
      case 2:
         return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Cirurgia Geral";
       

      case 3:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Cardiologia";
          

      case 4:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Ginecologia";
         
      
      case 5:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Neurologia";
         
      
      case 6:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Nutrologia";
        
      
      case 7:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Oftalmologia";
         
      
      case 8:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Ortopedia e Traumatologia";
          
      
      case 9:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Otorrinolaringologia";
         
      
      case 10:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Pediatria";
          
      
      case 11:
       return $"{nome} terá uma consulta no dia {data_consul} as {horario} na especialidade Psiquiatria";
         
      
      
      default:
        return "Um Valor Indesejado foi inserido";
    }

   



  }

}