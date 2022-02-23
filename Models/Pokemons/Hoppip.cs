using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hoppip Specie to store common natural stats of every {'abilities': ['chlorophyll', 'leaf-guard', 'infiltrator'], 'base_experience': 50, 'height': 4, 'id': 187, 'moves': ['pay-day', 'swords-dance', 'headbutt', 'tackle', 'double-edge', 'tail-whip', 'growl', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'confusion', 'mimic', 'double-team', 'defense-curl', 'reflect', 'amnesia', 'flash', 'splash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'memento', 'facade', 'helping-hand', 'secret-power', 'aromatherapy', 'silver-wind', 'bullet-seed', 'aerial-ace', 'bounce', 'natural-gift', 'u-turn', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'rage-powder', 'round', 'acrobatics', 'cotton-guard', 'grassy-terrain', 'fairy-wind', 'confide', 'dazzling-gleam', 'infestation', 'strength-sap'], 'name': 'hoppip', 'stats': {'hp': 35, 'attack': 35, 'defense': 40, 'special-attack': 35, 'special-defense': 55, 'speed': 50}, 'types': ['grass', 'flying'], 'weight': 5, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'pink', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'ハネッコ', 'roomaji': 'Hanecco', 'ko': '통통코', 'zh-Hant': '毽子草', 'fr': 'Granivol', 'de': 'Hoppspross', 'es': 'Hoppip', 'it': 'Hoppip', 'en': 'Hoppip', 'ja': 'ハネッコ', 'zh-Hans': '毽子草'}, 'genera': {'ja-Hrkt': 'わたくさポケモン', 'ko': '솜풀포켓몬', 'zh-Hant': '棉草寶可夢', 'fr': 'Pokémon Pissenlit', 'de': 'Löwenzahn', 'es': 'Pokémon Algadón', 'it': 'Pokémon Gramigna', 'en': 'Cottonweed Pokémon', 'ja': 'わたくさポケモン', 'zh-Hans': '棉草宝可梦'}}
	public class SpecieHoppip : PokemonSpecie
	{
#nullable enable
		private static SpecieHoppip? _instance = null;
#nullable restore
        public static SpecieHoppip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoppip();
                }
                return _instance;
            }
        }

		public SpecieHoppip() : base(
			"Hoppip",
			35, // HPs
			35, 40, // Attack & Defense
			35, 55, // Special Attack & Defense
			50			
		) {}
	}


	//Hoppip Pokemon Class
	public class Hoppip : Pokemon
	{

		public Hoppip(string nickname, int level) : base(
			187,
			SpecieHoppip.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Flying.Instance			
		) {}

		public Hoppip() : base(
			187,
			SpecieHoppip.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}