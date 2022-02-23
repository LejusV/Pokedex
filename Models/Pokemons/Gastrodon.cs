using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gastrodon Specie to store common natural stats of every {'abilities': ['sticky-hold', 'storm-drain', 'sand-force'], 'base_experience': 166, 'height': 9, 'id': 423, 'moves': ['headbutt', 'body-slam', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'string-shot', 'earthquake', 'dig', 'toxic', 'double-team', 'recover', 'harden', 'waterfall', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'muddy-water', 'block', 'water-pulse', 'brine', 'natural-gift', 'earth-power', 'giga-impact', 'mud-bomb', 'stone-edge', 'captivate', 'sludge-wave', 'round', 'scald', 'bulldoze', 'confide', 'infestation'], 'name': 'gastrodon', 'stats': {'hp': 111, 'attack': 83, 'defense': 68, 'special-attack': 92, 'special-defense': 82, 'speed': 39}, 'types': ['water', 'ground'], 'weight': 299, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'indeterminate'], 'names': {'ja-Hrkt': 'トリトドン', 'roomaji': 'Toritodon', 'ko': '트리토돈', 'zh-Hant': '海兔獸', 'fr': 'Tritosor', 'de': 'Gastrodon', 'es': 'Gastrodon', 'it': 'Gastrodon', 'en': 'Gastrodon', 'ja': 'トリトドン', 'zh-Hans': '海兔兽'}, 'genera': {'ja-Hrkt': 'ウミウシポケモン', 'ko': '갯민숭달팽이포켓몬', 'zh-Hant': '海兔寶可夢', 'fr': 'Pokémon Aqualimace', 'de': 'Seeschnecke', 'es': 'Pokémon Babosa Mar.', 'it': 'Pokémon Lumacomare', 'en': 'Sea Slug Pokémon', 'ja': 'ウミウシポケモン', 'zh-Hans': '海兔宝可梦'}}
	public class SpecieGastrodon : PokemonSpecie
	{
#nullable enable
		private static SpecieGastrodon? _instance = null;
#nullable restore
        public static SpecieGastrodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGastrodon();
                }
                return _instance;
            }
        }

		public SpecieGastrodon() : base(
			"Gastrodon",
			111, // HPs
			83, 68, // Attack & Defense
			92, 82, // Special Attack & Defense
			39			
		) {}
	}


	//Gastrodon Pokemon Class
	public class Gastrodon : Pokemon
	{

		public Gastrodon(string nickname, int level) : base(
			423,
			SpecieGastrodon.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Gastrodon() : base(
			423,
			SpecieGastrodon.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}