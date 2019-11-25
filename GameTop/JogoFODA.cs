using  GameTOP.Lib;
using  GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        private readonly iJogador _jogadorC;
        
        public JogoFODA(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }

        public  void IniciarJogo(){
            System.Console.WriteLine(_jogadorA.Chutar());
            System.Console.WriteLine(_jogadorA.Correr());
            System.Console.WriteLine(_jogadorA.Passe());
            System.Console.WriteLine("");
            System.Console.WriteLine("Próximo Jogador!");
            System.Console.WriteLine("");
            System.Console.WriteLine(_jogadorB.Chutar());
            System.Console.WriteLine(_jogadorB.Correr());
            System.Console.WriteLine(_jogadorB.Passe());
            System.Console.WriteLine("");
            System.Console.WriteLine("Próximo Jogador!");
            System.Console.WriteLine("");
            System.Console.WriteLine(_jogadorC.Chutar());
            System.Console.WriteLine(_jogadorC.Correr());
            System.Console.WriteLine(_jogadorC.Passe());
        }
        
    }

}
