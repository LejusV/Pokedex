using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shroomish Specie to store common natural stats of every {'abilities': ['effect-spore', 'poison-heal', 'quick-feet'], 'base_experience': 59, 'height': 4, 'id': 285, 'moves': ['swords-dance', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'toxic', 'mimic', 'double-team', 'spore', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'charm', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'focus-punch', 'helping-hand', 'snatch', 'secret-power', 'fake-tears', 'bullet-seed', 'wake-up-slap', 'natural-gift', 'worry-seed', 'seed-bomb', 'drain-punch', 'energy-ball', 'captivate', 'grass-knot', 'venoshock', 'round', 'confide'], 'name': 'shroomish', 'stats': {'hp': 60, 'attack': 40, 'defense': 60, 'special-attack': 40, 'special-defense': 60, 'speed': 35}, 'types': ['grass'], 'weight': 45, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'legs', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'キノココ', 'roomaji': 'Kinococo', 'ko': '버섯꼬', 'zh-Hant': '蘑蘑菇', 'fr': 'Balignon', 'de': 'Knilz', 'es': 'Shroomish', 'it': 'Shroomish', 'en': 'Shroomish', 'ja': 'キノココ', 'zh-Hans': '蘑蘑菇'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieShroomish : PokemonSpecie
	{
#nullable enable
		private static SpecieShroomish? _instance = null;
#nullable restore
        public static SpecieShroomish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShroomish();
                }
                return _instance;
            }
        }

		public SpecieShroomish() : base(
			"Shroomish",
			60, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			35			
		) {}
	}


	//Shroomish Pokemon Class
	public class Shroomish : Pokemon
	{

		public Shroomish(string nickname, int level)
		: base(
				285,
				SpecieShroomish.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shroomish(int level)
		: base(
				285,
				SpecieShroomish.Instance, // Pokemon Specie
				"Shroomish", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shroomish() : base(
			285,
			SpecieShroomish.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}