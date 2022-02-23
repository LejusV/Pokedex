using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Plusle Specie to store common natural stats of every {'abilities': ['plus', 'lightning-rod'], 'base_experience': 142, 'height': 4, 'id': 311, 'moves': ['mega-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'growl', 'sing', 'counter', 'seismic-toss', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'metronome', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sweet-kiss', 'mud-slap', 'endure', 'charm', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'uproar', 'facade', 'charge', 'helping-hand', 'wish', 'secret-power', 'fake-tears', 'signal-beam', 'shock-wave', 'natural-gift', 'fling', 'lucky-chant', 'copycat', 'last-resort', 'magnet-rise', 'nasty-plot', 'discharge', 'captivate', 'grass-knot', 'charge-beam', 'electro-ball', 'entrainment', 'round', 'echoed-voice', 'bestow', 'volt-switch', 'electroweb', 'wild-charge', 'play-nice', 'confide', 'nuzzle', 'tearful-look'], 'name': 'plusle', 'stats': {'hp': 60, 'attack': 50, 'defense': 40, 'special-attack': 85, 'special-defense': 75, 'speed': 95}, 'types': ['electric'], 'weight': 42, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'yellow', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'プラスル', 'roomaji': 'Prasle', 'ko': '플러시', 'zh-Hant': '正電拍拍', 'fr': 'Posipi', 'de': 'Plusle', 'es': 'Plusle', 'it': 'Plusle', 'en': 'Plusle', 'ja': 'プラスル', 'zh-Hans': '正电拍拍'}, 'genera': {'ja-Hrkt': 'おうえんポケモン', 'ko': '응원포켓몬', 'zh-Hant': '加油寶可夢', 'fr': 'Pokémon Acclameur', 'de': 'Jubel', 'es': 'Pokémon Ánimo', 'it': 'Pokémon Incitamento', 'en': 'Cheering Pokémon', 'ja': 'おうえんポケモン', 'zh-Hans': '加油宝可梦'}}
	public class SpeciePlusle : PokemonSpecie
	{
#nullable enable
		private static SpeciePlusle? _instance = null;
#nullable restore
        public static SpeciePlusle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePlusle();
                }
                return _instance;
            }
        }

		public SpeciePlusle() : base(
			"Plusle",
			60, // HPs
			50, 40, // Attack & Defense
			85, 75, // Special Attack & Defense
			95			
		) {}
	}


	//Plusle Pokemon Class
	public class Plusle : Pokemon
	{

		public Plusle(string nickname, int level) : base(
			311,
			SpeciePlusle.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Plusle() : base(
			311,
			SpeciePlusle.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}