using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crustle Specie to store common natural stats of every {'abilities': ['sturdy', 'shell-armor', 'weak-armor'], 'base_experience': 170, 'height': 14, 'id': 558, 'moves': ['swords-dance', 'cut', 'sand-attack', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'flail', 'protect', 'feint-attack', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'facade', 'nature-power', 'knock-off', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'rock-blast', 'rock-polish', 'poison-jab', 'x-scissor', 'giga-impact', 'shadow-claw', 'rock-wrecker', 'stone-edge', 'stealth-rock', 'bug-bite', 'hone-claws', 'smack-down', 'round', 'shell-smash', 'struggle-bug', 'bulldoze', 'confide'], 'name': 'crustle', 'stats': {'hp': 70, 'attack': 105, 'defense': 125, 'special-attack': 65, 'special-defense': 75, 'speed': 45}, 'types': ['bug', 'rock'], 'weight': 2000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug', 'mineral'], 'names': {'ja-Hrkt': 'イワパレス', 'ko': '암팰리스', 'zh-Hant': '岩殿居蟹', 'fr': 'Crabaraque', 'de': 'Castellith', 'es': 'Crustle', 'it': 'Crustle', 'en': 'Crustle', 'ja': 'イワパレス', 'zh-Hans': '岩殿居蟹'}, 'genera': {'ja-Hrkt': 'いわやどポケモン', 'ko': '바위집포켓몬', 'zh-Hant': '岩居寶可夢', 'fr': 'Pokémon Lapidicole', 'de': 'Felshaus', 'es': 'Pokémon Casarroca', 'it': 'Pokémon Scogliocasa', 'en': 'Stone Home Pokémon', 'ja': 'いわやどポケモン', 'zh-Hans': '岩居宝可梦'}}
	public class SpecieCrustle : PokemonSpecie
	{
#nullable enable
		private static SpecieCrustle? _instance = null;
#nullable restore
        public static SpecieCrustle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrustle();
                }
                return _instance;
            }
        }

		public SpecieCrustle() : base(
			"Crustle",
			70, // HPs
			105, 125, // Attack & Defense
			65, 75, // Special Attack & Defense
			45			
		) {}
	}


	//Crustle Pokemon Class
	public class Crustle : Pokemon
	{

		public Crustle(string nickname, int level)
		: base(
				558,
				SpecieCrustle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crustle(int level)
		: base(
				558,
				SpecieCrustle.Instance, // Pokemon Specie
				"Crustle", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crustle() : base(
			558,
			SpecieCrustle.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
	}
}