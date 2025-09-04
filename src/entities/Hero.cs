namespace PiratasDaGalaxia;

// 1. ABSTRAÇÃO: A classe Hero é uma abstração de um "herói" no jogo.
// Ela define as características (propriedades) e comportamentos (métodos) que todo herói deve ter,
// sem se preocupar com os detalhes específicos de cada tipo de herói.
public class Hero
{
    /* O construtor é um método especial que inicializa um novo objeto.
    // Ele tem o mesmo nome da classe e é chamado automaticamente ao usar 'new'.
    // Sua função é garantir que o objeto seja criado com valores iniciais válidos,
    // evitando que seus atributos fiquem nulos ou incompletos.*/
    public Hero(string Name, string HeroType, int Health, int Strength, int Agility, int Vitality, int Intelligence, int Charisma)
    {
        // Atribuição correta dos valores aos atributos da classe
        this.Name = Name;
        this.HeroType = HeroType;
        this.Health = Health; 
        this.Strength = Strength;
        this.Agility = Agility;
        this.Vitality = Vitality;
        this.Intelligence = Intelligence;
        this.Charisma = Charisma;
    }

    // PROPRIEDADES: Estes são os atributos que definem o estado de um herói.
    // Eles são parte da Abstração, descrevendo "o que" um herói é e "o que" ele tem.
    public string Name; //Atributos da classe 
    public string HeroType;
    public int Health;
    public int Strength;
    public int Agility;
    public int Vitality;
    public int Intelligence;
    public int Charisma;


    /*Metodo  é uma (ação ) ,
    Override sobrescreve um novo comportamento do Metodo
    To String reprsenta o Objeto de mandeira String(Texto)*/
    // 4. POLIMORFISMO (implícito aqui, mas mais evidente nas classes filhas):
    // O método ToString() é herdado de 'object' e sua implementação é sobrescrita
    // para fornecer uma representação específica do objeto Hero.
    public override string ToString()
    {
        return $" {Name} - Tipo: {HeroType}, Vida: {Health}, Força: {Strength}, Agilidade: {Agility}, Vitalidade: {Vitality}, Inteligencia: {Intelligence}, Carisma: {Charisma}"; 
    }

    // MÉTODOS: 'Attack' é um comportamento que todo herói pode realizar.
    // É parte da Abstração, descrevendo "o que" um herói "faz".
    // 'virtual' permite que classes filhas (Guardian, Gentleman, Adventurous) sobrescrevam este comportamento.
    // 4. POLIMORFISMO: Este método é 'virtual', o que significa que ele pode ter "muitas formas"
    // ou implementações diferentes nas classes que o herdam.
    public virtual string Attack() 
    {
        return $"{Name} atacou!"; 
    }

    // 3. ENCAPSULAMENTO (Exemplo potencial):
    // Embora neste código as propriedades sejam públicas, uma prática comum de encapsulamento
    // seria torná-las privadas e fornecer métodos públicos (getters e setters) para controlá-las.
    // Por exemplo:
    // private int _health;
    // public int Health { get { return _health; } set { if (value >= 0) _health = value; else _health = 0; } }
    // Isso "encapsularia" a regra de que a vida nunca pode ser negativa dentro da própria propriedade.
}

/*obs : Classe e uma forma de um Objetos 
Objeto e a consumo (estância) dessa classe*/