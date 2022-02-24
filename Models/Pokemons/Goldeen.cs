using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Goldeen Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-veil', 'lightning-rod'], 'base_experience': 64, 'height': 6, 'id': 118, 'moves': ['horn-attack', 'fury-attack', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'peck', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'haze', 'bide', 'waterfall', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'knock-off', 'secret-power', 'dive', 'mud-sport', 'signal-beam', 'bounce', 'mud-shot', 'water-sport', 'water-pulse', 'natural-gift', 'aqua-ring', 'poison-jab', 'aqua-tail', 'captivate', 'soak', 'round', 'scald', 'drill-run', 'confide', 'smart-strike'], 'name': 'goldeen', 'stats': {'hp': 45, 'attack': 67, 'defense': 60, 'special-attack': 35, 'special-defense': 50, 'speed': 63}, 'types': ['water'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'red', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'トサキント', 'roomaji': 'Tosakinto', 'ko': '콘치', 'zh-Hant': '角金魚', 'fr': 'Poissirène', 'de': 'Goldini', 'es': 'Goldeen', 'it': 'Goldeen', 'en': 'Goldeen', 'ja': 'トサキント', 'zh-Hans': '角金鱼'}, 'genera': {'ja-Hrkt': 'きんぎょポケモン', 'ko': '금붕어포켓몬', 'zh-Hant': '金魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Goldfisch', 'es': 'Pokémon Pez Color', 'it': 'Pokémon Pescerosso', 'en': 'Goldfish Pokémon', 'ja': 'きんぎょポケモン', 'zh-Hans': '金鱼宝可梦'}}
	public class SpecieGoldeen : PokemonSpecie
	{
#nullable enable
		private static SpecieGoldeen? _instance = null;
#nullable restore
        public static SpecieGoldeen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoldeen();
                }
                return _instance;
            }
        }

		public SpecieGoldeen() : base(
			"Goldeen",
			45, // HPs
			67, 60, // Attack & Defense
			35, 50, // Special Attack & Defense
			63			
		) {}
	}


	//Goldeen Pokemon Class
	public class Goldeen : Pokemon
	{

		public Goldeen(string nickname, int level)
		: base(
				118,
				SpecieGoldeen.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goldeen(int level)
		: base(
				118,
				SpecieGoldeen.Instance, // Pokemon Specie
				"Goldeen", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goldeen() : base(
			118,
			SpecieGoldeen.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}