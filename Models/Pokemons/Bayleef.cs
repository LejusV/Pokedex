using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bayleef Specie to store common natural stats of every {'abilities': ['overgrow', 'leaf-guard'], 'base_experience': 142, 'height': 12, 'id': 153, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'growl', 'counter', 'strength', 'razor-leaf', 'solar-beam', 'poison-powder', 'toxic', 'mimic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'nature-power', 'magic-coat', 'secret-power', 'aromatherapy', 'bullet-seed', 'magical-leaf', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'grass-pledge', 'work-up', 'confide'], 'name': 'bayleef', 'stats': {'hp': 60, 'attack': 62, 'defense': 80, 'special-attack': 63, 'special-defense': 80, 'speed': 60}, 'types': ['grass'], 'weight': 158, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ベイリーフ', 'roomaji': 'Bayleaf', 'ko': '베이리프', 'zh-Hant': '月桂葉', 'fr': 'Macronium', 'de': 'Lorblatt', 'es': 'Bayleef', 'it': 'Bayleef', 'en': 'Bayleef', 'ja': 'ベイリーフ', 'zh-Hans': '月桂叶'}, 'genera': {'ja-Hrkt': 'はっぱポケモン', 'ko': '잎사귀포켓몬', 'zh-Hant': '葉子寶可夢', 'fr': 'Pokémon Feuille', 'de': 'Laub', 'es': 'Pokémon Hoja', 'it': 'Pokémon Foglia', 'en': 'Leaf Pokémon', 'ja': 'はっぱポケモン', 'zh-Hans': '叶子宝可梦'}}
	public class SpecieBayleef : PokemonSpecie
	{
#nullable enable
		private static SpecieBayleef? _instance = null;
#nullable restore
        public static SpecieBayleef Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBayleef();
                }
                return _instance;
            }
        }

		public SpecieBayleef() : base(
			"Bayleef",
			60, // HPs
			62, 80, // Attack & Defense
			63, 80, // Special Attack & Defense
			60			
		) {}
	}


	//Bayleef Pokemon Class
	public class Bayleef : Pokemon
	{

		public Bayleef(string nickname, int level)
		: base(
				153,
				SpecieBayleef.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bayleef() : base(
			153,
			SpecieBayleef.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}