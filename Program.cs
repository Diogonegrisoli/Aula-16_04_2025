using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        // TERCEIRO COMMIT
        bool repeticao = true;

        List<Conta> listaContas = new List<Conta>();
        int idConta = 1;

        do
        {
            int escolha = 0;

            Console.WriteLine("\nMENU\n");
            Console.WriteLine("1 - Criar conta\n2 - Listar contas\n3 - Fechar");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    while (repeticao)
                    {
                        char outraConta = 's';

                        Conta conta = new Conta();

                        Console.WriteLine("Insira os dados da conta: \n");

                        conta.id = idConta++;

                        Console.Write("Agência: ");
                        conta.agencia = Console.ReadLine();

                        Console.Write("N° da conta: ");
                        conta.num_conta = Console.ReadLine();

                        Console.Write("Nome do proprietário: ");
                        conta.nome = Console.ReadLine();

                        Console.Write("Saldo: ");
                        conta.saldo = Convert.ToDouble(Console.ReadLine());

                        listaContas.Add(conta);

                        Console.WriteLine("Deseja criar outra conta? S/N");
                        outraConta = char.Parse(Console.ReadLine().ToUpper());

                        if (outraConta == 'S')
                        {
                            repeticao = true;
                        }
                        else if (outraConta == 'N')
                        {
                            repeticao = false;
                        }
                    }
                    repeticao = true;
                    break;

                case 2:
                    foreach (Conta c in listaContas)
                    {
                        Console.Write($"\nId: {c.id}\nAgencia: {c.agencia}\nNúmero da conta: {c.num_conta}\nProprietário: {c.nome}\nSaldo da conta: {c.saldo}");
                        Console.WriteLine(" ");
                    }
                    break;

                case 3:
                    repeticao = false;
                    break;
            }
        } while (repeticao);


        //do
        //{
        //    int contaDesejada = 0;
        //    Conta conta = new Conta();
        //    string escolha2 = "";
        //    escolha2 = Console.ReadLine();

        //    Console.Write("Informe o ID da conta que deseja SACAR/DEPOSITAR: ");
        //    contaDesejada = Convert.ToInt32(Console.ReadLine());

        //    if (int.TryParse(escolha2, out int escolhaInt))
        //    {
        //        switch (escolhaInt)
        //        {
        //            case 1:
        //                double valorDeposito = 0;

        //                Console.Write("Valor para depósito: ");
        //                valorDeposito = Convert.ToDouble(Console.ReadLine());

        //                conta.Deposito(valorDeposito);

        //                break;

        //            case 2:
        //                double valorSaque = 0;

        //                Console.Write("Valor para saque: ");
        //                valorSaque = Convert.ToDouble(Console.ReadLine());

        //                conta.Saque(valorSaque);
        //                break;

        //            case 3:
        //                repeticao = false;
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Digite apenas números!");
        //    }
        //} while (repeticao);
    }
}

