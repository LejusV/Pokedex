using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Minun Specie to store common natural stats of every {'abilities': ['minus', 'volt-absorb'], 'base_experience': 142, 'height': 4, 'id': 312, 'moves': ['mega-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'growl', 'sing', 'counter', 'seismic-toss', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'metronome', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sweet-kiss', 'mud-slap', 'endure', 'charm', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'uproar', 'facade', 'charge', 'helping-hand', 'wish', 'secret-power', 'fake-tears', 'signal-beam', 'shock-wave', 'natural-gift', 'fling', 'trump-card', 'lucky-chant', 'copycat', 'last-resort', 'magnet-rise', 'switcheroo', 'nasty-plot', 'discharge', 'captivate', 'grass-knot', 'charge-beam', 'electro-ball', 'entrainment', 'round', 'echoed-voice', 'volt-switch', 'electroweb', 'wild-charge', 'play-nice', 'confide', 'nuzzle', 'tearful-look'], 'name': 'minun', 'stats': {'hp': 60, 'attack': 40, 'defense': 50, 'special-attack': 75, 'special-defense': 85, 'speed': 95}, 'types': ['electric'], 'weight': 42, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'yellow', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'マイナン', 'roomaji': 'Minun', 'ko': '마이농', 'zh-Hant': '負電拍拍', 'fr': 'Négapi', 'de': 'Minun', 'es': 'Minun', 'it': 'Minun', 'en': 'Minun', 'ja': 'マイナン', 'zh-Hans': '負电拍拍'}, 'genera': {'ja-Hrkt': 'おうえんポケモン', 'ko': '응원포켓몬', 'zh-Hant': '加油寶可夢', 'fr': 'Pokémon Acclameur', 'de': 'Jubel', 'es': 'Pokémon Ánimo', 'it': 'Pokémon Incitamento', 'en': 'Cheering Pokémon', 'ja': 'おうえんポケモン', 'zh-Hans': '加油宝可梦'}}
	public class SpecieMinun : PokemonSpecie
	{
#nullable enable
		private static SpecieMinun? _instance = null;
#nullable restore
        public static SpecieMinun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMinun();
                }
                return _instance;
            }
        }

		public SpecieMinun() : base(
			"Minun",
			60, // HPs
			40, 50, // Attack & Defense
			75, 85, // Special Attack & Defense
			95			
		) {}
	}


	//Minun Pokemon Class
	public class Minun : Pokemon
	{

		public Minun(string nickname, int level)
		: base(
				312,
				SpecieMinun.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Minun() : base(
			312,
			SpecieMinun.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}