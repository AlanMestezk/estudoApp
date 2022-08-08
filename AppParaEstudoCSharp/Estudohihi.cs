

namespace EstudoHehe {
    internal class Estudohihi {

        private string _nome;
        private int _idade;
        private double _altura;
        private string _corFavorita;

        public Estudohihi() {}

        public Estudohihi(string nome, int idade, double altura) {
            _nome = nome;
            _idade = idade;
            _altura = altura;
        }

        public Estudohihi(string nome, int idade, double altura, string corFavorita) : this(nome, idade, altura) {
            _corFavorita = corFavorita;
        }

        public string Nome {
            get { return _nome; }
            
            set {
                if (value != null && value.Length > 4) {
                    Console.WriteLine($"aceito");
                }
                else {
                    Console.WriteLine($"O nome de usuário {_nome = value} é muito curto");
                }
            }
        }

        public int Idade {

            set {
                if(value != null && value > 18) {
                    Console.WriteLine($"aceito");
                }
                else {
                    Console.WriteLine($"{_idade = value} anos não aceito");
                }
            }

        }

        public double Altura {
            get { return _altura; }
            set {
                Console.WriteLine("aceito");
             }
        }

        public string CorFavorita {

            get { return _corFavorita; }
            set {
                Console.WriteLine("aceito");
            }

        }

    }
}
