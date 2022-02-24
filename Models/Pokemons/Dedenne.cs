using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dedenne Specie to store common natural stats of every {'abilities': ['cheek-pouch', 'pickup', 'plus'], 'base_experience': 151, 'height': 2, 'id': 702, 'moves': ['thunder-punch', 'cut', 'tackle', 'tail-whip', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'double-team', 'flash', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'protect', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'charge', 'helping-hand', 'recycle', 'secret-power', 'signal-beam', 'aerial-ace', 'covet', 'shock-wave', 'natural-gift', 'u-turn', 'fling', 'last-resort', 'magnet-rise', 'giga-impact', 'discharge', 'grass-knot', 'charge-beam', 'entrainment', 'round', 'retaliate', 'volt-switch', 'electroweb', 'wild-charge', 'parabolic-charge', 'play-rough', 'confide', 'eerie-impulse', 'nuzzle', 'tearful-look'], 'name': 'dedenne', 'stats': {'hp': 67, 'attack': 58, 'defense': 57, 'special-attack': 81, 'special-defense': 67, 'speed': 101}, 'types': ['electric', 'fairy'], 'weight': 22, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 180, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'デデンネ', 'ko': '데덴네', 'zh-Hant': '咚咚鼠', 'fr': 'Dedenne', 'de': 'Dedenne', 'es': 'Dedenne', 'it': 'Dedenne', 'en': 'Dedenne', 'ja': 'デデンネ', 'zh-Hans': '咚咚鼠'}, 'genera': {'ja-Hrkt': 'アンテナポケモン', 'ko': '안테나포켓몬', 'zh-Hant': '天線寶可夢', 'fr': 'Pokémon Antenne', 'de': 'Antennen', 'es': 'Pokémon Antenas', 'it': 'Pokémon Antenna', 'en': 'Antenna Pokémon', 'ja': 'アンテナポケモン', 'zh-Hans': '天线宝可梦'}}
	public class SpecieDedenne : PokemonSpecie
	{
#nullable enable
		private static SpecieDedenne? _instance = null;
#nullable restore
        public static SpecieDedenne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDedenne();
                }
                return _instance;
            }
        }

		public SpecieDedenne() : base(
			"Dedenne",
			67, // HPs
			58, 57, // Attack & Defense
			81, 67, // Special Attack & Defense
			101			
		) {}
	}


	//Dedenne Pokemon Class
	public class Dedenne : Pokemon
	{

		public Dedenne(string nickname, int level)
		: base(
				702,
				SpecieDedenne.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dedenne() : base(
			702,
			SpecieDedenne.Instance, // Pokemon Specie
			Electric.Instance, Fairy.Instance			
		) {}
	}
}