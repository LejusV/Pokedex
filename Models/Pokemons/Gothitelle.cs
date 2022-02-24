using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gothitelle Specie to store common natural stats of every {'abilities': ['frisk', 'competitive', 'shadow-tag'], 'base_experience': 221, 'height': 15, 'id': 576, 'moves': ['pound', 'double-slap', 'psybeam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'flatter', 'facade', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'fake-tears', 'rock-tomb', 'tickle', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'payback', 'embargo', 'fling', 'heal-block', 'dark-pulse', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'low-sweep', 'foul-play', 'round', 'play-nice', 'confide', 'power-up-punch'], 'name': 'gothitelle', 'stats': {'hp': 70, 'attack': 55, 'defense': 95, 'special-attack': 95, 'special-defense': 110, 'speed': 65}, 'types': ['psychic'], 'weight': 440, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 50, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ゴチルゼル', 'ko': '고디모아젤', 'zh-Hant': '哥德小姐', 'fr': 'Sidérella', 'de': 'Morbitesse', 'es': 'Gothitelle', 'it': 'Gothitelle', 'en': 'Gothitelle', 'ja': 'ゴチルゼル', 'zh-Hans': '哥德小姐'}, 'genera': {'ja-Hrkt': 'てんたいポケモン', 'ko': '천체포켓몬', 'zh-Hant': '天體寶可夢', 'fr': 'Pokémon Cosmique', 'de': 'Gestirn', 'es': 'Pokémon Astro', 'it': 'Pokémon Corpoceleste', 'en': 'Astral Body Pokémon', 'ja': 'てんたいポケモン', 'zh-Hans': '天体宝可梦'}}
	public class SpecieGothitelle : PokemonSpecie
	{
#nullable enable
		private static SpecieGothitelle? _instance = null;
#nullable restore
        public static SpecieGothitelle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothitelle();
                }
                return _instance;
            }
        }

		public SpecieGothitelle() : base(
			"Gothitelle",
			70, // HPs
			55, 95, // Attack & Defense
			95, 110, // Special Attack & Defense
			65			
		) {}
	}


	//Gothitelle Pokemon Class
	public class Gothitelle : Pokemon
	{

		public Gothitelle(string nickname, int level)
		: base(
				576,
				SpecieGothitelle.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gothitelle() : base(
			576,
			SpecieGothitelle.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}