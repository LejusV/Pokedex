using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Parasect Specie to store common natural stats of every {'abilities': ['effect-spore', 'dry-skin', 'damp'], 'base_experience': 142, 'height': 10, 'id': 47, 'moves': ['scratch', 'swords-dance', 'cut', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'counter', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'string-shot', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'skull-bash', 'leech-life', 'spore', 'flash', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'brick-break', 'knock-off', 'secret-power', 'aromatherapy', 'bullet-seed', 'aerial-ace', 'natural-gift', 'worry-seed', 'seed-bomb', 'x-scissor', 'energy-ball', 'giga-impact', 'cross-poison', 'captivate', 'grass-knot', 'bug-bite', 'hone-claws', 'venoshock', 'rage-powder', 'after-you', 'round', 'struggle-bug', 'confide'], 'name': 'parasect', 'stats': {'hp': 60, 'attack': 95, 'defense': 80, 'special-attack': 60, 'special-defense': 80, 'speed': 30}, 'types': ['bug', 'grass'], 'weight': 295, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug', 'plant'], 'names': {'ja-Hrkt': 'パラセクト', 'roomaji': 'Parasect', 'ko': '파라섹트', 'zh-Hant': '派拉斯特', 'fr': 'Parasect', 'de': 'Parasek', 'es': 'Parasect', 'it': 'Parasect', 'en': 'Parasect', 'ja': 'パラセクト', 'zh-Hans': '派拉斯特'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieParasect : PokemonSpecie
	{
#nullable enable
		private static SpecieParasect? _instance = null;
#nullable restore
        public static SpecieParasect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieParasect();
                }
                return _instance;
            }
        }

		public SpecieParasect() : base(
			"Parasect",
			60, // HPs
			95, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			30			
		) {}
	}


	//Parasect Pokemon Class
	public class Parasect : Pokemon
	{

		public Parasect(string nickname, int level) : base(
			47,
			SpecieParasect.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Grass.Instance			
		) {}

		public Parasect() : base(
			47,
			SpecieParasect.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}