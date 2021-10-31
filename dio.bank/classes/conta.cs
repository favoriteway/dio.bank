using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.bank
{
    public class conta
    {
                private TipoConta TipoConta { get; set; }
                private double Saldo { get; set; }

                private double Credito { get; set; }

                private string Nome { get; set; }

    public conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;
    }
    public bool Sacar(double valorSaque)
    {
        //validação de saldo insuficiente
        if (this.Saldo - valorSaque < (this.Credito *-1)){
            Console.WriteLine("saldo insuficiente");
            return false;
        }

        this.Saldo -= valorSaque;
        Console.WriteLine("saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

        return true;
    }
    public void Depositar(double valorDeposito)
    {
        this.Saldo += valorDeposito;

        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
    }

    public void Transferir(double valorTransferencia, conta contaDestino)
    {
        if (this.Sacar(valorTransferencia)){
            contaDestino.Depositar(valorTransferencia);
        }
    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "TipoConta " + this.TipoConta + " | ";
        retorno += "Nome " + this.Nome + " | ";
        retorno += "Saldo " + this.Saldo + " | ";
        retorno += "Crédito " + this.Credito;
        return retorno;
    }

    }
}