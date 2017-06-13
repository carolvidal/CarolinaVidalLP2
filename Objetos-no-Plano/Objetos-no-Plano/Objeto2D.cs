using System;

public class Objeto2D
{
    public int X, Y;

    public void MoverParaDireita()
    {
        X += 1;
    }
    public string Coordenadas()
    {
        return String.Format("{0}, {1}", X, Y);
    }
}