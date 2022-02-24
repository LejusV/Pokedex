using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vileplume Specie to store common natural stats of every {'abilities': ['chlorophyll', 'effect-spore'], 'base_experience': 221, 'height': 12, 'id': 45, 'moves': ['swords-dance', 'cut', 'body-slam', 'take-down', 'double-edge', 'acid', 'hyper-beam', 'absorb', 'mega-drain', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'petal-dance', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'secret-power', 'aromatherapy', 'bullet-seed', 'natural-gift', 'fling', 'gastro-acid', 'worry-seed', 'seed-bomb', 'drain-punch', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'venoshock', 'after-you', 'round', 'petal-blizzard', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'vileplume', 'stats': {'hp': 75, 'attack': 80, 'defense': 85, 'special-attack': 110, 'special-defense': 90, 'speed': 50}, 'types': ['grass', 'poison'], 'weight': 186, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ラフレシア', 'roomaji': 'Ruffresia', 'ko': '라플레시아', 'zh-Hant': '霸王花', 'fr': 'Rafflesia', 'de': 'Giflor', 'es': 'Vileplume', 'it': 'Vileplume', 'en': 'Vileplume', 'ja': 'ラフレシア', 'zh-Hans': '霸王花'}, 'genera': {'ja-Hrkt': 'フラワーポケモン', 'ko': '꽃포켓몬', 'zh-Hant': '花寶可夢', 'fr': 'Pokémon Fleur', 'de': 'Blume', 'es': 'Pokémon Flor', 'it': 'Pokémon Fiore', 'en': 'Flower Pokémon', 'ja': 'フラワーポケモン', 'zh-Hans': '花宝可梦'}}
	public class SpecieVileplume : PokemonSpecie
	{
#nullable enable
		private static SpecieVileplume? _instance = null;
#nullable restore
        public static SpecieVileplume Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVileplume();
                }
                return _instance;
            }
        }

		public SpecieVileplume() : base(
			"Vileplume",
			75, // HPs
			80, 85, // Attack & Defense
			110, 90, // Special Attack & Defense
			50			
		) {}
	}


	//Vileplume Pokemon Class
	public class Vileplume : Pokemon
	{

		public Vileplume(string nickname, int level)
		: base(
				45,
				SpecieVileplume.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vileplume(int level)
		: base(
				45,
				SpecieVileplume.Instance, // Pokemon Specie
				"Vileplume", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vileplume() : base(
			45,
			SpecieVileplume.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}