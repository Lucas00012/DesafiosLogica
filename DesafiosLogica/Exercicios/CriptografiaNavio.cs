namespace DesafiosLogica.Exercicios
{
    public class CriptografiaNavio
    {
        public string Mensagem { get; set; }

        public void Iniciar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=== Exercício: Criptografia na rede do navio ===");
                Console.Write("Mensagem criptografada: ");
                Mensagem = Console.ReadLine();
            } while (Mensagem.Length < 8);

            Console.WriteLine();
            Console.WriteLine($@"Resposta: ""{Processar()}""");
        }

        private string Processar()
        {
            return Descriptografar(CorrigirPosicionamento(Mensagem));
        }

        private static char[] CorrigirPosicionamento(string mensagem)
        {
            var array = new char[mensagem.Length];
            var deslocamento = 4;
            var referencia = 0;

            for (var i = 0; i < mensagem.Length; i++)
            {
                var caractere = mensagem[i];
                if (caractere == ' ')
                {
                    array[i] = caractere;
                    continue;
                }

                referencia++;

                var posicao = i + deslocamento;
                if (referencia == 3 && deslocamento == -4)
                {
                    array[posicao] = Inverter(caractere);
                }
                else if (referencia == 4)
                {
                    array[posicao] = deslocamento == -4 ? Inverter(caractere) : caractere;
                    deslocamento *= -1;
                    referencia = 0;
                }
                else
                {
                    array[posicao] = caractere;
                }
            }

            return array;
        }

        private static string Descriptografar(char[] array)
        {
            var resposta = string.Empty;
            var referencia = 0;
            var ascii = 0;

            for (var i = 0; i < array.Length; i++)
            {
                var caractere = array[i];
                if (caractere == ' ')
                    continue;

                referencia++;
                ascii += caractere == '1' ? (int)Math.Pow(2, 8 - referencia) : 0;

                if (referencia == 8)
                {
                    resposta += (char)ascii;
                    referencia = 0;
                    ascii = 0;
                }
            }

            return resposta;
        }

        private static char Inverter(char caractere)
        {
            return caractere == '1' ? '0' : '1';
        }
    }
}
