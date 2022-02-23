using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pichu Specie to store common natural stats of every {'abilities': ['static', 'lightning-rod'], 'base_experience': 41, 'height': 3, 'id': 172, 'moves': ['double-slap', 'mega-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'counter', 'seismic-toss', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'bide', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'reversal', 'protect', 'sweet-kiss', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'present', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'fake-out', 'uproar', 'facade', 'charge', 'helping-hand', 'wish', 'secret-power', 'tickle', 'signal-beam', 'covet', 'volt-tackle', 'shock-wave', 'natural-gift', 'fling', 'lucky-chant', 'magnet-rise', 'nasty-plot', 'captivate', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'bestow', 'volt-switch', 'electroweb', 'wild-charge', 'disarming-voice', 'confide', 'electric-terrain'], 'name': 'pichu', 'stats': {'hp': 20, 'attack': 40, 'defense': 15, 'special-attack': 35, 'special-defense': 35, 'speed': 60}, 'types': ['electric'], 'weight': 20, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ピチュー', 'roomaji': 'Pichu', 'ko': '피츄', 'zh-Hant': '皮丘', 'fr': 'Pichu', 'de': 'Pichu', 'es': 'Pichu', 'it': 'Pichu', 'en': 'Pichu', 'ja': 'ピチュー', 'zh-Hans': '皮丘'}, 'genera': {'ja-Hrkt': 'こねずみポケモン', 'ko': '아기쥐포켓몬', 'zh-Hant': '小鼠寶可夢', 'fr': 'Pokémon Minisouris', 'de': 'Babymaus', 'es': 'Pokémon Ratoncito', 'it': 'Pokémon Topino', 'en': 'Tiny Mouse Pokémon', 'ja': 'こねずみポケモン', 'zh-Hans': '小鼠宝可梦'}}
	public class SpeciePichu : PokemonSpecie
	{
#nullable enable
		private static SpeciePichu? _instance = null;
#nullable restore
        public static SpeciePichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePichu();
                }
                return _instance;
            }
        }

		public SpeciePichu() : base(
			"Pichu",
			20, // HPs
			40, 15, // Attack & Defense
			35, 35, // Special Attack & Defense
			60			
		) {}
	}


	//Pichu Pokemon Class
	public class Pichu : Pokemon
	{

		public Pichu(string nickname, int level) : base(
			172,
			SpeciePichu.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Pichu() : base(
			172,
			SpeciePichu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}