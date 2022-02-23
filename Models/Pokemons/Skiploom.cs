using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skiploom Specie to store common natural stats of every {'abilities': ['chlorophyll', 'leaf-guard', 'infiltrator'], 'base_experience': 119, 'height': 6, 'id': 188, 'moves': ['swords-dance', 'headbutt', 'tackle', 'double-edge', 'tail-whip', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'mimic', 'double-team', 'defense-curl', 'reflect', 'flash', 'splash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'memento', 'facade', 'helping-hand', 'secret-power', 'silver-wind', 'bullet-seed', 'aerial-ace', 'bounce', 'natural-gift', 'u-turn', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'rage-powder', 'round', 'acrobatics', 'fairy-wind', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'skiploom', 'stats': {'hp': 55, 'attack': 45, 'defense': 50, 'special-attack': 45, 'special-defense': 65, 'speed': 80}, 'types': ['grass', 'flying'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'ポポッコ', 'roomaji': 'Popocco', 'ko': '두코', 'zh-Hant': '毽子花', 'fr': 'Floravol', 'de': 'Hubelupf', 'es': 'Skiploom', 'it': 'Skiploom', 'en': 'Skiploom', 'ja': 'ポポッコ', 'zh-Hans': '毽子花'}, 'genera': {'ja-Hrkt': 'わたくさポケモン', 'ko': '솜풀포켓몬', 'zh-Hant': '棉草寶可夢', 'fr': 'Pokémon Pissenlit', 'de': 'Löwenzahn', 'es': 'Pokémon Algadón', 'it': 'Pokémon Gramigna', 'en': 'Cottonweed Pokémon', 'ja': 'わたくさポケモン', 'zh-Hans': '棉草宝可梦'}}
	public class SpecieSkiploom : PokemonSpecie
	{
#nullable enable
		private static SpecieSkiploom? _instance = null;
#nullable restore
        public static SpecieSkiploom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkiploom();
                }
                return _instance;
            }
        }

		public SpecieSkiploom() : base(
			"Skiploom",
			55, // HPs
			45, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
			80			
		) {}
	}


	//Skiploom Pokemon Class
	public class Skiploom : Pokemon
	{

		public Skiploom(string nickname, int level) : base(
			188,
			SpecieSkiploom.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Flying.Instance			
		) {}

		public Skiploom() : base(
			188,
			SpecieSkiploom.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}