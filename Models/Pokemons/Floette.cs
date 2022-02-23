using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Floette Specie to store common natural stats of every {'abilities': ['flower-veil', 'symbiosis'], 'base_experience': 130, 'height': 2, 'id': 670, 'moves': ['vine-whip', 'tackle', 'razor-leaf', 'solar-beam', 'petal-dance', 'toxic', 'psychic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'wish', 'magic-coat', 'endeavor', 'secret-power', 'aromatherapy', 'covet', 'magical-leaf', 'calm-mind', 'lucky-chant', 'worry-seed', 'seed-bomb', 'energy-ball', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'petal-blizzard', 'grassy-terrain', 'misty-terrain', 'fairy-wind', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'floette', 'stats': {'hp': 54, 'attack': 45, 'defense': 47, 'special-attack': 75, 'special-defense': 98, 'speed': 52}, 'types': ['fairy'], 'weight': 9, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 120, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'フラエッテ', 'ko': '플라엣테', 'zh-Hant': '花葉蒂', 'fr': 'Floette', 'de': 'Floette', 'es': 'Floette', 'it': 'Floette', 'en': 'Floette', 'ja': 'フラエッテ', 'zh-Hans': '花叶蒂'}, 'genera': {'ja-Hrkt': 'いちりんポケモン', 'ko': '한송이포켓몬', 'zh-Hant': '單朵寶可夢', 'fr': 'Pokémon Uniflore', 'de': 'Einblütler', 'es': 'Pokémon Monoflor', 'it': 'Pokémon Monofiore', 'en': 'Single Bloom Pokémon', 'ja': 'いちりんポケモン', 'zh-Hans': '单朵宝可梦'}}
	public class SpecieFloette : PokemonSpecie
	{
#nullable enable
		private static SpecieFloette? _instance = null;
#nullable restore
        public static SpecieFloette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFloette();
                }
                return _instance;
            }
        }

		public SpecieFloette() : base(
			"Floette",
			54, // HPs
			45, 47, // Attack & Defense
			75, 98, // Special Attack & Defense
			52			
		) {}
	}


	//Floette Pokemon Class
	public class Floette : Pokemon
	{

		public Floette(string nickname, int level) : base(
			670,
			SpecieFloette.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Floette() : base(
			670,
			SpecieFloette.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}