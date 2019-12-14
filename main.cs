using System;

class Caneta {

  private string cor;
  private string marca;
  private string ponta;

  public Caneta(string c, string m, string p) {

    cor = c;
    marca = m;
    ponta = p;
    
  }

  public string getCor(){
    return cor;
  }

  public void setCor(string c){
    cor = c;

  }

  public string getMarca(){
    return marca;
  }

  public void setMarca(string m){
    marca = m;
  }

  public string getPonta(){
    return ponta;
  }

  public void setPonta(string p){
     ponta = p; 
  }
}

class MainClass {
  public static void Main (string[] args) {

    Caneta bic = new Caneta("Azul", "Bic", "Fina"); 
    Console.WriteLine ("Cor da Caneta: {0}", bic.getCor());
    Console.WriteLine("Marca da Caneta: {0}",bic.getMarca());
    Console.WriteLine("Tipo de ponta: {0}",bic.getPonta());
  }
}