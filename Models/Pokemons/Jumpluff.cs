using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jumpluff Specie to store common natural stats of every {'abilities': ['chlorophyll', 'leaf-guard', 'infiltrator'], 'base_experience': 207, 'height': 8, 'id': 189, 'moves': ['swords-dance', 'headbutt', 'tackle', 'double-edge', 'tail-whip', 'hyper-beam', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'mimic', 'double-team', 'defense-curl', 'reflect', 'flash', 'splash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'memento', 'facade', 'helping-hand', 'secret-power', 'silver-wind', 'bullet-seed', 'aerial-ace', 'bounce', 'natural-gift', 'u-turn', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'rage-powder', 'round', 'acrobatics', 'fairy-wind', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'jumpluff', 'stats': {'hp': 75, 'attack': 55, 'defense': 70, 'special-attack': 55, 'special-defense': 95, 'speed': 110}, 'types': ['grass', 'flying'], 'weight': 30, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'ワタッコ', 'roomaji': 'Watacco', 'ko': '솜솜코', 'zh-Hant': '毽子棉', 'fr': 'Cotovol', 'de': 'Papungha', 'es': 'Jumpluff', 'it': 'Jumpluff', 'en': 'Jumpluff', 'ja': 'ワタッコ', 'zh-Hans': '毽子棉'}, 'genera': {'ja-Hrkt': 'わたくさポケモン', 'ko': '솜풀포켓몬', 'zh-Hant': '棉草寶可夢', 'fr': 'Pokémon Pissenlit', 'de': 'Löwenzahn', 'es': 'Pokémon Algadón', 'it': 'Pokémon Gramigna', 'en': 'Cottonweed Pokémon', 'ja': 'わたくさポケモン', 'zh-Hans': '棉草宝可梦'}}
	public class SpecieJumpluff : PokemonSpecie
	{
#nullable enable
		private static SpecieJumpluff? _instance = null;
#nullable restore
        public static SpecieJumpluff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJumpluff();
                }
                return _instance;
            }
        }

		public SpecieJumpluff() : base(
			"Jumpluff",
			75, // HPs
			55, 70, // Attack & Defense
			55, 95, // Special Attack & Defense
			110			
		) {}
	}


	//Jumpluff Pokemon Class
	public class Jumpluff : Pokemon
	{

		public Jumpluff(string nickname, int level) : base(
			189,
			SpecieJumpluff.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Flying.Instance			
		) {}

		public Jumpluff() : base(
			189,
			SpecieJumpluff.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}