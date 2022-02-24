using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Electabuzz Specie to store common natural stats of every {'abilities': ['static', 'vital-spirit'], 'base_experience': 172, 'height': 11, 'id': 125, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'quick-attack', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'metronome', 'swift', 'skull-bash', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'signal-beam', 'covet', 'shock-wave', 'natural-gift', 'fling', 'magnet-rise', 'focus-blast', 'giga-impact', 'rock-climb', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'low-sweep', 'round', 'volt-switch', 'electroweb', 'wild-charge', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'electabuzz', 'stats': {'hp': 65, 'attack': 83, 'defense': 57, 'special-attack': 95, 'special-defense': 85, 'speed': 105}, 'types': ['electric'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 45, 'color': 'yellow', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'エレブー', 'roomaji': 'Eleboo', 'ko': '에레브', 'zh-Hant': '電擊獸', 'fr': 'Élektek', 'de': 'Elektek', 'es': 'Electabuzz', 'it': 'Electabuzz', 'en': 'Electabuzz', 'ja': 'エレブー', 'zh-Hans': '电击兽'}, 'genera': {'ja-Hrkt': 'でんげきポケモン', 'ko': '전기포켓몬', 'zh-Hant': '電擊寶可夢', 'fr': 'Pokémon Électrique', 'de': 'Elektro', 'es': 'Pokémon Eléctrico', 'it': 'Pokémon Elettrico', 'en': 'Electric Pokémon', 'ja': 'でんげきポケモン', 'zh-Hans': '电击宝可梦'}}
	public class SpecieElectabuzz : PokemonSpecie
	{
#nullable enable
		private static SpecieElectabuzz? _instance = null;
#nullable restore
        public static SpecieElectabuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectabuzz();
                }
                return _instance;
            }
        }

		public SpecieElectabuzz() : base(
			"Electabuzz",
			65, // HPs
			83, 57, // Attack & Defense
			95, 85, // Special Attack & Defense
			105			
		) {}
	}


	//Electabuzz Pokemon Class
	public class Electabuzz : Pokemon
	{

		public Electabuzz(string nickname, int level)
		: base(
				125,
				SpecieElectabuzz.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electabuzz(int level)
		: base(
				125,
				SpecieElectabuzz.Instance, // Pokemon Specie
				"Electabuzz", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electabuzz() : base(
			125,
			SpecieElectabuzz.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}