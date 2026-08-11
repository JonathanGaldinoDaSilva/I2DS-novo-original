/*
internal class Program
{
    private static void Main(string[] args)
    {
        int num1d;
        int num2d;
        int num3d;
        int num4d;
        int num5d;
        int num6d;



        Console.Write("Escolha seu personagem: ");

        Console.WriteLine("\n1- Gigante");
        Console.WriteLine("2- QuiMario");
        Console.WriteLine("3- Máskara mago");

        num1d = int.Parse(Console.ReadLine());



        Console.WriteLine("1- ataque rápido: 80 pontos de xp");
        Console.WriteLine("2- espada encantada: 200 pontos de xp");
        Console.WriteLine("3- feitiço mágico: 0 pontos de xp/ atrapalha o adversário na próxima jogada");

        string loading;

        Console.Write("Decida-se: ");
        loading = Console.ReadLine();

       switch (loading)
       {
        
        case "1":
        Console.WriteLine("Uau!", num1d, "que rápido!");
        break;
        case "2":
        Console.WriteLine("Cuidado", num1d, "para não se cortar!");
        break;
        case "3":
        Console.WriteLine("Esperto hein?", num1d);
        break;
        default:
        Console.WriteLine("essa opçao é invalida");
        break;
       };





    }
}
*/

internal class Program
{
    public class Personagem
    {
        public string Nome {get; private set;}
        public int Nivel {get; protected set;}
        public int Experiencia {get; private set;}
        public int Forca {get; protected set;}
        public int Agilidade {get; protected set;}
        public int Inteligencia {get; protected set;}
        public int Vida {get; protected set;} 

        // Método Construtor
        public Personagem(string nome, int forca, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
            Experiencia = 0;
            Nivel = 1; 
        }

        public virtual void ApresentarSe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Experiência: {Experiencia}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = Forca;
            Console.WriteLine($"{Nome} atacou {alvo.Nome}");

            alvo.Defender(dano);
            GanharExperiencia(20);       
        }

        public virtual void Defender(int dano)
        {
            int danoRecebido = dano - Agilidade;
            if(danoRecebido < 1)
            {
                danoRecebido = 1;
            } 
            Vida -= danoRecebido;
            if(Vida < 0)
            {
                Vida = 0;
            }
            Console.WriteLine($"Dano Recebido: {danoRecebido}");
            Console.WriteLine($"Vida de  {Nome}: {Vida}");
        }

        public void GanharExperiencia(int experiencia)
        {
            Experiencia += experiencia;
            Console.WriteLine($"{Nome} ganhou {experiencia} XP");

            VerificarEvolucao();
        }

        public void VerificarEvolucao()
        {
            int experienciaNecessaria = Nivel * 100;
            if (Experiencia >= experienciaNecessaria)
            {
                Evoluir();
            }
        }

        protected virtual void Evoluir()
        {
            Nivel++; // Nivel = Nivel + 1
            Forca += 2; // Forca = Forca + 2
            Agilidade += 2;
            Inteligencia +=2;
            Vida += 10;
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("              LEVEL UP!");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine($"{Nome} evoluiu para o nível {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
    // ======================================================
    // MAGO
    // ======================================================
    public class Mago : Personagem
    {
        public Mago(string nome): base(nome, 5, 7, 25, 90){ }

        public override void Atacar(Personagem alvo)
        {
            int dano = Inteligencia;
            Console.WriteLine(
                $"{Nome} lançou uma magia contra {alvo.Nome}");
            alvo.Defender(dano);
            GanharExperiencia(20);
        }

        protected override void Evoluir()
        {
            Nivel++;
            Forca++; // Forca = Forca + 2
            Agilidade += 2;
            Inteligencia +=5;
            Vida += 15;

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("              LEVEL UP!");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine($"{Nome} evoluiu para o nível {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine("========================================");
            Console.WriteLine();


        }
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}