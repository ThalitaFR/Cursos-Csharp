public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    // Função sempre em maiúsculo usando verbos para a ação que ela representa.
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    } 

    public void Depositar (double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir (double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        // É possível retirar o else pois o return volta retorna o que o usuário pediu e volta para o método principa ou seja, só vai executar as linhas de baixo se a execução não entrar no If.
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        

    }
}