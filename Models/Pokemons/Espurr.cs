using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Espurr Specie to store common natural stats of every {'abilities': ['keen-eye', 'infiltrator', 'own-tempo'], 'base_experience': 71, 'height': 3, 'id': 677, 'moves': ['scratch', 'cut', 'leer', 'psybeam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'barrier', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'fake-out', 'torment', 'facade', 'helping-hand', 'trick', 'role-play', 'assist', 'magic-coat', 'recycle', 'yawn', 'snatch', 'secret-power', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'payback', 'dark-pulse', 'energy-ball', 'zen-headbutt', 'trick-room', 'charge-beam', 'wonder-room', 'psyshock', 'magic-room', 'round', 'echoed-voice', 'work-up', 'disarming-voice', 'confide'], 'name': 'espurr', 'stats': {'hp': 62, 'attack': 48, 'defense': 54, 'special-attack': 63, 'special-defense': 60, 'speed': 68}, 'types': ['psychic'], 'weight': 35, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャスパー', 'ko': '냐스퍼', 'zh-Hant': '妙喵', 'fr': 'Psystigri', 'de': 'Psiau', 'es': 'Espurr', 'it': 'Espurr', 'en': 'Espurr', 'ja': 'ニャスパー', 'zh-Hans': '妙喵'}, 'genera': {'ja-Hrkt': 'じせいポケモン', 'ko': '자제포켓몬', 'zh-Hant': '自制寶可夢', 'fr': 'Pokémon Retenue', 'de': 'Zügelung', 'es': 'Pokémon Moderación', 'it': 'Pokémon Moderazione', 'en': 'Restraint Pokémon', 'ja': 'じせいポケモン', 'zh-Hans': '自制宝可梦'}}
	public class SpecieEspurr : PokemonSpecie
	{
#nullable enable
		private static SpecieEspurr? _instance = null;
#nullable restore
        public static SpecieEspurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEspurr();
                }
                return _instance;
            }
        }

		public SpecieEspurr() : base(
			"Espurr",
			62, // HPs
			48, 54, // Attack & Defense
			63, 60, // Special Attack & Defense
			68			
		) {}
	}


	//Espurr Pokemon Class
	public class Espurr : Pokemon
	{

		public Espurr(string nickname, int level)
		: base(
				677,
				SpecieEspurr.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Espurr() : base(
			677,
			SpecieEspurr.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}