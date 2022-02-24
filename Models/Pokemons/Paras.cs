using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Paras Specie to store common natural stats of every {'abilities': ['effect-spore', 'dry-skin', 'damp'], 'base_experience': 57, 'height': 3, 'id': 46, 'moves': ['scratch', 'swords-dance', 'cut', 'body-slam', 'take-down', 'double-edge', 'psybeam', 'counter', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'string-shot', 'dig', 'toxic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'skull-bash', 'leech-life', 'spore', 'flash', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'sweet-scent', 'metal-claw', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'brick-break', 'knock-off', 'secret-power', 'aromatherapy', 'bullet-seed', 'aerial-ace', 'natural-gift', 'worry-seed', 'seed-bomb', 'x-scissor', 'energy-ball', 'cross-poison', 'captivate', 'grass-knot', 'bug-bite', 'hone-claws', 'wide-guard', 'venoshock', 'rage-powder', 'after-you', 'round', 'struggle-bug', 'rototiller', 'fell-stinger', 'grassy-terrain', 'confide'], 'name': 'paras', 'stats': {'hp': 35, 'attack': 70, 'defense': 55, 'special-attack': 45, 'special-defense': 55, 'speed': 25}, 'types': ['bug', 'grass'], 'weight': 54, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'red', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug', 'plant'], 'names': {'ja-Hrkt': 'パラス', 'roomaji': 'Paras', 'ko': '파라스', 'zh-Hant': '派拉斯', 'fr': 'Paras', 'de': 'Paras', 'es': 'Paras', 'it': 'Paras', 'en': 'Paras', 'ja': 'パラス', 'zh-Hans': '派拉斯'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieParas : PokemonSpecie
	{
#nullable enable
		private static SpecieParas? _instance = null;
#nullable restore
        public static SpecieParas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieParas();
                }
                return _instance;
            }
        }

		public SpecieParas() : base(
			"Paras",
			35, // HPs
			70, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			25			
		) {}
	}


	//Paras Pokemon Class
	public class Paras : Pokemon
	{

		public Paras(string nickname, int level)
		: base(
				46,
				SpecieParas.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Paras() : base(
			46,
			SpecieParas.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}