using System;

namespace tp1
{
    class Superpoder
    {
        #region Atributos

            private bool Tipo;
            private int CantidadUsos;

        #endregion

        #region Constructores

            public Superpoder(){
                this.Tipo = true;
                this.CantidadUsos = 1;
            }

            public Superpoder(bool verdadero, int usos){
                this.Tipo = verdadero;
                this.CantidadUsos = usos;
            }

        #endregion

        #region Getters y Setters

            //Set
            public void SetTipo(bool verdadero){
                this.Tipo = verdadero;
            }
            public void SetCantidadUsos(int valor){
                this.CantidadUsos = valor;
            }

            //Get
            public bool GetTipo(){
                return this.Tipo;
            }
            public int GetCantidadUsos(){
                return this.CantidadUsos;
            }

        #endregion

        #region Metodos
     
            public void Usar(Superheroe superheroe){

                int usos;
                usos = this.CantidadUsos - 1;
                
            }

        #endregion

    }
}

