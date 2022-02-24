using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Elekid Specie to store common natural stats of every {'abilities': ['static', 'vital-spirit'], 'base_experience': 72, 'height': 6, 'id': 239, 'moves': ['karate-chop', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'rolling-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'low-kick', 'counter', 'seismic-toss', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'meditate', 'quick-attack', 'mimic', 'screech', 'double-team', 'barrier', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'cross-chop', 'rain-dance', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'signal-beam', 'covet', 'shock-wave', 'hammer-arm', 'natural-gift', 'feint', 'fling', 'magnet-rise', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'electroweb', 'wild-charge', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'elekid', 'stats': {'hp': 45, 'attack': 63, 'defense': 37, 'special-attack': 65, 'special-defense': 55, 'speed': 95}, 'types': ['electric'], 'weight': 235, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 45, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'エレキッド', 'roomaji': 'Elekid', 'ko': '에레키드', 'zh-Hant': '電擊怪', 'fr': 'Élekid', 'de': 'Elekid', 'es': 'Elekid', 'it': 'Elekid', 'en': 'Elekid', 'ja': 'エレキッド', 'zh-Hans': '电击怪'}, 'genera': {'ja-Hrkt': 'でんきポケモン', 'ko': '전류포켓몬', 'zh-Hant': '電氣寶可夢', 'fr': 'Pokémon Électrique', 'de': 'Elektro', 'es': 'Pokémon Eléctrico', 'it': 'Pokémon Elettrico', 'en': 'Electric Pokémon', 'ja': 'でんきポケモン', 'zh-Hans': '电气宝可梦'}}
	public class SpecieElekid : PokemonSpecie
	{
#nullable enable
		private static SpecieElekid? _instance = null;
#nullable restore
        public static SpecieElekid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElekid();
                }
                return _instance;
            }
        }

		public SpecieElekid() : base(
			"Elekid",
			45, // HPs
			63, 37, // Attack & Defense
			65, 55, // Special Attack & Defense
			95			
		) {}
	}


	//Elekid Pokemon Class
	public class Elekid : Pokemon
	{

		public Elekid(string nickname, int level)
		: base(
				239,
				SpecieElekid.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Elekid() : base(
			239,
			SpecieElekid.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}