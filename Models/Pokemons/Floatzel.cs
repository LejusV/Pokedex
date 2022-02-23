using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Floatzel Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-veil'], 'base_experience': 173, 'height': 11, 'id': 419, 'moves': ['ice-punch', 'razor-wind', 'headbutt', 'growl', 'roar', 'sonic-boom', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'waterfall', 'swift', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'whirlpool', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'bulk-up', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'payback', 'aqua-tail', 'focus-blast', 'giga-impact', 'ice-fang', 'captivate', 'aqua-jet', 'double-hit', 'round', 'echoed-voice', 'scald', 'confide', 'power-up-punch'], 'name': 'floatzel', 'stats': {'hp': 85, 'attack': 105, 'defense': 55, 'special-attack': 85, 'special-defense': 50, 'speed': 115}, 'types': ['water'], 'weight': 335, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'フローゼル', 'roomaji': 'Flowsel', 'ko': '플로젤', 'zh-Hant': '浮潛鼬', 'fr': 'Mustéflott', 'de': 'Bojelin', 'es': 'Floatzel', 'it': 'Floatzel', 'en': 'Floatzel', 'ja': 'フローゼル', 'zh-Hans': '浮潜鼬'}, 'genera': {'ja-Hrkt': 'うみイタチポケモン', 'ko': '바다족제비포켓몬', 'zh-Hant': '海鼬寶可夢', 'fr': 'Pokémon Aquabelette', 'de': 'Meereswiesel', 'es': 'Pokémon Nutria Mar.', 'it': 'Pokémon Maridonnola', 'en': 'Sea Weasel Pokémon', 'ja': 'うみイタチポケモン', 'zh-Hans': '海鼬宝可梦'}}
	public class SpecieFloatzel : PokemonSpecie
	{
#nullable enable
		private static SpecieFloatzel? _instance = null;
#nullable restore
        public static SpecieFloatzel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFloatzel();
                }
                return _instance;
            }
        }

		public SpecieFloatzel() : base(
			"Floatzel",
			85, // HPs
			105, 55, // Attack & Defense
			85, 50, // Special Attack & Defense
			115			
		) {}
	}


	//Floatzel Pokemon Class
	public class Floatzel : Pokemon
	{

		public Floatzel(string nickname, int level) : base(
			419,
			SpecieFloatzel.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Floatzel() : base(
			419,
			SpecieFloatzel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}