using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chimecho Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 159, 'height': 6, 'id': 358, 'moves': ['bind', 'wrap', 'take-down', 'double-edge', 'growl', 'disable', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'mimic', 'double-team', 'recover', 'defense-curl', 'light-screen', 'reflect', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'perish-song', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'facade', 'taunt', 'helping-hand', 'trick', 'wish', 'magic-coat', 'recycle', 'yawn', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'hyper-voice', 'astonish', 'cosmic-power', 'signal-beam', 'extrasensory', 'calm-mind', 'shock-wave', 'gravity', 'healing-wish', 'natural-gift', 'last-resort', 'energy-ball', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'synchronoise', 'round', 'echoed-voice', 'stored-power', 'heal-pulse', 'crafty-shield', 'confide', 'dazzling-gleam'], 'name': 'chimecho', 'stats': {'hp': 75, 'attack': 50, 'defense': 80, 'special-attack': 95, 'special-defense': 90, 'speed': 65}, 'types': ['psychic'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'arms', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'チリーン', 'roomaji': 'Chirean', 'ko': '치렁', 'zh-Hant': '風鈴鈴', 'fr': 'Éoko', 'de': 'Palimpalim', 'es': 'Chimecho', 'it': 'Chimecho', 'en': 'Chimecho', 'ja': 'チリーン', 'zh-Hans': '风铃铃'}, 'genera': {'ja-Hrkt': 'ふうりんポケモン', 'ko': '풍경포켓몬', 'zh-Hant': '風鈴寶可夢', 'fr': 'Pokémon Carillon', 'de': 'Windspiel', 'es': 'Pokémon Sonido Aire', 'it': 'Pokémon Vencampana', 'en': 'Wind Chime Pokémon', 'ja': 'ふうりんポケモン', 'zh-Hans': '风铃宝可梦'}}
	public class SpecieChimecho : PokemonSpecie
	{
#nullable enable
		private static SpecieChimecho? _instance = null;
#nullable restore
        public static SpecieChimecho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChimecho();
                }
                return _instance;
            }
        }

		public SpecieChimecho() : base(
			"Chimecho",
			75, // HPs
			50, 80, // Attack & Defense
			95, 90, // Special Attack & Defense
			65			
		) {}
	}


	//Chimecho Pokemon Class
	public class Chimecho : Pokemon
	{

		public Chimecho(string nickname, int level)
		: base(
				358,
				SpecieChimecho.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chimecho(int level)
		: base(
				358,
				SpecieChimecho.Instance, // Pokemon Specie
				"Chimecho", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chimecho() : base(
			358,
			SpecieChimecho.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}