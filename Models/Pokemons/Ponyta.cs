using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ponyta Specie to store common natural stats of every {'abilities': ['run-away', 'flash-fire', 'flame-body'], 'base_experience': 82, 'height': 10, 'id': 77, 'moves': ['stomp', 'double-kick', 'headbutt', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'growl', 'ember', 'flamethrower', 'low-kick', 'strength', 'solar-beam', 'fire-spin', 'toxic', 'hypnosis', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'flame-wheel', 'snore', 'curse', 'protect', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'morning-sun', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'overheat', 'bounce', 'natural-gift', 'flare-blitz', 'captivate', 'flame-charge', 'round', 'echoed-voice', 'ally-switch', 'incinerate', 'inferno', 'wild-charge', 'confide', 'high-horsepower'], 'name': 'ponyta', 'stats': {'hp': 50, 'attack': 85, 'defense': 55, 'special-attack': 65, 'special-defense': 65, 'speed': 90}, 'types': ['fire'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ポニータ', 'roomaji': 'Ponyta', 'ko': '포니타', 'zh-Hant': '小火馬', 'fr': 'Ponyta', 'de': 'Ponita', 'es': 'Ponyta', 'it': 'Ponyta', 'en': 'Ponyta', 'ja': 'ポニータ', 'zh-Hans': '小火马'}, 'genera': {'ja-Hrkt': 'ひのうまポケモン', 'ko': '불의말포켓몬', 'zh-Hant': '火馬寶可夢', 'fr': 'Pokémon Cheval Feu', 'de': 'Feuerpferd', 'es': 'Pokémon Caballo F.', 'it': 'Pokémon Cavalfuoco', 'en': 'Fire Horse Pokémon', 'ja': 'ひのうまポケモン', 'zh-Hans': '火马宝可梦'}}
	public class SpeciePonyta : PokemonSpecie
	{
#nullable enable
		private static SpeciePonyta? _instance = null;
#nullable restore
        public static SpeciePonyta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePonyta();
                }
                return _instance;
            }
        }

		public SpeciePonyta() : base(
			"Ponyta",
			50, // HPs
			85, 55, // Attack & Defense
			65, 65, // Special Attack & Defense
			90			
		) {}
	}


	//Ponyta Pokemon Class
	public class Ponyta : Pokemon
	{

		public Ponyta(string nickname, int level)
		: base(
				77,
				SpeciePonyta.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ponyta(int level)
		: base(
				77,
				SpeciePonyta.Instance, // Pokemon Specie
				"Ponyta", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ponyta() : base(
			77,
			SpeciePonyta.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}