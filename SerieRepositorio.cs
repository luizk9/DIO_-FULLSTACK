using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;


namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>(); // aqui vai simulando o BD assim armazendando 
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
           // throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
           // throw new NotImplementedException();
           // pode implementar o envio de email aqui
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
            //throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
            //throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
           // throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id]; 
           // throw new NotImplementedException();
        }
    }
}


 
    /** Resumo:
   // * ele colocou todos os métodos da interface 
  //  **  onde tinha o <T> ele mudou para nome Serie
  //  podendo fazer a mesma coisa para filme por exemplo 
    
       **/