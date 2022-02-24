using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snivy Specie to store common natural stats of every {'abilities': ['overgrow', 'contrary'], 'base_experience': 62, 'height': 6, 'id': 495, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'tackle', 'wrap', 'leer', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'glare', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pursuit', 'sweet-scent', 'iron-tail', 'synthesis', 'hidden-power', 'twister', 'sunny-day', 'mirror-coat', 'torment', 'facade', 'nature-power', 'taunt', 'knock-off', 'snatch', 'secret-power', 'aerial-ace', 'magical-leaf', 'calm-mind', 'leaf-blade', 'natural-gift', 'wring-out', 'gastro-acid', 'worry-seed', 'aqua-tail', 'seed-bomb', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'coil', 'round', 'grass-pledge', 'work-up', 'leaf-tornado', 'grassy-terrain', 'confide'], 'name': 'snivy', 'stats': {'hp': 45, 'attack': 45, 'defense': 55, 'special-attack': 45, 'special-defense': 55, 'speed': 63}, 'types': ['grass'], 'weight': 81, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'ツタージャ', 'ko': '주리비얀', 'zh-Hant': '藤藤蛇', 'fr': 'Vipélierre', 'de': 'Serpifeu', 'es': 'Snivy', 'it': 'Snivy', 'en': 'Snivy', 'ja': 'ツタージャ', 'zh-Hans': '藤藤蛇'}, 'genera': {'ja-Hrkt': 'くさへびポケモン', 'ko': '풀뱀포켓몬', 'zh-Hant': '草蛇寶可夢', 'fr': 'Pokémon Serpenterbe', 'de': 'Grasschlange', 'es': 'Pokémon Serp. Hierba', 'it': 'Pokémon Serperba', 'en': 'Grass Snake Pokémon', 'ja': 'くさへびポケモン', 'zh-Hans': '草蛇宝可梦'}}
	public class SpecieSnivy : PokemonSpecie
	{
#nullable enable
		private static SpecieSnivy? _instance = null;
#nullable restore
        public static SpecieSnivy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnivy();
                }
                return _instance;
            }
        }

		public SpecieSnivy() : base(
			"Snivy",
			45, // HPs
			45, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			63			
		) {}
	}


	//Snivy Pokemon Class
	public class Snivy : Pokemon
	{

		public Snivy(string nickname, int level)
		: base(
				495,
				SpecieSnivy.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Snivy(int level)
		: base(
				495,
				SpecieSnivy.Instance, // Pokemon Specie
				"Snivy", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Snivy() : base(
			495,
			SpecieSnivy.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}