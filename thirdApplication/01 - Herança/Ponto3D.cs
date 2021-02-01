namespace Classes.Heranca
{
  public class Ponto3D : Ponto3D
  {
    public int z;

    public Ponto3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
      CalcularDistancia();
    }

    public static void Calcular()
    {
      //Faz algo
    }
    public override void CalcularDistancia3()
    {
      //Faz algo
    }
  }
}