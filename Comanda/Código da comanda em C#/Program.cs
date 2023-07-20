using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientenome = "", texto = "", continuar = "";
            bool rodando = true;
            long clienterg = 0;
            int clienteidade = 0, Opções = 0, temp = 0, Quantia = 0, Aux = 0, Aux2 = 0, quantidade = 0;
            #region Vetores
            string[] Alimentos = new string[7];

            Alimentos[0] = "Porção de camarão ao óleo";
            Alimentos[1] = "Porção de batatas fritas com bacon";
            Alimentos[2] = "Frango a passarinho";
            Alimentos[3] = "Lanche artesanal";
            Alimentos[4] = "Misto quente";
            Alimentos[5] = "Pastelzinho com 12 unidades";
            Alimentos[6] = "Salgados";

            string[] Bebidas_Alcoólicas = new string[5];

            Bebidas_Alcoólicas[0] = "Whisky";
            Bebidas_Alcoólicas[1] = "Heineken";
            Bebidas_Alcoólicas[2] = "Drinks";
            Bebidas_Alcoólicas[3] = "Skol Beats";
            Bebidas_Alcoólicas[4] = "Brahma";

            string[] Bebidas_Simples = new string[2];

            Bebidas_Simples[0] = "Suco ou Refrigerante";
            Bebidas_Simples[1] = "Água";


            int[] preço = new int[14];

            preço[0] = 35;
            preço[1] = 25;
            preço[2] = 25;
            preço[3] = 20;
            preço[4] = 15;
            preço[5] = 10;
            preço[6] = 3;
            preço[7] = 80;
            preço[8] = 12;
            preço[9] = 10;
            preço[10] = 7;
            preço[11] = 5;
            preço[12] = 5;
            preço[13] = 3;

            string[] NotaFiscal = new string[10];
            int[] valorNotaFiscal = new int[10];
            int[] quantidade1 = new int[10];
            #endregion vetores

            Console.WriteLine("Comanda TI 108 ♥\n\n");
            Console.Write("Digite seu nome:");
            clientenome = Console.ReadLine();
            Console.Write("Digite sua idade:");
            clienteidade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu documento RG:");
            clienterg = long.Parse(Console.ReadLine());
            Console.Write("\n\nCardápio\n\n");
            Cardapio(Alimentos, Bebidas_Alcoólicas, Bebidas_Simples, preço, temp);
        Inicio:
            Console.Write("\n\nDigite a opção que quer consumir ou digite 0 para sair. ");
            Opções = int.Parse(Console.ReadLine());

            //Saber se cliente pode comprar bebida alcoolica

            if (clienteidade >= 0 && clienteidade <= 17)
            {
                texto = "Adolescente";
            }
            else if (clienteidade > 18 && clienteidade <= 60)
            {
                texto = "Adulto";
            }
            else
            {
                texto = "Idoso";
            }


            if (Opções >= 8 && Opções <= 12)
            {
                switch (texto)

                {
                    case "Adolescente":
                        Console.WriteLine("Não é permitido a venda de bebidas alcoólicas para ADOLESCENTES!!!");
                        goto Inicio;
                        break;
                    case "Adulto":
                        Console.WriteLine("Permitada a venda para ADULTOS!!!");
                        break;
                    default:
                        Console.WriteLine("Não é recomendado o uso de bebidas alcoólicas para idosos!!!");
                        break;
                }
            }

            if (Opções <= 7)
            {
                switch (Opções)
                {
                    case 0:
                        rodando = false;
                        break;
                    case 1:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 2:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 3:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 4:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 5:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 6:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    case 7:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Alimentos[Opções - 1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Alimentos[Opções - 1], preço[Opções - 1], quantidade);
                        break;
                    
                }

            }
            else if (Opções >= 8 && Opções <= 12)
            {
                switch (Opções)
                {
                    case 8:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Alcoólicas[0];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Alcoólicas[0], preço[Opções - 1], quantidade);
                        break;
                    case 9:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;

                        NotaFiscal[Aux] = Bebidas_Alcoólicas[1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Alcoólicas[1], preço[Opções - 1], quantidade);
                        break;
                    case 10:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Alcoólicas[2];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Alcoólicas[2], preço[Opções - 1], quantidade);
                        break;
                    case 11:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Alcoólicas[3];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Alcoólicas[3], preço[Opções - 1], quantidade);
                        break;
                    case 12:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Alcoólicas[4];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Alcoólicas[4], preço[Opções - 1], quantidade);
                        break;
                }


            }
            else
            {
                switch (Opções)
                {
                    case 13:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Simples[0];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Simples[0], preço[Opções - 1], quantidade);
                        break;
                    case 14:
                        Console.Write("Quantas unidades? ");
                        quantidade = int.Parse(Console.ReadLine());
                        valorNotaFiscal[Aux] += preço[Opções - 1];
                        Quantia += preço[Opções - 1] * quantidade;
                        quantidade1[Aux2] = quantidade;
                        Aux2++;
                        NotaFiscal[Aux] = Bebidas_Simples[1];
                        Aux++;
                        Console.WriteLine("{0} - R$ {1} x {2}\n", Bebidas_Simples[1], preço[Opções - 1], quantidade);
                        break;
                    default:
                        Console.Write("Digite uma opção válida");
                        goto Inicio;
                        break;
                }
            }
            if (rodando == true)
            {
                Console.Write("Deseja comprar mais alguma coisa? [S/N] ");
                continuar = Console.ReadLine();
                if (continuar == "S" || continuar == "s" || continuar == "Sim" || continuar == "sim" || continuar == "SIM")
                {
                    goto Inicio;
                }
                else
                {
                    MostrarNotaFiscal(NotaFiscal, Quantia, clientenome, valorNotaFiscal, quantidade1);
                    Console.ReadKey();
                    Pagamento(Quantia);
                    rodando = false;
                }
            }
            Console.ReadKey();
        }

        public static void Cardapio(string[] Alimentos, string[] Bebidas_Alcoólicas, string[] Bebidas_Simples, int[] preço, int temp)

        {
            int Valor = 0;

            Console.WriteLine("\nAlimentos\n\n");

            for (int Linhas = 0; Linhas < 7; Linhas++)

            {
                Valor = Linhas + 1;
                Console.WriteLine("{0}- " + Alimentos[Linhas] + "  R$" + preço[Linhas] + ",00", Valor);
                temp = Linhas;

            }
            temp++;

            Console.WriteLine("\nBebidas\n\n");

            for (int Linhas = 0; Linhas < 5; Linhas++)

            {
                Valor++;
                Console.WriteLine("{0}- " + Bebidas_Alcoólicas[Linhas] + "  R$" + preço[temp] + ",00", Valor);
                temp++;
            }

            for (int Linhas = 0; Linhas < 2; Linhas++)

            {
                Valor++;
                Console.WriteLine("{0}- " + Bebidas_Simples[Linhas] + "  R$" + preço[temp] + ",00", Valor);
                temp++;
            }
        }
        public static void MostrarNotaFiscal(string[] NotaFiscal, int Quantia, string clientenome, int[] valorNotaFiscal, int[] quantidade1)
        {
            Console.Clear();
            Console.WriteLine("Nota Fiscal\n");
            Console.WriteLine("Cliente: {0}", clientenome);
            for (int percorrer = 0; percorrer < NotaFiscal.Length; percorrer++)
            {
                if (quantidade1[percorrer] == 0)
                {
                    continue;
                }
                Console.WriteLine("\n{0} - {1} - R$ {2} x {3}\n", percorrer + 1, NotaFiscal[percorrer], valorNotaFiscal[percorrer], quantidade1[percorrer]);
            }
            Console.WriteLine("Total da compra: R$ {0}\n", Quantia);
        }
        public static void Pagamento(int Quantia)
        {
            int opcaoPagamento = 0, parcelar = 0;
            Console.WriteLine("Qual a forma de pagamento? \n | 1 - DÉBITO | 2 - CRÉDITO | 3 - DINHEIRO");
            opcaoPagamento = int.Parse(Console.ReadLine());
            switch (opcaoPagamento)
            {
                case 1:
                    Console.WriteLine("Débito selecionado...Confira o valor e insira o cartão na maquininha!");
                    Console.WriteLine("R$ {0} à vista", Quantia);
                    Console.ReadKey();
                    Console.WriteLine("PAGAMENTO APROVADO!\nPor favor retire o cartão");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado pela preferência, volte sempre! ♥");
                    break;
                case 2:
                    Console.WriteLine("Crédito selecionado...Em quantas vezes será? Obs: No máximo 3x");
                    parcelar = int.Parse(Console.ReadLine());
                    Console.WriteLine("R$ {0} parcelado em {1}x, parcelas de R$ {2}", Quantia, parcelar, Quantia / parcelar);
                    Console.WriteLine("Insira o cartão da maquininha");
                    Console.ReadKey();
                    Console.WriteLine("PAGAMENTO APROVADO!\nPor favor retire o cartão");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado pela preferência, volte sempre! ♥");
                    break;
                case 3:
                    Console.WriteLine("R$ {0} à vista", Quantia);
                    Console.ReadKey();
                    Console.WriteLine("Obrigado pela preferência, volte sempre! ♥");
                    break;
            }
        }
    }
}
