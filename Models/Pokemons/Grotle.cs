using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grotle Specie to store common natural stats of every {'abilities': ['overgrow', 'shell-armor'], 'base_experience': 142, 'height': 11, 'id': 388, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'bite', 'strength', 'absorb', 'mega-drain', 'leech-seed', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'withdraw', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'nature-power', 'superpower', 'secret-power', 'bullet-seed', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'earth-power', 'rock-climb', 'leaf-storm', 'captivate', 'stealth-rock', 'grass-knot', 'round', 'grass-pledge', 'work-up', 'confide'], 'name': 'grotle', 'stats': {'hp': 75, 'attack': 89, 'defense': 85, 'special-attack': 55, 'special-defense': 65, 'speed': 36}, 'types': ['grass'], 'weight': 970, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ハヤシガメ', 'roomaji': 'Hayashigame', 'ko': '수풀부기', 'zh-Hant': '樹林龜', 'fr': 'Boskara', 'de': 'Chelcarain', 'es': 'Grotle', 'it': 'Grotle', 'en': 'Grotle', 'ja': 'ハヤシガメ', 'zh-Hans': '树林龟'}, 'genera': {'ja-Hrkt': 'こだちポケモン', 'ko': '나무숲포켓몬', 'zh-Hant': '樹叢寶可夢', 'fr': 'Pokémon Bosquet', 'de': 'Hain', 'es': 'Pokémon Arboleda', 'it': 'Pokémon Boschetto', 'en': 'Grove Pokémon', 'ja': 'こだちポケモン', 'zh-Hans': '树丛宝可梦'}}
	public class SpecieGrotle : PokemonSpecie
	{
#nullable enable
		private static SpecieGrotle? _instance = null;
#nullable restore
        public static SpecieGrotle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrotle();
                }
                return _instance;
            }
        }

		public SpecieGrotle() : base(
			"Grotle",
			75, // HPs
			89, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			36			
		) {}
	}


	//Grotle Pokemon Class
	public class Grotle : Pokemon
	{

		public Grotle(string nickname, int level)
		: base(
				388,
				SpecieGrotle.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grotle() : base(
			388,
			SpecieGrotle.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}