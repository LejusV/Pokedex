using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oddish Specie to store common natural stats of every {'abilities': ['chlorophyll', 'run-away'], 'base_experience': 64, 'height': 5, 'id': 43, 'moves': ['swords-dance', 'cut', 'take-down', 'double-edge', 'acid', 'absorb', 'mega-drain', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'petal-dance', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'moonlight', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'secret-power', 'teeter-dance', 'tickle', 'bullet-seed', 'natural-gift', 'gastro-acid', 'lucky-chant', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'venoshock', 'after-you', 'round', 'grassy-terrain', 'moonblast', 'confide', 'dazzling-gleam', 'infestation', 'strength-sap'], 'name': 'oddish', 'stats': {'hp': 45, 'attack': 50, 'defense': 55, 'special-attack': 75, 'special-defense': 65, 'speed': 30}, 'types': ['grass', 'poison'], 'weight': 54, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'legs', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ナゾノクサ', 'roomaji': 'Nazonokusa', 'ko': '뚜벅쵸', 'zh-Hant': '走路草', 'fr': 'Mystherbe', 'de': 'Myrapla', 'es': 'Oddish', 'it': 'Oddish', 'en': 'Oddish', 'ja': 'ナゾノクサ', 'zh-Hans': '走路草'}, 'genera': {'ja-Hrkt': 'ざっそうポケモン', 'ko': '잡초포켓몬', 'zh-Hant': '雜草寶可夢', 'fr': 'Pokémon Racine', 'de': 'Unkraut', 'es': 'Pokémon Hierbajo', 'it': 'Pokémon Malerba', 'en': 'Weed Pokémon', 'ja': 'ざっそうポケモン', 'zh-Hans': '杂草宝可梦'}}
	public class SpecieOddish : PokemonSpecie
	{
#nullable enable
		private static SpecieOddish? _instance = null;
#nullable restore
        public static SpecieOddish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOddish();
                }
                return _instance;
            }
        }

		public SpecieOddish() : base(
			"Oddish",
			45, // HPs
			50, 55, // Attack & Defense
			75, 65, // Special Attack & Defense
			30			
		) {}
	}


	//Oddish Pokemon Class
	public class Oddish : Pokemon
	{

		public Oddish(string nickname, int level) : base(
			43,
			SpecieOddish.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Oddish() : base(
			43,
			SpecieOddish.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}