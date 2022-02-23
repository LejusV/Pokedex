using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tangrowth Specie to store common natural stats of every {'abilities': ['chlorophyll', 'leaf-guard', 'regenerator'], 'base_experience': 187, 'height': 20, 'id': 465, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'headbutt', 'hyper-beam', 'strength', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'earthquake', 'toxic', 'double-team', 'reflect', 'constrict', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'nature-power', 'ingrain', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'tickle', 'bullet-seed', 'aerial-ace', 'block', 'shock-wave', 'natural-gift', 'payback', 'fling', 'wring-out', 'worry-seed', 'poison-jab', 'seed-bomb', 'focus-blast', 'energy-ball', 'giga-impact', 'power-whip', 'captivate', 'grass-knot', 'round', 'bulldoze', 'grassy-terrain', 'confide', 'infestation'], 'name': 'tangrowth', 'stats': {'hp': 100, 'attack': 100, 'defense': 125, 'special-attack': 110, 'special-defense': 50, 'speed': 50}, 'types': ['grass'], 'weight': 1286, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'モジャンボ', 'roomaji': 'Mojumbo', 'ko': '덩쿠림보', 'zh-Hant': '巨蔓藤', 'fr': 'Bouldeneu', 'de': 'Tangoloss', 'es': 'Tangrowth', 'it': 'Tangrowth', 'en': 'Tangrowth', 'ja': 'モジャンボ', 'zh-Hans': '巨蔓藤'}, 'genera': {'ja-Hrkt': 'ツルじょうポケモン', 'ko': '넝쿨포켓몬', 'zh-Hant': '藤蔓狀寶可夢', 'fr': 'Pokémon Vigne', 'de': 'Ranke', 'es': 'Pokémon Enredadera', 'it': 'Pokémon Liana', 'en': 'Vine Pokémon', 'ja': 'ツルじょうポケモン', 'zh-Hans': '藤蔓状宝可梦'}}
	public class SpecieTangrowth : PokemonSpecie
	{
#nullable enable
		private static SpecieTangrowth? _instance = null;
#nullable restore
        public static SpecieTangrowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTangrowth();
                }
                return _instance;
            }
        }

		public SpecieTangrowth() : base(
			"Tangrowth",
			100, // HPs
			100, 125, // Attack & Defense
			110, 50, // Special Attack & Defense
			50			
		) {}
	}


	//Tangrowth Pokemon Class
	public class Tangrowth : Pokemon
	{

		public Tangrowth(string nickname, int level) : base(
			465,
			SpecieTangrowth.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Tangrowth() : base(
			465,
			SpecieTangrowth.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}