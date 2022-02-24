using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shiftry Specie to store common natural stats of every {'abilities': ['chlorophyll', 'early-bird', 'pickpocket'], 'base_experience': 216, 'height': 13, 'id': 275, 'moves': ['pound', 'swords-dance', 'cut', 'whirlwind', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'low-kick', 'strength', 'growth', 'razor-leaf', 'solar-beam', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'swift', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'giga-drain', 'endure', 'rollout', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'twister', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'nature-power', 'brick-break', 'knock-off', 'secret-power', 'air-cutter', 'rock-tomb', 'silver-wind', 'bullet-seed', 'aerial-ace', 'bounce', 'natural-gift', 'tailwind', 'payback', 'embargo', 'fling', 'worry-seed', 'sucker-punch', 'dark-pulse', 'seed-bomb', 'x-scissor', 'focus-blast', 'energy-ball', 'giga-impact', 'nasty-plot', 'defog', 'leaf-storm', 'captivate', 'grass-knot', 'ominous-wind', 'low-sweep', 'foul-play', 'round', 'retaliate', 'leaf-tornado', 'hurricane', 'snarl', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'shiftry', 'stats': {'hp': 90, 'attack': 100, 'defense': 60, 'special-attack': 90, 'special-defense': 60, 'speed': 80}, 'types': ['grass', 'dark'], 'weight': 596, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'ダーテング', 'roomaji': 'Dirteng', 'ko': '다탱구', 'zh-Hant': '狡猾天狗', 'fr': 'Tengalice', 'de': 'Tengulist', 'es': 'Shiftry', 'it': 'Shiftry', 'en': 'Shiftry', 'ja': 'ダーテング', 'zh-Hans': '狡猾天狗'}, 'genera': {'ja-Hrkt': 'よこしまポケモン', 'ko': '부정하기포켓몬', 'zh-Hant': '邪惡寶可夢', 'fr': 'Pokémon Malveillant', 'de': 'Verschlagen', 'es': 'Pokémon Malvado', 'it': 'Pokémon Burbero', 'en': 'Wicked Pokémon', 'ja': 'よこしまポケモン', 'zh-Hans': '邪恶宝可梦'}}
	public class SpecieShiftry : PokemonSpecie
	{
#nullable enable
		private static SpecieShiftry? _instance = null;
#nullable restore
        public static SpecieShiftry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShiftry();
                }
                return _instance;
            }
        }

		public SpecieShiftry() : base(
			"Shiftry",
			90, // HPs
			100, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			80			
		) {}
	}


	//Shiftry Pokemon Class
	public class Shiftry : Pokemon
	{

		public Shiftry(string nickname, int level)
		: base(
				275,
				SpecieShiftry.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shiftry() : base(
			275,
			SpecieShiftry.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
	}
}