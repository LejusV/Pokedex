using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Xurkitree Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 38, 'id': 796, 'moves': ['thunder-punch', 'wrap', 'hyper-beam', 'solar-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'hypnosis', 'double-team', 'light-screen', 'reflect', 'rest', 'substitute', 'protect', 'zap-cannon', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'charge', 'ingrain', 'tail-glow', 'signal-beam', 'calm-mind', 'shock-wave', 'fling', 'energy-ball', 'giga-impact', 'discharge', 'power-whip', 'grass-knot', 'charge-beam', 'round', 'volt-switch', 'wild-charge', 'ion-deluge', 'confide', 'eerie-impulse', 'electric-terrain', 'dazzling-gleam', 'brutal-swing'], 'name': 'xurkitree', 'stats': {'hp': 83, 'attack': 89, 'defense': 71, 'special-attack': 173, 'special-defense': 71, 'speed': 83}, 'types': ['electric'], 'weight': 1000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'black', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'デンジュモク', 'ko': '전수목', 'zh-Hant': '電束木', 'fr': 'Câblifère', 'de': 'Voltriant', 'es': 'Xurkitree', 'it': 'Xurkitree', 'en': 'Xurkitree', 'ja': 'デンジュモク', 'zh-Hans': '电束木'}, 'genera': {'ja-Hrkt': 'でんしょくポケモン', 'ko': '전기장식포켓몬', 'zh-Hant': '燈飾寶可夢', 'fr': 'Pokémon Luminaire', 'de': 'Illumination', 'es': 'Pokémon Luminaria', 'it': 'Pokémon Luminaria', 'en': 'Glowing Pokémon', 'ja': 'でんしょくポケモン', 'zh-Hans': '灯饰宝可梦'}}
	public class SpecieXurkitree : PokemonSpecie
	{
#nullable enable
		private static SpecieXurkitree? _instance = null;
#nullable restore
        public static SpecieXurkitree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXurkitree();
                }
                return _instance;
            }
        }

		public SpecieXurkitree() : base(
			"Xurkitree",
			83, // HPs
			89, 71, // Attack & Defense
			173, 71, // Special Attack & Defense
			83			
		) {}
	}


	//Xurkitree Pokemon Class
	public class Xurkitree : Pokemon
	{

		public Xurkitree(string nickname, int level) : base(
			796,
			SpecieXurkitree.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Xurkitree() : base(
			796,
			SpecieXurkitree.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}