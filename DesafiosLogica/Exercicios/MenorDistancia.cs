namespace DesafiosLogica.Exercicios
{
    public class MenorDistancia
    {
        public (int[], int[]) Arrays { get; set; }
        public (int, int) Numeros { get; set; }
        public int? Resposta { get; set; }

        public void Iniciar()
        {
            int tamanho;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Exercício: Menor distância de dois arrays ===");
                Console.Write("Tamanho: ");
                tamanho = int.Parse(Console.ReadLine());
            } while (tamanho < 10);

            Arrays = (new int[tamanho], new int[tamanho]);

            Preencher(Arrays.Item1, 1);
            Preencher(Arrays.Item2, 2);
            Processar();
        }

        private void Processar()
        {
            foreach (var i in Arrays.Item1)
            {
                foreach (var j in Arrays.Item2)
                {
                    var distancia = Math.Abs(i - j);
                    if (!Resposta.HasValue || distancia < Resposta)
                    {
                        Resposta = distancia;
                        Numeros = (i, j);
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Resposta: {Resposta}");
            Console.WriteLine($"Nº array 1: {Numeros.Item1} | Nº array 2: {Numeros.Item2}");
        }

        private static void Preencher(int[] array, int identificador)
        {
            Console.Write($"Array nº {identificador}: ");
            var linha = Console.ReadLine().Split(",");

            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(linha[i]);
        }
    }
}
