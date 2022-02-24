using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Girafarig Specie to store common natural stats of every {'abilities': ['inner-focus', 'early-bird', 'sap-sipper'], 'base_experience': 159, 'height': 15, 'id': 203, 'moves': ['razor-wind', 'stomp', 'double-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'psybeam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'confusion', 'psychic', 'agility', 'mimic', 'double-team', 'light-screen', 'reflect', 'swift', 'amnesia', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'foresight', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'mirror-coat', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'beat-up', 'uproar', 'facade', 'trick', 'wish', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'hyper-voice', 'astonish', 'odor-sleuth', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'natural-gift', 'assurance', 'power-swap', 'guard-swap', 'sucker-punch', 'energy-ball', 'nasty-plot', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'double-hit', 'psyshock', 'telekinesis', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'bulldoze', 'work-up', 'confide', 'dazzling-gleam', 'psychic-terrain', 'psychic-fangs'], 'name': 'girafarig', 'stats': {'hp': 70, 'attack': 80, 'defense': 65, 'special-attack': 90, 'special-defense': 65, 'speed': 85}, 'types': ['normal', 'psychic'], 'weight': 415, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'キリンリキ', 'roomaji': 'Kirinriki', 'ko': '키링키', 'zh-Hant': '麒麟奇', 'fr': 'Girafarig', 'de': 'Girafarig', 'es': 'Girafarig', 'it': 'Girafarig', 'en': 'Girafarig', 'ja': 'キリンリキ', 'zh-Hans': '麒麟奇'}, 'genera': {'ja-Hrkt': 'くびながポケモン', 'ko': '긴목포켓몬', 'zh-Hant': '長頸寶可夢', 'fr': 'Pokémon Long-Cou', 'de': 'Langhals', 'es': 'Pokémon Gran Cuello', 'it': 'Pokémon Lungocollo', 'en': 'Long Neck Pokémon', 'ja': 'くびながポケモン', 'zh-Hans': '长颈宝可梦'}}
	public class SpecieGirafarig : PokemonSpecie
	{
#nullable enable
		private static SpecieGirafarig? _instance = null;
#nullable restore
        public static SpecieGirafarig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGirafarig();
                }
                return _instance;
            }
        }

		public SpecieGirafarig() : base(
			"Girafarig",
			70, // HPs
			80, 65, // Attack & Defense
			90, 65, // Special Attack & Defense
			85			
		) {}
	}


	//Girafarig Pokemon Class
	public class Girafarig : Pokemon
	{

		public Girafarig(string nickname, int level)
		: base(
				203,
				SpecieGirafarig.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Girafarig(int level)
		: base(
				203,
				SpecieGirafarig.Instance, // Pokemon Specie
				"Girafarig", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Girafarig() : base(
			203,
			SpecieGirafarig.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
	}
}