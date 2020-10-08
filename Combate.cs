using System;

namespace tp1
{
    class Combate
    {
        #region Atributos

            private Superheroe Superheroe;
            private Villano Villano;
            private int CantidadUsosSuperpoder;

        #endregion

        #region Constructores

            public Combate(){
                this.Superheroe = new Superheroe();
                this.Villano = new Villano();
                this.CantidadUsosSuperpoder = 1;
            }

        #endregion

        #region Constructores

            public Combate(Superheroe valorSuperheroe, Villano valorVillano, int usosSuperpoder){
                
                this.Superheroe = valorSuperheroe;
                this.Villano = valorVillano;
                this.CantidadUsosSuperpoder = usosSuperpoder;
                
            }

        #endregion

        #region Getters y Setters

            //Set
            public void SetSuperheroe(Superheroe Superheroe){
                this.Superheroe = Superheroe;
            }
            public void SetVillano(Villano Villano){
                this.Villano = Villano;
            }
            public void SetCantidadUsosSuperpoder(int cantidadUsos){
                this.CantidadUsosSuperpoder = cantidadUsos;
            }

            //Get
            public Villano GetVillano(){
                return this.Villano;
            }
            public Superheroe GetSuperheroe(){
                return this.Superheroe;
            }

            public int GetCantidadUsosSuperpoder(){
                return this.CantidadUsosSuperpoder;
            }

        #endregion  

        #region Metodos

            public void Comenzar(){
                Console.WriteLine("El combate ha comenzado...");
            }
            public void Terminar(){
            }
            public void Turno(){    
            }

        #endregion

    }
}