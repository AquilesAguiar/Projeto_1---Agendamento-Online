class  cria_cadastro {
  //Atributos
  private string nome,data_nascimento,email,cidade,bairro,estado,sexo,horario_consulta,data_consulta;

  private int telefone,especialidade,plano;

  //sets

  public void set_nome(string valor_nome){
    nome = valor_nome;
  }
  public void set_data_nascimento(string valor_data_nas){
    data_nascimento = valor_data_nas;
  }
  public void set_email(string valor_email){
    email = valor_email;
  }
  public void set_cidade(string valor_cidade){
   cidade = valor_cidade;
  }
  public void set_bairro(string valor_bairro){
    bairro = valor_bairro;
  }
  public void set_estado(string valor_estado){
    estado = valor_estado;
  }
  public void set_sexo(string valor_sexo){
    sexo = valor_sexo;
  }
  public void set_horario_consulta(string valor_horario_consulta){
    horario_consulta = valor_horario_consulta;
  }
  public void set_data_consulta(string valor_data_consulta){
  data_consulta= valor_data_consulta;
  }
  public void set_telefone(int valor_telefone){
    telefone = valor_telefone;
  }
 
  public void set_especialidade(int valor_especialidade){
   especialidade = valor_especialidade;
  }

  public void set_plano(int valor_plano){
   plano = valor_plano;
  }

  //Gets

  public  string get_nome(){
    return nome;
  }
  public  string get_dat_nasc(){
    return data_nascimento;
  }
  public string get_email(){
    return email;
  }
  public string get_cidade(){
   return cidade;
  }
  public  string get_bairro(){
    return bairro;
  }
  public string get_estado(){
    return estado;
  }
  public  string get_sexo(){
    return sexo;
  }
  public  string get_horario_consulta(){
    return horario_consulta;
  }
  public  string get_data_consulta(){
  return data_consulta;
  }
  public  int  get_telefone(){
    return telefone;
  }
 
  public  int get_especialidade(){
   return especialidade;
  }

  public int  get_plano(){
   return plano;
  }
  
}