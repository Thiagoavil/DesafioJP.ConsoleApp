using System;

namespace DesafioJP
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //Equipamentos
            string[] nomeequipamentos = new string[1000];
            decimal[] precoAquisicao = new decimal[1000];
            int[] numeroDeSerie = new int[1000];
            string[] dataDeFabricação = new string[1000];
            string[] fabricante = new string[1000];
            int[] IDequipamento = new int[1000];
            int numeroderegistros = 0;

            //Chamados
            string[] tituloDoChamado = new string[1000];
            string[] descricaoDoChamado = new string[1000];
            string[] dataAberturaChamado = new string[1000];
            string[] equipamentochamado = new string[1000];
            int[] IDchamados = new int[1000];
            int numerodechamados = 0;


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Bem vindo");
                Console.ResetColor();
                Console.WriteLine("|||||||||||||||||||||||||||");
                Console.WriteLine("Digite 1 para equipamentos\nDigite 2 para chamados\nDigite s para sair");

                string opcaomenu = Console.ReadLine();
                Console.Clear();

                if (opcaomenu == "1")
                {
                    MenuEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                    ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento, ref equipamentochamado, 
                    ref numerodechamados);
                }
                else if (opcaomenu == "2")
                {
                    MenuChamados(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                    ref dataDeFabricação, ref fabricante, ref numeroderegistros,
                    ref IDequipamento, ref equipamentochamado, ref tituloDoChamado,
                    ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado, ref IDchamados);
                }
                else if (opcaomenu == "s")
                {
                    break;
                }
                else if (opcaomenu != "1" && opcaomenu != "2" && opcaomenu != "s")
                {
                    Console.Clear();
                    Console.WriteLine("Comando invalido\nPressione o enter");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }




            }


        }

        static void MenuEquipamentos(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamdo, ref int numerodechamados)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Menu dos equipamentos JP");
            Console.WriteLine("Digite 1 para adicionar equipamento");
            Console.WriteLine("Digite 2 para editar equipamento");
            Console.WriteLine("Digite 3 para visualiza equipamento");
            Console.WriteLine("Digite 4 para excluir o equipamento");
            Console.ResetColor();  
            string opcaoEquipamentos = Console.ReadLine();
            Console.Clear();

            if (opcaoEquipamentos == "1")
            {
                adicionarequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);

            }
            else if (opcaoEquipamentos == "2")
            {
                editarequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);
            }
            else if (opcaoEquipamentos == "3")
            {
                visualizacaoequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);
            }
            else if (opcaoEquipamentos == "4")
            {
                excluirequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento, ref equipamentochamdo, 
                ref numerodechamados);
            }
        }

        static void MenuChamados(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamado, ref string[] tituloDoChamado,
            ref int numerodechamados, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado, ref int[] IDchamados)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Menu dos chamados JP");
            Console.WriteLine("Digite 1 para adicionar chamados");
            Console.WriteLine("Digite 2 para editar chamados");
            Console.WriteLine("Digite 3 para visualizar chamados");
            Console.WriteLine("Digite 4 para excluir chamados");
            Console.ResetColor();
            string opcaochamado = Convert.ToString(Console.ReadLine());
            Console.Clear();

            if (opcaochamado == "1")
            {
                adicionarchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento,
                ref equipamentochamado, ref tituloDoChamado, ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado
                , ref IDchamados);
            }
            else if (opcaochamado == "2")
            {
                editarchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento,
                ref equipamentochamado, ref tituloDoChamado, ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado
                , ref IDchamados);
            }
            else if (opcaochamado == "3")
            {
                visualizarchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento,
                ref equipamentochamado, ref tituloDoChamado, ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado
                , ref IDchamados);
            }
            else if (opcaochamado == "4")
            {
                excluirchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros,
                ref IDequipamento, ref equipamentochamado, ref tituloDoChamado,
                ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado, ref IDchamados);
            }

        }

        static void adicionarequipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros, ref int[] IDequipamento)
        {
            string nome;
            while (true)
            {
                
                Console.WriteLine("Digite o nome do equipamento:     (mínimo 6 caracteres)");
                nome = Console.ReadLine();

                if (nome.Length < 6)
                {
                    Console.WriteLine("Numero de caracteres menor que 6");
                    continue;
                }

                nomeequipamentos[numeroderegistros] = nome;

                break;

            }

            IDequipamento[numeroderegistros] = numeroderegistros;

            Console.WriteLine("Digite o preço de aquisição:");
            precoAquisicao[numeroderegistros] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o numero de série:");
            numeroDeSerie[numeroderegistros] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a data de fabricação: (dd/mm/aaaa)");
            dataDeFabricação[numeroderegistros] = Console.ReadLine();

            Console.WriteLine("Digite o nome do fabricante:");
            fabricante[numeroderegistros] = Console.ReadLine();
            Console.Clear() ;   


            numeroderegistros++;

        }

        static void editarequipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros, ref int[] IDequipamento)
        {
            visualizacaoequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);

            Console.WriteLine("Digite o ID do equipamento para edição: ");
            int numerodeedicao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Esse é o equipamento que está sendo editado" + nomeequipamentos[numerodeedicao] );
            Console.WriteLine("Digite \n1- Para editar o nome\n2- Para editar o numero de série" +
                "\n3- Para editar o fabricante\n" +
                "4- Para editar o preço de aquisição\n5- Para editar a data de fabricação");
            string campodeedicao = Console.ReadLine();

            while (true)
            {
                if (campodeedicao != "1" && campodeedicao != "2" && campodeedicao != "3" && campodeedicao != "4" && campodeedicao != "5")
                {
                    Console.Clear();
                    Console.WriteLine("Numero inválido");
                    Console.WriteLine("Digite 1- Para editar o nome\n2- Para editar o numero de série\n" +
                        "3- Para editar o fabricante\n" +
                        "4- Para editar o preço de aquisição\n5- Para editar a data de fabricação");
                    campodeedicao = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            if (campodeedicao == "1")
            {
                Console.WriteLine("Digite o novo nome do equipamento");
                nomeequipamentos[numerodeedicao] = Console.ReadLine();
            }
            else if (campodeedicao == "2")
            {
                Console.WriteLine("Digite o novo numero de série do equipamento");
                numeroDeSerie[numerodeedicao] = Convert.ToInt32(Console.ReadLine());
            }
            else if (campodeedicao == "3")
            {
                Console.WriteLine("Digite o novo fabricante do equipamento");
                fabricante[numerodeedicao] = Console.ReadLine();
            }
            else if (campodeedicao == "4")
            {
                Console.WriteLine("Digite o novo preço de aquisição do equipamento");
                precoAquisicao[numerodeedicao] = Convert.ToDecimal(Console.ReadLine());
            }
            else if (campodeedicao == "5")
            {
                Console.WriteLine("Digite a nova data de fabricação do equipamento");
                dataDeFabricação[numerodeedicao] = Console.ReadLine();
            }

        }

        static void visualizacaoequipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros, ref int[] IDequipamento)
        {
            if (numeroderegistros == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento registrado");
                Console.ResetColor();
            }
            else
            {

                for (int i = 0; i < numeroderegistros; i++)
                {
                    Console.WriteLine("ID: " + IDequipamento[i] + "-" + "Nome: " + nomeequipamentos[i] + 
                        "\nNumero de série: " + numeroDeSerie[i] +
                       "\nFabricante: " + fabricante[i]);
                    Console.WriteLine();
                }
            }
        }

        static void excluirequipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros, ref int[] IDequipamento
            , ref string[] equipamentochamdo, ref int numerodechamados)
        {
            visualizacaoequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);

            Console.WriteLine("Digite o ID do equipamento para exclusão: ");
            int iddeexclusao = Convert.ToInt32(Console.ReadLine());
            
            int quantiaDeGiros = 0;
            bool podeExcluir = true;
            if (numeroderegistros == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem equipamentos registrados");
                Console.ResetColor();
            }
            else
            {
                if (numeroderegistros > numerodechamados)
                {
                    quantiaDeGiros = numeroderegistros;
                }
                else
                {
                    quantiaDeGiros = numerodechamados;
                }
                for (int i = 0; i < quantiaDeGiros; i++)
                {
                    if (equipamentochamdo[i] == nomeequipamentos[iddeexclusao])
                    {
                        podeExcluir = false;
                    }
                }
                if(podeExcluir==false)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("equipamento atrelado a um chamado");
                    Console.ResetColor();
                }

                if (podeExcluir == true)
                {
                    for (int i = iddeexclusao; i < numeroderegistros; i++)
                    {
                        nomeequipamentos[i] = nomeequipamentos[i + 1];
                        precoAquisicao[i] = precoAquisicao[i + 1];
                        numeroDeSerie[i] = numeroDeSerie[i + 1];
                        dataDeFabricação[i] = dataDeFabricação[i + 1];
                        fabricante[i] = fabricante[i + 1];
                    }
                    Console.ForegroundColor = ConsoleColor.Red;

                    numeroderegistros--;
                    Console.WriteLine("Equipamento excluido com sucesso");

                }
            }
        }

        static void adicionarchamado(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamado, ref string[] tituloDoChamado,
            ref int numerodechamados, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado, ref int[] IDchamados)
        {
            visualizacaoequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);

            Console.WriteLine("Digite o id do equipamento usado no chamado:");
            int idselecionado = Convert.ToInt32(Console.ReadLine());
            equipamentochamado[numerodechamados] = nomeequipamentos[idselecionado];

            Console.WriteLine("Digite um título para o chamado");
            tituloDoChamado[numerodechamados] = Console.ReadLine();

            Console.WriteLine("Digite uma breve descrição do problema");
            descricaoDoChamado[numerodechamados] = Console.ReadLine();

            Console.WriteLine("Digite a data do chamado");
            dataAberturaChamado[numerodechamados] = Console.ReadLine();

            IDchamados[numerodechamados] = numerodechamados;

            numerodechamados++;
            Console.Clear();

        }

        static void editarchamado(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamado, ref string[] tituloDoChamado,
            ref int numerodechamados, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado, ref int[] IDchamados)
        {
            visualizarchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroderegistros,
            ref IDequipamento, ref equipamentochamado, ref tituloDoChamado,
            ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado, ref IDchamados);

            Console.WriteLine("Digite o ID do chamado para edição: ");
            int numerodeedicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite 1- Para editar o titulo do chamado\n2- Para editar a descrição do chamado \n" +
                "3- Para editar o equipamento\n" +
                "4- Para editar a data de abertura");

            string campodeedicao = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                if (campodeedicao != "1" && campodeedicao != "2" && campodeedicao != "3" && campodeedicao != "4")
                {
                    Console.Clear();
                    Console.WriteLine("Numero inválido");
                    Console.WriteLine("Digite 1- Para editar o titulo do chamado\n2- Para editar a descrição do chamado \n" +
                    "3- Para editar o equipamento\n" +
                    "4- Para editar a data de abertura");
                    campodeedicao = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            if (campodeedicao == "1")
            {
                Console.WriteLine("Digite o novo título do chamado:");
                tituloDoChamado[numerodeedicao] = Console.ReadLine();
            }
            else if (campodeedicao == "2")
            {
                Console.WriteLine("Digite a nova descrição do chamado:");
                descricaoDoChamado[numerodeedicao] = Console.ReadLine();
            }
            else if (campodeedicao == "3")
            {
                visualizacaoequipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
                ref dataDeFabricação, ref fabricante, ref numeroderegistros, ref IDequipamento);

                Console.WriteLine("Digite o novo id do equipamento para o chamado");
                int IDseletivo = Convert.ToInt32(Console.ReadLine());
                equipamentochamado[numerodeedicao] = nomeequipamentos[IDseletivo];
            }
            else if (campodeedicao == "4")
            {
                Console.WriteLine("Digite a nova data da abertura do chamado: (dd/mm/aaaa)");
                dataAberturaChamado[numerodeedicao] = Console.ReadLine();
            }
            Console.Clear();
        }

        static void visualizarchamado(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamado, ref string[] tituloDoChamado,
            ref int numerodechamados, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado, ref int[] IDchamados)
        {
            if (numerodechamados == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;  
                Console.WriteLine("Nenhum chamado registrado");
                Console.ResetColor();
            }
            else
            {

                for (int i = 0; i < numerodechamados; i++)
                {
                    Console.WriteLine("ID: "+ IDchamados[i] +"\ntitulo: " + tituloDoChamado[i] + 
                        "\n" + "Nome do equipamento: " + equipamentochamado[i] +
                       "\ndata da abertura: " + dataAberturaChamado[i]);

                    DateTime hoje = DateTime.Now;
                    string strDataAbertoChamado = dataAberturaChamado[i];
                    string[] dataSeparada = strDataAbertoChamado.Split("/");
                    int dia = int.Parse(dataSeparada[0]);
                    int mes = int.Parse(dataSeparada[1]);
                    int ano = int.Parse(dataSeparada[2]);
                    DateTime criacaoDoChamado = new DateTime(ano, mes, dia);
                    int diasEmAberto = (hoje - criacaoDoChamado).Days;
                    Console.WriteLine("Dias em aberto: " + diasEmAberto);
                    Console.WriteLine();

                }
            }

        }

        static void excluirchamado(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroderegistros,
            ref int[] IDequipamento, ref string[] equipamentochamado, ref string[] tituloDoChamado,
            ref int numerodechamados, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado, ref int[] IDchamados)
        {
            visualizarchamado(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroderegistros,
            ref IDequipamento, ref equipamentochamado, ref tituloDoChamado,
            ref numerodechamados, ref descricaoDoChamado, ref dataAberturaChamado, ref IDchamados);

            Console.WriteLine("Digite o ID do chamado para exclusão: ");
            int iddeexclusao = Convert.ToInt32(Console.ReadLine());


            if (numerodechamados == 0)
            {
                Console.WriteLine("Não existem chamados cadastrados");
            }
            else
            {
                for (int i = iddeexclusao; i < numerodechamados; i++)
                {
                    equipamentochamado[i] = equipamentochamado[i + 1];
                    tituloDoChamado[i] = tituloDoChamado[i + 1];
                    descricaoDoChamado[i] = descricaoDoChamado[i + 1];
                    dataAberturaChamado[i] = dataAberturaChamado[i + 1];
                    
                }

                numerodechamados--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Equipamento excluido com sucesso");
                Console.ResetColor();
            }
        }
    }
}



