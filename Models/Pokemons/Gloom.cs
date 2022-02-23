using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gloom Specie to store common natural stats of every {'abilities': ['chlorophyll', 'stench'], 'base_experience': 138, 'height': 8, 'id': 44, 'moves': ['swords-dance', 'cut', 'take-down', 'double-edge', 'acid', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'petal-dance', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'moonlight', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'secret-power', 'bullet-seed', 'natural-gift', 'fling', 'gastro-acid', 'lucky-chant', 'worry-seed', 'seed-bomb', 'drain-punch', 'energy-ball', 'captivate', 'grass-knot', 'venoshock', 'after-you', 'round', 'petal-blizzard', 'grassy-terrain', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'gloom', 'stats': {'hp': 60, 'attack': 65, 'defense': 70, 'special-attack': 85, 'special-defense': 75, 'speed': 40}, 'types': ['grass', 'poison'], 'weight': 86, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'クサイハナ', 'roomaji': 'Kusaihana', 'ko': '냄새꼬', 'zh-Hant': '臭臭花', 'fr': 'Ortide', 'de': 'Duflor', 'es': 'Gloom', 'it': 'Gloom', 'en': 'Gloom', 'ja': 'クサイハナ', 'zh-Hans': '臭臭花'}, 'genera': {'ja-Hrkt': 'ざっそうポケモン', 'ko': '잡초포켓몬', 'zh-Hant': '雜草寶可夢', 'fr': 'Pokémon Racine', 'de': 'Unkraut', 'es': 'Pokémon Hierbajo', 'it': 'Pokémon Malerba', 'en': 'Weed Pokémon', 'ja': 'ざっそうポケモン', 'zh-Hans': '杂草宝可梦'}}
	public class SpecieGloom : PokemonSpecie
	{
#nullable enable
		private static SpecieGloom? _instance = null;
#nullable restore
        public static SpecieGloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGloom();
                }
                return _instance;
            }
        }

		public SpecieGloom() : base(
			"Gloom",
			60, // HPs
			65, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
			40			
		) {}
	}


	//Gloom Pokemon Class
	public class Gloom : Pokemon
	{

		public Gloom(string nickname, int level) : base(
			44,
			SpecieGloom.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Gloom() : base(
			44,
			SpecieGloom.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}