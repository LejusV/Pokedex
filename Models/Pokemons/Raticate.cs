using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raticate Specie to store common natural stats of every {'abilities': ['run-away', 'guts', 'hustle'], 'base_experience': 145, 'height': 7, 'id': 20, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'roar', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'counter', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'bide', 'swift', 'skull-bash', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'taunt', 'endeavor', 'secret-power', 'covet', 'shock-wave', 'natural-gift', 'pluck', 'u-turn', 'assurance', 'last-resort', 'sucker-punch', 'giga-impact', 'zen-headbutt', 'captivate', 'grass-knot', 'charge-beam', 'round', 'retaliate', 'work-up', 'wild-charge', 'confide'], 'name': 'raticate', 'stats': {'hp': 55, 'attack': 81, 'defense': 60, 'special-attack': 50, 'special-defense': 70, 'speed': 97}, 'types': ['normal'], 'weight': 185, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ラッタ', 'roomaji': 'Ratta', 'ko': '레트라', 'zh-Hant': '拉達', 'fr': 'Rattatac', 'de': 'Rattikarl', 'es': 'Raticate', 'it': 'Raticate', 'en': 'Raticate', 'ja': 'ラッタ', 'zh-Hans': '拉达'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpecieRaticate : PokemonSpecie
	{
#nullable enable
		private static SpecieRaticate? _instance = null;
#nullable restore
        public static SpecieRaticate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaticate();
                }
                return _instance;
            }
        }

		public SpecieRaticate() : base(
			"Raticate",
			55, // HPs
			81, 60, // Attack & Defense
			50, 70, // Special Attack & Defense
			97			
		) {}
	}


	//Raticate Pokemon Class
	public class Raticate : Pokemon
	{

		public Raticate(string nickname, int level)
		: base(
				20,
				SpecieRaticate.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Raticate(int level)
		: base(
				20,
				SpecieRaticate.Instance, // Pokemon Specie
				"Raticate", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Raticate() : base(
			20,
			SpecieRaticate.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}