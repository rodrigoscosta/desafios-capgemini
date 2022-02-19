using System.Text.RegularExpressions;
using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite sua senha: ");
            string senhaDoUsuario = Console.ReadLine();

            Console.WriteLine(ContarCaracteres(senhaDoUsuario));
        }

        public static int ContarCaracteres(string senha)
        {
            var contador = 0;

            //Define as regras de caracteres da senha
            var temNumero = new Regex(@"[0-9]+");
            var temMaiuscula = new Regex(@"[A-Z]+");
            var temMinuscula = new Regex(@"[a-z]+");
            var temCaracterEspecial = new Regex(@"[!@#$%^&*()\-+]+");
            var temSeisCaracteres = new Regex(@".{6,}");

            //Verifica se a senha atende aos requisitos e armazena em uma variável
            var numeroVerificado = temNumero.IsMatch(senha);
            var maiusculaVerificada = temMaiuscula.IsMatch(senha);
            var minusculaVerificada = temMinuscula.IsMatch(senha);
            var caracterEspecialVerificado = temCaracterEspecial.IsMatch(senha);
            var seisCaracteresVerificados = temSeisCaracteres.IsMatch(senha);

            //Verifica se as condições não são atendidas e incrementa no contador
            if(!numeroVerificado) {contador+=1;}

            if(!maiusculaVerificada) {contador+=1;}

            if(!minusculaVerificada) {contador+=1;}

            if(!caracterEspecialVerificado) {contador+=1;}

            if(!seisCaracteresVerificados) {contador+=1;}

            /*Verifica se o comprimento da senha depois de adicionar os caracteres 
              obrigatórios é menor do que 6 e adiciona o número de caracteres
              a que falta inserir
            */
            if(contador + senha.Length < 6)
            {
                contador = contador + 6 - (contador + senha.Length);
            }

            return contador;
        }
    }
}