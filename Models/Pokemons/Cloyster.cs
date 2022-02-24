using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cloyster Specie to store common natural stats of every {'abilities': ['shell-armor', 'skill-link', 'overcoat'], 'base_experience': 184, 'height': 15, 'id': 91, 'moves': ['take-down', 'double-edge', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'toxic', 'rage', 'teleport', 'mimic', 'double-team', 'withdraw', 'reflect', 'bide', 'self-destruct', 'clamp', 'swift', 'spike-cannon', 'explosion', 'rest', 'tri-attack', 'substitute', 'snore', 'curse', 'protect', 'spikes', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'torment', 'facade', 'secret-power', 'dive', 'signal-beam', 'iron-defense', 'water-pulse', 'brine', 'natural-gift', 'payback', 'toxic-spikes', 'poison-jab', 'giga-impact', 'avalanche', 'captivate', 'round', 'shell-smash', 'frost-breath', 'icicle-crash', 'confide', 'smart-strike'], 'name': 'cloyster', 'stats': {'hp': 50, 'attack': 95, 'defense': 180, 'special-attack': 85, 'special-defense': 45, 'speed': 70}, 'types': ['water', 'ice'], 'weight': 1325, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'ball', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'パルシェン', 'roomaji': 'Parshen', 'ko': '파르셀', 'zh-Hant': '刺甲貝', 'fr': 'Crustabri', 'de': 'Austos', 'es': 'Cloyster', 'it': 'Cloyster', 'en': 'Cloyster', 'ja': 'パルシェン', 'zh-Hans': '刺甲贝'}, 'genera': {'ja-Hrkt': '２まいがいポケモン', 'ko': '두조개포켓몬', 'zh-Hant': '雙殼貝寶可夢', 'fr': 'Pokémon Bivalve', 'de': 'Muschel', 'es': 'Pokémon Bivalvo', 'it': 'Pokémon Bivalve', 'en': 'Bivalve Pokémon', 'ja': '２まいがいポケモン', 'zh-Hans': '双壳贝宝可梦'}}
	public class SpecieCloyster : PokemonSpecie
	{
#nullable enable
		private static SpecieCloyster? _instance = null;
#nullable restore
        public static SpecieCloyster Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCloyster();
                }
                return _instance;
            }
        }

		public SpecieCloyster() : base(
			"Cloyster",
			50, // HPs
			95, 180, // Attack & Defense
			85, 45, // Special Attack & Defense
			70			
		) {}
	}


	//Cloyster Pokemon Class
	public class Cloyster : Pokemon
	{

		public Cloyster(string nickname, int level)
		: base(
				91,
				SpecieCloyster.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cloyster() : base(
			91,
			SpecieCloyster.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
	}
}