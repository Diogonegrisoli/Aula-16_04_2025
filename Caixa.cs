using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Conta
{
    public int id;
    public string agencia;
    public string num_conta;
    public string nome;
    public double saldo;

    public double Deposito(double saldoConta)
    {
        if (saldoConta < 0)
        {
            Console.WriteLine("Insira apenas valores positivos.");
        }
        else
        {
            saldo += saldoConta;
            Console.WriteLine("Valor depositado com sucesso!");
            Console.WriteLine($"Saldo atual: {saldo.ToString("C2")}");
        }

        return saldo;
    }

    public double Saque(double saqueConta)
    {
        if (saqueConta < 0)
        {
            Console.WriteLine("O saque não pode ser negativo!");
        }
        else if(saqueConta > saldo)
        {
            Console.WriteLine("O valor desejado não está disponível");
        }
        else
        {
            saldo -= saqueConta;
            Console.WriteLine($"O saque no valor de {saqueConta.ToString("C2")} foi realizado!");
            Console.WriteLine($"Saldo atual: {saldo.ToString("C2")}");
        }

        return saldo;
    }

}

