using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Xatu Specie to store common natural stats of every {'abilities': ['synchronize', 'early-bird', 'magic-bounce'], 'base_experience': 165, 'height': 15, 'id': 178, 'moves': ['fly', 'double-edge', 'leer', 'hyper-beam', 'peck', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'teleport', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'heat-wave', 'facade', 'trick', 'wish', 'magic-coat', 'skill-swap', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'calm-mind', 'roost', 'miracle-eye', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'psycho-shift', 'lucky-chant', 'me-first', 'power-swap', 'guard-swap', 'sucker-punch', 'air-slash', 'giga-impact', 'zen-headbutt', 'defog', 'trick-room', 'captivate', 'grass-knot', 'ominous-wind', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'stored-power', 'ally-switch', 'confide', 'dazzling-gleam'], 'name': 'xatu', 'stats': {'hp': 65, 'attack': 75, 'defense': 70, 'special-attack': 95, 'special-defense': 70, 'speed': 95}, 'types': ['psychic', 'flying'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ネイティオ', 'roomaji': 'Natio', 'ko': '네이티오', 'zh-Hant': '天然鳥', 'fr': 'Xatu', 'de': 'Xatu', 'es': 'Xatu', 'it': 'Xatu', 'en': 'Xatu', 'ja': 'ネイティオ', 'zh-Hans': '天然鸟'}, 'genera': {'ja-Hrkt': 'せいれいポケモン', 'ko': '정령포켓몬', 'zh-Hant': '神秘寶可夢', 'fr': 'Pokémon Mystique', 'de': 'Mystik', 'es': 'Pokémon Místico', 'it': 'Pokémon Magico', 'en': 'Mystic Pokémon', 'ja': 'せいれいポケモン', 'zh-Hans': '神秘宝可梦'}}
	public class SpecieXatu : PokemonSpecie
	{
#nullable enable
		private static SpecieXatu? _instance = null;
#nullable restore
        public static SpecieXatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXatu();
                }
                return _instance;
            }
        }

		public SpecieXatu() : base(
			"Xatu",
			65, // HPs
			75, 70, // Attack & Defense
			95, 70, // Special Attack & Defense
			95			
		) {}
	}


	//Xatu Pokemon Class
	public class Xatu : Pokemon
	{

		public Xatu(string nickname, int level)
		: base(
				178,
				SpecieXatu.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Xatu() : base(
			178,
			SpecieXatu.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}