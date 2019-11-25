using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public string Chutar()
        {
            return "Messi está chutando";
        }

        public string Correr()
        {
           return "Messi está correndo";
        }

        public string Passe()
        {
            return "Messi está passando";
        }
    }
}