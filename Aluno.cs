// Aluno Marinhazinha = new Aluno();
// var Mariazinha = new Aluno();
// Aluno Mariazinha = new();
// Mariazinha.rm = 12345;
// Mariazinha.nome = "Maria";
// Mariazinha.idade = 12;

// Aluno zeze = new() {
  //  rm = 12333,
   // nome = "Zézinho",
   // idade = 99,
//};

// string mensagem = $"O(a) aluno(a) {Mariazinha.nome} possui o rm {Mariazinha.rm} e idade de {Mariazinha.idade} anos.";
// Console.WriteLine(mensagem);

// Mariazinha.Exibir();
// zeze.Exibir();

// zeze.TrancaMatricula();

// Mariazinha.Exibir();
// zeze.Exibir();

class Aluno {
   //Estado
   public int? rm = default!;
   public string nome = default!;
   public int? idade = default!;
   public bool ativo = true;

   //Comportamento
   public void Exibir() {
    if (!this.ativo) return;

     string mensagem = $"O(a) aluno(a) {this.nome} possui o rm {this.rm} e idade de {this.idade} anos.";
     Console.WriteLine(mensagem);
   }

      public void TrancaMatricula() {
      this.ativo = false;
}
}
