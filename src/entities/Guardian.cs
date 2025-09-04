using System; // Adicionado para uso do Random e Console, se necessário em métodos específicos
using PiratasDaGalaxia;

namespace PiratasDaGalaxia;

// 2. HERANÇA: 'Guardian' herda da classe 'Hero'.
// Isso significa que um Guardian "é um" Hero e automaticamente possui todas as
// propriedades (Name, Health, Strength, etc.) e métodos (Attack, ToString) de um Hero.
public class Guardian:Hero 
{
    public Guardian(string Name, string HeroType, int Health, int Strength, int Agility, int Vitality, int Intelligence, int Charisma)
    // 'base' é usada para chamar o construtor da classe pai (Hero).
    // Isso garante que a parte 'Hero' do Guardian seja inicializada corretamente.
    : base(Name, HeroType, Health, Strength, Agility, Vitality, Intelligence, Charisma) 
    {
        // Neste construtor, não é necessário reatribuir as propriedades se elas já foram
        // passadas para o construtor 'base', pois o construtor do Hero já as define.
        // No entanto, se o Guardian tivesse propriedades adicionais, elas seriam inicializadas aqui.
        // this.Name = Name; // Desnecessário, já feito na base
        // this.HeroType = HeroType; // Desnecessário, já feito na base
        // ... e assim por diante para todos os atributos do Hero
    }

    // 4. POLIMORFISMO: O método Attack() é 'sobrescrito' (override) aqui.
    // Isso demonstra que um 'Guardian' tem uma "forma diferente" de atacar
    // em comparação com o 'Hero' genérico, mas ainda assim responde ao mesmo comando 'Attack()'.
    public override string Attack()
    {
        return this.Name + " lançou magia !!";
    }
}