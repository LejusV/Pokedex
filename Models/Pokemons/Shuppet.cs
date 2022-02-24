using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shuppet Specie to store common natural stats of every {'abilities': ['insomnia', 'frisk', 'cursed-body'], 'base_experience': 59, 'height': 6, 'id': 353, 'moves': ['headbutt', 'body-slam', 'double-edge', 'disable', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'night-shade', 'mimic', 'screech', 'double-team', 'confuse-ray', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'foresight', 'destiny-bond', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'role-play', 'magic-coat', 'knock-off', 'skill-swap', 'imprison', 'grudge', 'snatch', 'secret-power', 'astonish', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'embargo', 'sucker-punch', 'dark-pulse', 'shadow-sneak', 'trick-room', 'gunk-shot', 'captivate', 'charge-beam', 'ominous-wind', 'telekinesis', 'magic-room', 'foul-play', 'round', 'hex', 'phantom-force', 'confide', 'dazzling-gleam'], 'name': 'shuppet', 'stats': {'hp': 44, 'attack': 75, 'defense': 35, 'special-attack': 63, 'special-defense': 33, 'speed': 45}, 'types': ['ghost'], 'weight': 23, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 225, 'color': 'black', 'shape': 'ball', 'habitat': 'urban', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'カゲボウズ', 'roomaji': 'Kagebouzu', 'ko': '어둠대신', 'zh-Hant': '怨影娃娃', 'fr': 'Polichombr', 'de': 'Shuppet', 'es': 'Shuppet', 'it': 'Shuppet', 'en': 'Shuppet', 'ja': 'カゲボウズ', 'zh-Hans': '怨影娃娃'}, 'genera': {'ja-Hrkt': 'にんぎょうポケモン', 'ko': '인형포켓몬', 'zh-Hant': '人偶寶可夢', 'fr': 'Pokémon Poupée', 'de': 'Puppe', 'es': 'Pokémon Títere', 'it': 'Pokémon Pupazzo', 'en': 'Puppet Pokémon', 'ja': 'にんぎょうポケモン', 'zh-Hans': '人偶宝可梦'}}
	public class SpecieShuppet : PokemonSpecie
	{
#nullable enable
		private static SpecieShuppet? _instance = null;
#nullable restore
        public static SpecieShuppet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShuppet();
                }
                return _instance;
            }
        }

		public SpecieShuppet() : base(
			"Shuppet",
			44, // HPs
			75, 35, // Attack & Defense
			63, 33, // Special Attack & Defense
			45			
		) {}
	}


	//Shuppet Pokemon Class
	public class Shuppet : Pokemon
	{

		public Shuppet(string nickname, int level)
		: base(
				353,
				SpecieShuppet.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shuppet(int level)
		: base(
				353,
				SpecieShuppet.Instance, // Pokemon Specie
				"Shuppet", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shuppet() : base(
			353,
			SpecieShuppet.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}