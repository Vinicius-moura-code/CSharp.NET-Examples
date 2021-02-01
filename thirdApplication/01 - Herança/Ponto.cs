namespace Classes.Heranca
{
  public class Ponto
  {
    publuic int x, y;

    private int distancia;  

    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protect void CalcularDistancia()
    {
      // Faz algo
    }

    private void CalcularDistancia2()
    {
      // Faz algo
    }

    public virtual void CalcularDistancia3()
    {
      //Faz alguma coisa
    }
  }
    
}