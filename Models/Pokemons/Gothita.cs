using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gothita Specie to store common natural stats of every {'abilities': ['frisk', 'competitive', 'shadow-tag'], 'base_experience': 58, 'height': 4, 'id': 574, 'moves': ['pound', 'double-slap', 'psybeam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'charm', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'mirror-coat', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'flatter', 'facade', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'snatch', 'secret-power', 'fake-tears', 'rock-tomb', 'tickle', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'payback', 'embargo', 'fling', 'heal-block', 'dark-pulse', 'energy-ball', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'heal-pulse', 'play-nice', 'confide'], 'name': 'gothita', 'stats': {'hp': 45, 'attack': 30, 'defense': 50, 'special-attack': 55, 'special-defense': 65, 'speed': 45}, 'types': ['psychic'], 'weight': 58, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 200, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ゴチム', 'ko': '고디탱', 'zh-Hant': '哥德寶寶', 'fr': 'Scrutella', 'de': 'Mollimorba', 'es': 'Gothita', 'it': 'Gothita', 'en': 'Gothita', 'ja': 'ゴチム', 'zh-Hans': '哥德宝宝'}, 'genera': {'ja-Hrkt': 'ぎょうしポケモン', 'ko': '응시포켓몬', 'zh-Hant': '凝視寶可夢', 'fr': 'Pokémon Dévisageur', 'de': 'Glotz', 'es': 'Pokémon Inquisitivo', 'it': 'Pokémon Fissosguardo', 'en': 'Fixation Pokémon', 'ja': 'ぎょうしポケモン', 'zh-Hans': '凝视宝可梦'}}
	public class SpecieGothita : PokemonSpecie
	{
#nullable enable
		private static SpecieGothita? _instance = null;
#nullable restore
        public static SpecieGothita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothita();
                }
                return _instance;
            }
        }

		public SpecieGothita() : base(
			"Gothita",
			45, // HPs
			30, 50, // Attack & Defense
			55, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Gothita Pokemon Class
	public class Gothita : Pokemon
	{

		public Gothita(string nickname, int level)
		: base(
				574,
				SpecieGothita.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gothita() : base(
			574,
			SpecieGothita.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}