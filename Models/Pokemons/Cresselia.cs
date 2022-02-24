using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cresselia Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 270, 'height': 15, 'id': 488, 'moves': ['mist', 'ice-beam', 'aurora-beam', 'hyper-beam', 'solar-beam', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'signal-beam', 'calm-mind', 'gravity', 'natural-gift', 'psycho-shift', 'energy-ball', 'giga-impact', 'psycho-cut', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'lunar-dance', 'psyshock', 'telekinesis', 'magic-room', 'round', 'moonblast', 'confide'], 'name': 'cresselia', 'stats': {'hp': 120, 'attack': 70, 'defense': 120, 'special-attack': 75, 'special-defense': 130, 'speed': 85}, 'types': ['psychic'], 'weight': 856, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 8, 'capture_rate': 3, 'color': 'yellow', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'クレセリア', 'roomaji': 'Crecelia', 'ko': '크레세리아', 'zh-Hant': '克雷色利亞', 'fr': 'Cresselia', 'de': 'Cresselia', 'es': 'Cresselia', 'it': 'Cresselia', 'en': 'Cresselia', 'ja': 'クレセリア', 'zh-Hans': '克雷色利亚'}, 'genera': {'ja-Hrkt': 'みかづきポケモン', 'ko': '초승달포켓몬', 'zh-Hant': '新月寶可夢', 'fr': 'Pokémon Lunaire', 'de': 'Lunar', 'es': 'Pokémon Lunar', 'it': 'Pokémon Falcato', 'en': 'Lunar Pokémon', 'ja': 'みかづきポケモン', 'zh-Hans': '新月宝可梦'}}
	public class SpecieCresselia : PokemonSpecie
	{
#nullable enable
		private static SpecieCresselia? _instance = null;
#nullable restore
        public static SpecieCresselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCresselia();
                }
                return _instance;
            }
        }

		public SpecieCresselia() : base(
			"Cresselia",
			120, // HPs
			70, 120, // Attack & Defense
			75, 130, // Special Attack & Defense
			85			
		) {}
	}


	//Cresselia Pokemon Class
	public class Cresselia : Pokemon
	{

		public Cresselia(string nickname, int level)
		: base(
				488,
				SpecieCresselia.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cresselia() : base(
			488,
			SpecieCresselia.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}