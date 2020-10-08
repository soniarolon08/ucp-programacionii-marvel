using System;

namespace tp1
{
    class Superheroe
    {
        #region Atributos

            private int CantidadVidas;
            private Superpoder Superpoder;

        #endregion

        #region Constructores

            public Superheroe(){
                this.CantidadVidas = 1;
                this.Superpoder = new Superpoder();
            }

            public Superheroe(int vidas, Superpoder superpoder){
                this.CantidadVidas = vidas;
                this.Superpoder = superpoder;
            }

        #endregion
        
        #region Getters y Setters

            //Set
            public void SetCantidadVidas(int vidas){
                this.CantidadVidas = vidas;
            }
            public void SetSuperpoder(Superpoder valorSuperpoder){
                this.Superpoder = valorSuperpoder;
            }

            //Get
            public int GetCantidadVidas(){
                return this.CantidadVidas;
            }

            public Superpoder GetSuperpoder(){
                return this.Superpoder;
            }

        #endregion
        
        #region Metodos

            public Item ObtenerItem(){
                return new Item();    
            }
            public void UsarItem(Item item){
            }
            public void DefenderAtaque(){ // o es int? 
            } 
            public void UsarSuperpoder(){
            }

        #endregion


    }
}
