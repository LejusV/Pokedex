using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Electivire Specie to store common natural stats of every {'abilities': ['motor-drive', 'vital-spirit'], 'base_experience': 243, 'height': 18, 'id': 466, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'leer', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'psychic', 'quick-attack', 'screech', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'brick-break', 'secret-power', 'rock-tomb', 'signal-beam', 'covet', 'shock-wave', 'natural-gift', 'fling', 'magnet-rise', 'focus-blast', 'giga-impact', 'rock-climb', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'low-sweep', 'round', 'volt-switch', 'bulldoze', 'electroweb', 'wild-charge', 'dual-chop', 'ion-deluge', 'confide', 'electric-terrain', 'power-up-punch'], 'name': 'electivire', 'stats': {'hp': 75, 'attack': 123, 'defense': 67, 'special-attack': 95, 'special-defense': 85, 'speed': 95}, 'types': ['electric'], 'weight': 1386, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 30, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'エレキブル', 'roomaji': 'Elekible', 'ko': '에레키블', 'zh-Hant': '電擊魔獸', 'fr': 'Élekable', 'de': 'Elevoltek', 'es': 'Electivire', 'it': 'Electivire', 'en': 'Electivire', 'ja': 'エレキブル', 'zh-Hans': '电击魔兽'}, 'genera': {'ja-Hrkt': 'らいでんポケモン', 'ko': '뇌전포켓몬', 'zh-Hant': '雷電寶可夢', 'fr': 'Pokémon Foudrélec', 'de': 'Donnerkeil', 'es': 'Pokémon Rayo', 'it': 'Pokémon Saetta', 'en': 'Thunderbolt Pokémon', 'ja': 'らいでんポケモン', 'zh-Hans': '雷电宝可梦'}}
	public class SpecieElectivire : PokemonSpecie
	{
#nullable enable
		private static SpecieElectivire? _instance = null;
#nullable restore
        public static SpecieElectivire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectivire();
                }
                return _instance;
            }
        }

		public SpecieElectivire() : base(
			"Electivire",
			75, // HPs
			123, 67, // Attack & Defense
			95, 85, // Special Attack & Defense
			95			
		) {}
	}


	//Electivire Pokemon Class
	public class Electivire : Pokemon
	{

		public Electivire(string nickname, int level)
		: base(
				466,
				SpecieElectivire.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electivire() : base(
			466,
			SpecieElectivire.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}