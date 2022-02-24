using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Heracross Specie to store common natural stats of every {'abilities': ['swarm', 'guts', 'moxie'], 'base_experience': 175, 'height': 15, 'id': 214, 'moves': ['swords-dance', 'cut', 'headbutt', 'horn-attack', 'fury-attack', 'tackle', 'body-slam', 'take-down', 'double-edge', 'pin-missile', 'leer', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'bide', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'flail', 'reversal', 'protect', 'detect', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'arm-thrust', 'rock-tomb', 'bullet-seed', 'aerial-ace', 'iron-defense', 'bulk-up', 'rock-blast', 'natural-gift', 'feint', 'close-combat', 'fling', 'night-slash', 'vacuum-wave', 'focus-blast', 'giga-impact', 'shadow-claw', 'stone-edge', 'captivate', 'bug-bite', 'venoshock', 'smack-down', 'round', 'chip-away', 'retaliate', 'struggle-bug', 'bulldoze', 'work-up', 'confide', 'brutal-swing'], 'name': 'heracross', 'stats': {'hp': 80, 'attack': 125, 'defense': 75, 'special-attack': 40, 'special-defense': 95, 'speed': 85}, 'types': ['bug', 'fighting'], 'weight': 540, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['bug'], 'names': {'fr': 'Scarhino', 'ja-Hrkt': 'ヘラクロス', 'roomaji': 'Heracros', 'ko': '헤라크로스', 'zh-Hant': '赫拉克羅斯', 'de': 'Skaraborn', 'es': 'Heracross', 'it': 'Heracross', 'en': 'Heracross', 'ja': 'ヘラクロス', 'zh-Hans': '赫拉克罗斯'}, 'genera': {'fr': 'Pokémon Unicorne', 'ja-Hrkt': '１ぽんヅノポケモン', 'ko': '외뿔포켓몬', 'zh-Hant': '獨角寶可夢', 'de': 'Einzelhorn', 'es': 'Pokémon Unicornio', 'it': 'Pokémon Monocorno', 'en': 'Single Horn Pokémon', 'ja': '１ぽんヅノポケモン', 'zh-Hans': '独角宝可梦'}}
	public class SpecieHeracross : PokemonSpecie
	{
#nullable enable
		private static SpecieHeracross? _instance = null;
#nullable restore
        public static SpecieHeracross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeracross();
                }
                return _instance;
            }
        }

		public SpecieHeracross() : base(
			"Heracross",
			80, // HPs
			125, 75, // Attack & Defense
			40, 95, // Special Attack & Defense
			85			
		) {}
	}


	//Heracross Pokemon Class
	public class Heracross : Pokemon
	{

		public Heracross(string nickname, int level)
		: base(
				214,
				SpecieHeracross.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heracross(int level)
		: base(
				214,
				SpecieHeracross.Instance, // Pokemon Specie
				"Heracross", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heracross() : base(
			214,
			SpecieHeracross.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
	}
}