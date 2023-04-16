using System;

class Pessoa
{
    //atributos:
    public double peso,altura;

    //método cálculo:
    public double calculo()
    {
        return peso / (altura * altura);
    }
    //método situação:
    public string situacao(double imc)
    {
        //variável:
        string retorno;

        //condicionais:
        if (imc < 18.5)
        {
            retorno = "Abaixo do Peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso Normal";
        }
         else if (imc < 30)
        {
            retorno = "Acima do Peso";
        }
         else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
         else if (imc < 40)
        {
            retorno = "Obesidade II";
        }
         else if (imc >= 40)
        {
            retorno = "Obesidade III";
        }

        //retorno:
        return retorno;
    }
    
    //método mensagem:
    public void mensagem()
    {
        //obter cálculo:
        double obterCalculo = calculo();

        //obter situacao:
        string obterSituacao = situacao(obterCalculo);

        //printar mensagem:
        Console.WriteLine("Seu IMC é de "+obterCalculo);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }


}