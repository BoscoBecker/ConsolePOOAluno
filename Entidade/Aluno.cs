using System.Globalization;

namespace ConsolePOOAluno.Entidade
  
{
  internal class Aluno
  {
    public string Nome;
    public double Nota;
    public bool Aprovado;

    public double Resultado() {
      this.Aprovado = (this.Nota >= 60.0);
      if (!Aprovado)
        this.Nota -= 60;
      return this.Nota;
    }

    public override string ToString()
    {
      string resultado;
      Resultado();
      if (this.Aprovado)
        resultado = "NOTA FINAL = " + this.Nota + " APROVADO "+ this.Nota + " PONTOS";
      else
        resultado = "NOTA FINAL = " + this.Nota + " REPROVADO" + " FALTARAM" + this.Nota +" PONTOS";

      return resultado;
    }
  }
}
