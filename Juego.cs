using System;

namespace tp1
{
    class Juego
    {
        #region Atributos

            private bool Resultado;
            private Combate Combates;
            private int Nivel;

        #endregion

        #region Constructores

            public Juego(){
                this.Resultado = false;
                this.Combates = new Combate();
                this.Nivel = 1;
            }
        

            public Juego(bool resultado, Combate combate, int nivel){
                this.Resultado = resultado;
                this.Combates = combate;
                this.Nivel = nivel;
            }

        #endregion

        #region Getters y Setters

            //Set

            public void SetResultado(bool resultado){
                this.Resultado = resultado;
            }
            public void SetNivel(int nivel){
                this.Nivel = nivel;
            }
            public void SetCombates(Combate valorCombate){
                this.Combates = valorCombate;
            }

            //Get

            public Combate GetCombates(){
                return this.Combates;
            }
            public bool GetResultado(){
                return this.Resultado;
            }
            public int GetNivel(){
                return this.Nivel;
            }
            
        #endregion
        
        #region Metodos

            public void Comenzar(){
            }
            public void Terminar(){          
            }

        #endregion

    }
}