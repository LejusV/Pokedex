using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scizor Specie to store common natural stats of every {'abilities': ['swarm', 'technician', 'light-metal'], 'base_experience': 175, 'height': 18, 'id': 212, 'moves': ['razor-wind', 'swords-dance', 'cut', 'headbutt', 'double-edge', 'leer', 'hyper-beam', 'counter', 'strength', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'light-screen', 'focus-energy', 'swift', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'detect', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pursuit', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'silver-wind', 'aerial-ace', 'iron-defense', 'roost', 'natural-gift', 'feint', 'tailwind', 'u-turn', 'fling', 'night-slash', 'x-scissor', 'giga-impact', 'bullet-punch', 'flash-cannon', 'defog', 'iron-head', 'captivate', 'bug-bite', 'double-hit', 'ominous-wind', 'venoshock', 'round', 'acrobatics', 'struggle-bug', 'confide', 'brutal-swing'], 'name': 'scizor', 'stats': {'hp': 70, 'attack': 130, 'defense': 100, 'special-attack': 55, 'special-defense': 80, 'speed': 65}, 'types': ['bug', 'steel'], 'weight': 1180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 25, 'color': 'red', 'shape': 'bug-wings', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ハッサム', 'roomaji': 'Hassam', 'ko': '핫삼', 'zh-Hant': '巨鉗螳螂', 'fr': 'Cizayox', 'de': 'Scherox', 'es': 'Scizor', 'it': 'Scizor', 'en': 'Scizor', 'ja': 'ハッサム', 'zh-Hans': '巨钳螳螂'}, 'genera': {'ja-Hrkt': 'はさみポケモン', 'ko': '집게포켓몬', 'zh-Hant': '鉗子寶可夢', 'fr': 'Pokémon Pince', 'de': 'Kneifer', 'es': 'Pokémon Tenaza', 'it': 'Pokémon Chela', 'en': 'Pincer Pokémon', 'ja': 'はさみポケモン', 'zh-Hans': '钳子宝可梦'}}
	public class SpecieScizor : PokemonSpecie
	{
#nullable enable
		private static SpecieScizor? _instance = null;
#nullable restore
        public static SpecieScizor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScizor();
                }
                return _instance;
            }
        }

		public SpecieScizor() : base(
			"Scizor",
			70, // HPs
			130, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
			65			
		) {}
	}


	//Scizor Pokemon Class
	public class Scizor : Pokemon
	{

		public Scizor(string nickname, int level)
		: base(
				212,
				SpecieScizor.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scizor(int level)
		: base(
				212,
				SpecieScizor.Instance, // Pokemon Specie
				"Scizor", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scizor() : base(
			212,
			SpecieScizor.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
	}
}