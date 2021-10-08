using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;


namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoDoUsuario();
            while (opcaoUsuario.ToUpper() != "X" )
            {
                 switch ( opcaoUsuario)
                 {
                     case "1":
                        listarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                       AtualizarSerie();
                        break;
                    case "4":
                       ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                    throw new NotImplementedException(" dançou kkk ..");
                 
                 }// fim do switch

                 opcaoUsuario = obterOpcaoDoUsuario();
              
            } // fim do while
            Console.WriteLine( " ....obrigado volte sempre ...");
            Console.WriteLine("   ");  
            Console.WriteLine("....==================...");                   
            Console.WriteLine("....Hello World!...");
            Console.WriteLine(".... TODA HONRA E GLÓRIA A DEUS..");
            Console.WriteLine("....====  F I M  ===========...");  
            Console.WriteLine("   ");  

        } // fim do metodo principal

        private static void listarSeries()
        {
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
               Console.WriteLine(" Nenhuma Série cadastrada !!! ");
                return;
            }
            foreach( var serie in lista) 
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine( " #ID {0}:- {1} {2}", serie.retornaId(),
                serie.retornaTitulo(), ( excluido ? "indisponível": "tempo limitado " ) );
             }

        }// fim do listarSeries
        
        private static void InserirSerie()
        {
            Console.WriteLine(" *** Inserir nova Série **** ");
              foreach( int i in Enum.GetValues(typeof(Genero)) ) 
            {
             Console.WriteLine( " {0} - {1}", i , Enum.GetName(typeof(Genero), i));
             }
              Console.WriteLine( " Digite um genero ");
              int entradaGenero = int.Parse(Console.ReadLine());

              Console.WriteLine( " Digite um TITULO ");
              string entradaTitulo = Console.ReadLine();

              Console.WriteLine( " Digite um Ano ");
              int entradaAno = int.Parse(Console.ReadLine());

               Console.WriteLine( " Digite DESCRIÇÃO ");
              string entradaDescricao = Console.ReadLine();

              Serie novaSerie = new Serie( id : repositorio.ProximoId(),
                                            genero:(Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);

              repositorio.Insere(novaSerie);
        } // fim do Inserir

        private static void ExcluirSerie()
        {
            Console.WriteLine( " EXCLUIR - Digite o Id da Serie: ");
            int indeceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indeceSerie);
        }
        private static void VisualizarSeries()
        {
            Console.WriteLine( " VISUALIZAR - Digite o Id da Serie: ");
           int indeceSerie = int.Parse(Console.ReadLine());
           var Serie = repositorio.RetornaPorId(indeceSerie);
           Console.WriteLine(Serie);

        }

        private static void AtualizarSerie()
        {
         Console.WriteLine(" ..... Digiter o ID filme  .....");
            int indeceSerie = int.Parse(Console.ReadLine());

              foreach( int i in Enum.GetValues(typeof(Genero)) ) 
            {
             Console.WriteLine( " {0} - {1}", i , Enum.GetName(typeof(Genero), i));
             }
              Console.WriteLine( " Digite um GENERO.. ");
              int entradaGenero = int.Parse(Console.ReadLine());

              Console.WriteLine( " Digite um TITULO.. ");
              string entradaTitulo = Console.ReadLine();

              Console.WriteLine( " Digite um Ano.. ");
              int entradaAno = int.Parse(Console.ReadLine());

               Console.WriteLine( " Digite DESCRIÇÃO...");
              string entradaDescricao = Console.ReadLine();

              Serie AtualizarSerie = new Serie( id : indeceSerie,
                                            genero:(Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);

              repositorio.Atualiza(indeceSerie, AtualizarSerie);
        } // fim do Atualizar


        private static string obterOpcaoDoUsuario() 
        {
              Console.WriteLine( );

              Console.WriteLine(" ***** DIO INOVATION *******");
               Console.WriteLine(" === CADASTRO DE FILMES : ");
              Console.WriteLine(" -- Informe a opção desejada : ");
              Console.WriteLine(" 1 - listar filmes : ");
              Console.WriteLine(" 2 - Inserir novo filme; ");
              Console.WriteLine(" 3 - Atualizar filme  ");
              Console.WriteLine(" 4 - Excluir filme ");
              Console.WriteLine(" 5 - Visualizar lista de Filme ");
              Console.WriteLine(" 6 - Limpar tela  ");
              Console.WriteLine(" x - SAIR DO PROGRAMA ");
              Console.WriteLine(   );

              Console.WriteLine("*** =========== **");

              string opcaoUsuario = Console.ReadLine().ToUpper();
              Console.WriteLine(   );
              return opcaoUsuario;

        } // fim do método obterOpcaoDoUsuario
    } // fim da class programa
}


/**
   //...EntidadeBase meuObjeot = new EntidadeBase(); não é possivel criar uma instacia de classe abstrata
   //...Serie meuObjeto = new Serie();         
   //... meuObjeto.Id; // qdo chamo o objeto ele já acha o Id da classse abstrata           

**/