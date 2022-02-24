using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rattata Specie to store common natural stats of every {'abilities': ['run-away', 'guts', 'hustle'], 'base_experience': 51, 'height': 3, 'id': 19, 'moves': ['cut', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'counter', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'focus-energy', 'bide', 'swift', 'skull-bash', 'fury-swipes', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'flame-wheel', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'taunt', 'revenge', 'endeavor', 'secret-power', 'covet', 'shock-wave', 'natural-gift', 'pluck', 'u-turn', 'assurance', 'me-first', 'last-resort', 'sucker-punch', 'zen-headbutt', 'captivate', 'grass-knot', 'charge-beam', 'round', 'retaliate', 'final-gambit', 'work-up', 'wild-charge', 'confide'], 'name': 'rattata', 'stats': {'hp': 30, 'attack': 56, 'defense': 35, 'special-attack': 25, 'special-defense': 35, 'speed': 72}, 'types': ['normal'], 'weight': 35, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'purple', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'コラッタ', 'roomaji': 'Koratta', 'ko': '꼬렛', 'zh-Hant': '小拉達', 'fr': 'Rattata', 'de': 'Rattfratz', 'es': 'Rattata', 'it': 'Rattata', 'en': 'Rattata', 'ja': 'コラッタ', 'zh-Hans': '小拉达'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpecieRattata : PokemonSpecie
	{
#nullable enable
		private static SpecieRattata? _instance = null;
#nullable restore
        public static SpecieRattata Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRattata();
                }
                return _instance;
            }
        }

		public SpecieRattata() : base(
			"Rattata",
			30, // HPs
			56, 35, // Attack & Defense
			25, 35, // Special Attack & Defense
			72			
		) {}
	}


	//Rattata Pokemon Class
	public class Rattata : Pokemon
	{

		public Rattata(string nickname, int level)
		: base(
				19,
				SpecieRattata.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rattata() : base(
			19,
			SpecieRattata.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}