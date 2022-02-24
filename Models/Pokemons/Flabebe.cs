using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flabebe Specie to store common natural stats of every {'abilities': ['flower-veil', 'symbiosis'], 'base_experience': 61, 'height': 1, 'id': 669, 'moves': ['vine-whip', 'tackle', 'razor-leaf', 'solar-beam', 'petal-dance', 'toxic', 'psychic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'wish', 'magic-coat', 'endeavor', 'secret-power', 'camouflage', 'aromatherapy', 'covet', 'magical-leaf', 'calm-mind', 'lucky-chant', 'copycat', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'petal-blizzard', 'grassy-terrain', 'misty-terrain', 'fairy-wind', 'moonblast', 'confide', 'dazzling-gleam', 'tearful-look'], 'name': 'flabebe', 'stats': {'hp': 44, 'attack': 38, 'defense': 39, 'special-attack': 61, 'special-defense': 79, 'speed': 42}, 'types': ['fairy'], 'weight': 1, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 225, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'フラベベ', 'ko': '플라베베', 'zh-Hant': '花蓓蓓', 'fr': 'Flabébé', 'de': 'Flabébé', 'es': 'Flabébé', 'it': 'Flabébé', 'en': 'Flabébé', 'ja': 'フラベベ', 'zh-Hans': '花蓓蓓'}, 'genera': {'ja-Hrkt': 'いちりんポケモン', 'ko': '한송이포켓몬', 'zh-Hant': '單朵寶可夢', 'fr': 'Pokémon Uniflore', 'de': 'Einblütler', 'es': 'Pokémon Monoflor', 'it': 'Pokémon Monofiore', 'en': 'Single Bloom Pokémon', 'ja': 'いちりんポケモン', 'zh-Hans': '单朵宝可梦'}}
	public class SpecieFlabebe : PokemonSpecie
	{
#nullable enable
		private static SpecieFlabebe? _instance = null;
#nullable restore
        public static SpecieFlabebe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlabebe();
                }
                return _instance;
            }
        }

		public SpecieFlabebe() : base(
			"Flabebe",
			44, // HPs
			38, 39, // Attack & Defense
			61, 79, // Special Attack & Defense
			42			
		) {}
	}


	//Flabebe Pokemon Class
	public class Flabebe : Pokemon
	{

		public Flabebe(string nickname, int level)
		: base(
				669,
				SpecieFlabebe.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flabebe(int level)
		: base(
				669,
				SpecieFlabebe.Instance, // Pokemon Specie
				"Flabebe", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flabebe() : base(
			669,
			SpecieFlabebe.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}