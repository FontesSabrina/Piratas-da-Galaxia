using PiratasDaGalaxia;

namespace PiratasDaGalaxia
{
    // 2. HERANÇA: 'Nero' também herda da classe 'Hero'.
    // Assim como Guardian e Soren, ele é um tipo especializado de Hero.
    public class Gentleman : Hero
    {
        public Gentleman (string Name, string HeroType, int Health, int Strength, int Agility, int Vitality, int Intelligence, int Charisma)
        // Chama o construtor da classe base (Hero) para inicializar suas propriedades.
        : base(Name, HeroType, Health, Strength, Agility, Vitality, Intelligence, Charisma)
        {
        }

        // 4. POLIMORFISMO: O método Attack() é sobrescrito.
        // 'Nero' tem sua própria forma de atacar (com pistola laser).
        public override string Attack()
        {
            return this.Name + " atacou com sua pistola laser!";
        }
    }
}