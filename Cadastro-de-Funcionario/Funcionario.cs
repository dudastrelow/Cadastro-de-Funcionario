public class Funcionario
{
    public string matricula;
    public string nome;
    public string funcao;
    public double salario;
    public Funcionario(string matricula, string nome, string funcao, double salario)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.funcao = funcao;
        this.salario = salario;
    }


    public double SalarioFuncionario()
    {
        if(funcao == "Médico")
        {
            double salariomedico = (salario * 0.2) + salario;
            if(salariomedico > 5000)
            {
                return salariomedico - (salariomedico * 0.17);
            }
            return salariomedico;
        }
        if(funcao == "TI")
        {
            double salarioTI = salario + 5600;
            if (salarioTI > 5000)
            {
                return salarioTI - (salarioTI * 0.17);
            }
            return salarioTI;
        }
        else 
        {
            double salarioADM = salario + (salario * 0.17) + 200;
            if (salarioADM > 5000)
            {
                return salarioADM - (salarioADM * 0.17);
            }
            return salarioADM;
        }
    }
    public double Porcentagem()
    {
        if (funcao == "Médico")
        {
            double salariomedico = (salario * 0.2) + salario;
            if (salariomedico > 5000)
            {
                return salariomedico * 0.17;
            }
            return 0.00;
        }
        if (funcao == "TI")
        {
            double salarioTI = salario + 5600;
            if (salarioTI > 5000)
            {
                return salarioTI * 0.17;
            }
            return 0.00;
        }
        else
        {
            double salarioADM = salario + (salario * 0.17) + 200;
            if (salarioADM > 5000)
            {
                return salarioADM * 0.17;
            }
            return 0.00;
        }
    }
}
//Cadastro de funcionario
//Função com tres tipos: Ti, Medico e 
//Salario medico: 2000 + 20%
//Salario TI: 2000 + 5.600
//Salario ADM: 200 + 15% + 200
//Se o salario passar de 5.000 vai ter um desconto de 17%
// Ex: TI deu 7600, vai descontar 17% 
