using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Natu Specie to store common natural stats of every {'abilities': ['synchronize', 'early-bird', 'magic-bounce'], 'base_experience': 64, 'height': 2, 'id': 177, 'moves': ['double-edge', 'leer', 'peck', 'drill-peck', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'quick-attack', 'teleport', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'haze', 'reflect', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'feint-attack', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'heat-wave', 'facade', 'trick', 'wish', 'magic-coat', 'skill-swap', 'refresh', 'secret-power', 'feather-dance', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'calm-mind', 'roost', 'miracle-eye', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'psycho-shift', 'lucky-chant', 'me-first', 'power-swap', 'guard-swap', 'sucker-punch', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'ominous-wind', 'psyshock', 'telekinesis', 'magic-room', 'synchronoise', 'simple-beam', 'round', 'stored-power', 'ally-switch', 'confide', 'dazzling-gleam'], 'name': 'natu', 'stats': {'hp': 40, 'attack': 50, 'defense': 45, 'special-attack': 70, 'special-defense': 45, 'speed': 70}, 'types': ['psychic', 'flying'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'green', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ネイティ', 'roomaji': 'Naty', 'ko': '네이티', 'zh-Hant': '天然雀', 'fr': 'Natu', 'de': 'Natu', 'es': 'Natu', 'it': 'Natu', 'en': 'Natu', 'ja': 'ネイティ', 'zh-Hans': '天然雀'}, 'genera': {'ja-Hrkt': 'ことりポケモン', 'ko': '아기새포켓몬', 'zh-Hant': '小鳥寶可夢', 'fr': 'Pokémon Minoiseau', 'de': 'Kleinvogel', 'es': 'Pokémon Pajarito', 'it': 'Pokémon Uccellino', 'en': 'Tiny Bird Pokémon', 'ja': 'ことりポケモン', 'zh-Hans': '小鸟宝可梦'}}
	public class SpecieNatu : PokemonSpecie
	{
#nullable enable
		private static SpecieNatu? _instance = null;
#nullable restore
        public static SpecieNatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNatu();
                }
                return _instance;
            }
        }

		public SpecieNatu() : base(
			"Natu",
			40, // HPs
			50, 45, // Attack & Defense
			70, 45, // Special Attack & Defense
			70			
		) {}
	}


	//Natu Pokemon Class
	public class Natu : Pokemon
	{

		public Natu(string nickname, int level)
		: base(
				177,
				SpecieNatu.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Natu() : base(
			177,
			SpecieNatu.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}