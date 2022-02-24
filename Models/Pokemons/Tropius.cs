using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tropius Specie to store common natural stats of every {'abilities': ['chlorophyll', 'solar-power', 'harvest'], 'base_experience': 161, 'height': 20, 'id': 357, 'moves': ['razor-wind', 'swords-dance', 'cut', 'gust', 'whirlwind', 'fly', 'slam', 'stomp', 'headbutt', 'body-slam', 'double-edge', 'leer', 'roar', 'hyper-beam', 'strength', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'earthquake', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'outrage', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'twister', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'secret-power', 'air-cutter', 'silver-wind', 'bullet-seed', 'aerial-ace', 'magical-leaf', 'leaf-blade', 'dragon-dance', 'roost', 'natural-gift', 'tailwind', 'worry-seed', 'seed-bomb', 'air-slash', 'dragon-pulse', 'energy-ball', 'giga-impact', 'defog', 'leaf-storm', 'captivate', 'grass-knot', 'ominous-wind', 'round', 'bestow', 'bulldoze', 'leaf-tornado', 'confide', 'dragon-hammer', 'brutal-swing'], 'name': 'tropius', 'stats': {'hp': 99, 'attack': 68, 'defense': 83, 'special-attack': 72, 'special-defense': 87, 'speed': 51}, 'types': ['grass', 'flying'], 'weight': 1000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 200, 'color': 'green', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'トロピウス', 'roomaji': 'Tropius', 'ko': '트로피우스', 'zh-Hant': '熱帶龍', 'fr': 'Tropius', 'de': 'Tropius', 'es': 'Tropius', 'it': 'Tropius', 'en': 'Tropius', 'ja': 'トロピウス', 'zh-Hans': '热带龙'}, 'genera': {'ja-Hrkt': 'フルーツポケモン', 'ko': '후르츠포켓몬', 'zh-Hant': '水果寶可夢', 'fr': 'Pokémon Fruit', 'de': 'Obst', 'es': 'Pokémon Fruto', 'it': 'Pokémon Frutto', 'en': 'Fruit Pokémon', 'ja': 'フルーツポケモン', 'zh-Hans': '水果宝可梦'}}
	public class SpecieTropius : PokemonSpecie
	{
#nullable enable
		private static SpecieTropius? _instance = null;
#nullable restore
        public static SpecieTropius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTropius();
                }
                return _instance;
            }
        }

		public SpecieTropius() : base(
			"Tropius",
			99, // HPs
			68, 83, // Attack & Defense
			72, 87, // Special Attack & Defense
			51			
		) {}
	}


	//Tropius Pokemon Class
	public class Tropius : Pokemon
	{

		public Tropius(string nickname, int level)
		: base(
				357,
				SpecieTropius.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tropius(int level)
		: base(
				357,
				SpecieTropius.Instance, // Pokemon Specie
				"Tropius", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tropius() : base(
			357,
			SpecieTropius.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}