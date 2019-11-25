using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Cr7 estas pateando";
        }

        public string Correr()
        {
            return "Cr7 estas corriendo";
        }

        public string Passe()
        {
            return "Cr7 estas pasando";
        }
    }
}