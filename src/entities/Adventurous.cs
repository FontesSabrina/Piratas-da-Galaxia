using PiratasDaGalaxia;

namespace PiratasDaGalaxia
{
    // 2. HERANÇA: 'Adventurous' herda da classe 'Hero'.
    // Ele obtém todas as características e comportamentos básicos de um Hero.
    public class Adventurous : Hero
    {
        public Adventurous(string Name, string HeroType, int Health, int Strength, int Agility, int Vitality, int Intelligence, int Charisma)
        // Chama o construtor da classe base (Hero) para inicializar as propriedades herdadas.
        : base(Name, HeroType, Health, Strength, Agility, Vitality, Intelligence, Charisma)
        {
        }

        // 4. POLIMORFISMO: O método Attack() é sobrescrito.
        // 'Adventurous' ataca de uma maneira específica (com sabre de luz), diferente do Hero padrão.
        public override string Attack()
        {
            return this.Name + " atacou com seu sabre de luz!";
        }
    }
}