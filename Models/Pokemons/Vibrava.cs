using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vibrava Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 119, 'height': 11, 'id': 329, 'moves': ['fly', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'bite', 'supersonic', 'sonic-boom', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'bide', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'feint-attack', 'mud-slap', 'outrage', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'heat-wave', 'facade', 'superpower', 'secret-power', 'air-cutter', 'rock-tomb', 'silver-wind', 'signal-beam', 'sand-tomb', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'bug-buzz', 'dragon-pulse', 'earth-power', 'defog', 'draco-meteor', 'captivate', 'bug-bite', 'ominous-wind', 'round', 'struggle-bug', 'bulldoze', 'boomburst', 'confide'], 'name': 'vibrava', 'stats': {'hp': 50, 'attack': 70, 'defense': 50, 'special-attack': 50, 'special-defense': 50, 'speed': 70}, 'types': ['ground', 'dragon'], 'weight': 153, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'bug-wings', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ビブラーバ', 'roomaji': 'Vibrava', 'ko': '비브라바', 'zh-Hant': '超音波幼蟲', 'fr': 'Vibraninf', 'de': 'Vibrava', 'es': 'Vibrava', 'it': 'Vibrava', 'en': 'Vibrava', 'ja': 'ビブラーバ', 'zh-Hans': '超音波幼虫'}, 'genera': {'ja-Hrkt': 'しんどうポケモン', 'ko': '진동포켓몬', 'zh-Hant': '震動寶可夢', 'fr': 'Pokémon Vibration', 'de': 'Vibration', 'es': 'Pokémon Vibrante', 'it': 'Pokémon Vibrazione', 'en': 'Vibration Pokémon', 'ja': 'しんどうポケモン', 'zh-Hans': '振动宝可梦'}}
	public class SpecieVibrava : PokemonSpecie
	{
#nullable enable
		private static SpecieVibrava? _instance = null;
#nullable restore
        public static SpecieVibrava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVibrava();
                }
                return _instance;
            }
        }

		public SpecieVibrava() : base(
			"Vibrava",
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			70			
		) {}
	}


	//Vibrava Pokemon Class
	public class Vibrava : Pokemon
	{

		public Vibrava(string nickname, int level) : base(
			329,
			SpecieVibrava.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Dragon.Instance			
		) {}

		public Vibrava() : base(
			329,
			SpecieVibrava.Instance, // Pokemon Specie
			Ground.Instance, Dragon.Instance			
		) {}
	}
}