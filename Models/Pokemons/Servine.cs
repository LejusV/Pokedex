using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Servine Specie to store common natural stats of every {'abilities': ['overgrow', 'contrary'], 'base_experience': 145, 'height': 8, 'id': 496, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'tackle', 'wrap', 'leer', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'torment', 'facade', 'nature-power', 'taunt', 'knock-off', 'snatch', 'secret-power', 'aerial-ace', 'calm-mind', 'leaf-blade', 'wring-out', 'gastro-acid', 'worry-seed', 'aqua-tail', 'seed-bomb', 'energy-ball', 'leaf-storm', 'grass-knot', 'coil', 'round', 'grass-pledge', 'work-up', 'leaf-tornado', 'confide'], 'name': 'servine', 'stats': {'hp': 60, 'attack': 60, 'defense': 75, 'special-attack': 60, 'special-defense': 75, 'speed': 83}, 'types': ['grass'], 'weight': 160, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'ジャノビー', 'ko': '샤비', 'zh-Hant': '青藤蛇', 'fr': 'Lianaja', 'de': 'Efoserp', 'es': 'Servine', 'it': 'Servine', 'en': 'Servine', 'ja': 'ジャノビー', 'zh-Hans': '青藤蛇'}, 'genera': {'ja-Hrkt': 'くさへびポケモン', 'ko': '풀뱀포켓몬', 'zh-Hant': '草蛇寶可夢', 'fr': 'Pokémon Serpenterbe', 'de': 'Grasschlange', 'es': 'Pokémon Serp. Hierba', 'it': 'Pokémon Serperba', 'en': 'Grass Snake Pokémon', 'ja': 'くさへびポケモン', 'zh-Hans': '草蛇宝可梦'}}
	public class SpecieServine : PokemonSpecie
	{
#nullable enable
		private static SpecieServine? _instance = null;
#nullable restore
        public static SpecieServine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieServine();
                }
                return _instance;
            }
        }

		public SpecieServine() : base(
			"Servine",
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			83			
		) {}
	}


	//Servine Pokemon Class
	public class Servine : Pokemon
	{

		public Servine(string nickname, int level) : base(
			496,
			SpecieServine.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Servine() : base(
			496,
			SpecieServine.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}