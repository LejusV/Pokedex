using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cottonee Specie to store common natural stats of every {'abilities': ['prankster', 'infiltrator', 'chlorophyll'], 'base_experience': 56, 'height': 3, 'id': 546, 'moves': ['absorb', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'stun-spore', 'toxic', 'double-team', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'cotton-spore', 'protect', 'giga-drain', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'hidden-power', 'sunny-day', 'beat-up', 'memento', 'facade', 'nature-power', 'taunt', 'helping-hand', 'knock-off', 'endeavor', 'secret-power', 'fake-tears', 'grass-whistle', 'tickle', 'covet', 'natural-gift', 'tailwind', 'worry-seed', 'seed-bomb', 'energy-ball', 'switcheroo', 'captivate', 'grass-knot', 'round', 'cotton-guard', 'misty-terrain', 'fairy-wind', 'confide', 'dazzling-gleam'], 'name': 'cottonee', 'stats': {'hp': 40, 'attack': 27, 'defense': 60, 'special-attack': 37, 'special-defense': 50, 'speed': 66}, 'types': ['grass', 'fairy'], 'weight': 6, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'green', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'モンメン', 'ko': '소미안', 'zh-Hant': '木棉球', 'fr': 'Doudouvet', 'de': 'Waumboll', 'es': 'Cottonee', 'it': 'Cottonee', 'en': 'Cottonee', 'ja': 'モンメン', 'zh-Hans': '木棉球'}, 'genera': {'ja-Hrkt': 'わたたまポケモン', 'ko': '솜뭉치포켓몬', 'zh-Hant': '棉球寶可夢', 'fr': 'Pokémon Boule Coton', 'de': 'Wattebausch', 'es': 'Pokémon Bolalgodón', 'it': 'Pokémon Cotonpalla', 'en': 'Cotton Puff Pokémon', 'ja': 'わたたまポケモン', 'zh-Hans': '棉球宝可梦'}}
	public class SpecieCottonee : PokemonSpecie
	{
#nullable enable
		private static SpecieCottonee? _instance = null;
#nullable restore
        public static SpecieCottonee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCottonee();
                }
                return _instance;
            }
        }

		public SpecieCottonee() : base(
			"Cottonee",
			40, // HPs
			27, 60, // Attack & Defense
			37, 50, // Special Attack & Defense
			66			
		) {}
	}


	//Cottonee Pokemon Class
	public class Cottonee : Pokemon
	{

		public Cottonee(string nickname, int level) : base(
			546,
			SpecieCottonee.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Fairy.Instance			
		) {}

		public Cottonee() : base(
			546,
			SpecieCottonee.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
	}
}