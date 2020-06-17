namespace MortalKombat.GameEngine
{
    public interface ILupta
    {
        ILuptator Castigator { get; }
        ILuptator Desfasurare();
    }
}