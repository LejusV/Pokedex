using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tangela Specie to store common natural stats of every {'abilities': ['chlorophyll', 'leaf-guard', 'regenerator'], 'base_experience': 87, 'height': 10, 'id': 114, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'confusion', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'skull-bash', 'constrict', 'amnesia', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'nature-power', 'ingrain', 'knock-off', 'endeavor', 'secret-power', 'tickle', 'bullet-seed', 'shock-wave', 'wake-up-slap', 'natural-gift', 'wring-out', 'power-swap', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'leaf-storm', 'power-whip', 'captivate', 'grass-knot', 'rage-powder', 'round', 'grassy-terrain', 'confide', 'infestation'], 'name': 'tangela', 'stats': {'hp': 65, 'attack': 55, 'defense': 115, 'special-attack': 100, 'special-defense': 40, 'speed': 60}, 'types': ['grass'], 'weight': 350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'legs', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'モンジャラ', 'roomaji': 'Monjara', 'ko': '덩쿠리', 'zh-Hant': '蔓藤怪', 'fr': 'Saquedeneu', 'de': 'Tangela', 'es': 'Tangela', 'it': 'Tangela', 'en': 'Tangela', 'ja': 'モンジャラ', 'zh-Hans': '蔓藤怪'}, 'genera': {'ja-Hrkt': 'ツルじょうポケモン', 'ko': '넝쿨포켓몬', 'zh-Hant': '藤蔓狀寶可夢', 'fr': 'Pokémon Vigne', 'de': 'Ranke', 'es': 'Pokémon Enredadera', 'it': 'Pokémon Liana', 'en': 'Vine Pokémon', 'ja': 'ツルじょうポケモン', 'zh-Hans': '藤蔓状宝可梦'}}
	public class SpecieTangela : PokemonSpecie
	{
#nullable enable
		private static SpecieTangela? _instance = null;
#nullable restore
        public static SpecieTangela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTangela();
                }
                return _instance;
            }
        }

		public SpecieTangela() : base(
			"Tangela",
			65, // HPs
			55, 115, // Attack & Defense
			100, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Tangela Pokemon Class
	public class Tangela : Pokemon
	{

		public Tangela(string nickname, int level)
		: base(
				114,
				SpecieTangela.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tangela(int level)
		: base(
				114,
				SpecieTangela.Instance, // Pokemon Specie
				"Tangela", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tangela() : base(
			114,
			SpecieTangela.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}