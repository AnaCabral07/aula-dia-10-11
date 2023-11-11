// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Aluno {
   //Estado
   public int? rm = default!;
   public string nome = default!;
   public int idade? = default!;
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



 
