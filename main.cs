using System;

class MainClass {
  public static void Main (string[] args) {

    // Informações para cadstro da Consulta

    cria_cadastro novo_usuario = new cria_cadastro();
    Console.Write("Digite Seu Nome >> ");
   
    novo_usuario.set_nome(Console.ReadLine());           
    
    Console.Write("Insira seu email >>");
    novo_usuario.set_email(Console.ReadLine());          
    
    Console.Write("Insira seu telefone >>");
    novo_usuario.set_telefone(int.Parse(Console.ReadLine()));
    
    Console.Write("Insira sua cidade >>");
    novo_usuario.set_cidade(Console.ReadLine());
    
    Console.Write("Insira seu Bairro >>");
    novo_usuario.set_bairro(Console.ReadLine());
    
    Console.Write("Insira seu estado >>");
    novo_usuario.set_estado(Console.ReadLine());
    
    Console.Write("Escolha a especialidade para Atendimento: \n1-Alergia e Imunologia - R$ 100,00\n2-Cirurgia Geral - R$ 69.00\n3-Cardiologia - R$ 78.00\n4-Ginecologia - R$ 95.00\n5-Neurologia - R$ 120.00\n6-Nutrologia - R$ 95.00\n7-Oftalmologia - R$ 95.00\n8-Ortopedia e Traumatologia - R$ 95.00\n9-Otorrinolaringologia - R$ 82.00\n10-Pediatria - R$ 98.00\n11-Psiquiatria - R$ 120.00\n >>");
    novo_usuario.set_especialidade(int.Parse(Console.ReadLine()));
    
    Console.Write("Possui plano de Saude ? (Desconto 15%)  \n1 - Sim / 2 - Não >>");
    novo_usuario.set_plano(int.Parse(Console.ReadLine()));

    Console.Write("Insira a data da Consulta >>");
    novo_usuario.set_data_consulta(Console.ReadLine());
  
    Console.Write("Insira o Horario para Consulta >>");
    novo_usuario.set_horario_consulta(Console.ReadLine());

    Console.Write("Insira a data de Nascimento >>");
    novo_usuario.set_data_nascimento(Console.ReadLine());

    Console.Write("Insira seu Sexo >> ");
    novo_usuario.set_sexo(Console.ReadLine());

    //Calculo do Orçamento

    

    Console.WriteLine(orca.calculo_consu(novo_usuario.get_plano(),novo_usuario.get_especialidade()));
    
  }
}