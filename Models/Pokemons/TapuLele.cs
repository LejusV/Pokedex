using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Lele Specie to store common natural stats of every {'abilities': ['psychic-surge', 'telepathy'], 'base_experience': 257, 'height': 12, 'id': 786, 'moves': ['psybeam', 'hyper-beam', 'thunderbolt', 'thunder', 'toxic', 'confusion', 'psychic', 'double-team', 'withdraw', 'light-screen', 'reflect', 'psywave', 'substitute', 'thief', 'protect', 'swagger', 'mean-look', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'flatter', 'facade', 'nature-power', 'taunt', 'skill-swap', 'astonish', 'aromatherapy', 'tickle', 'extrasensory', 'calm-mind', 'fling', 'focus-blast', 'energy-ball', 'giga-impact', 'grass-knot', 'charge-beam', 'psyshock', 'round', 'echoed-voice', 'draining-kiss', 'moonblast', 'confide', 'aromatic-mist', 'dazzling-gleam', 'psychic-terrain', 'natures-madness'], 'name': 'tapu-lele', 'stats': {'hp': 70, 'attack': 85, 'defense': 75, 'special-attack': 130, 'special-defense': 115, 'speed': 95}, 'types': ['psychic', 'fairy'], 'weight': 186, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': -1, 'capture_rate': 3, 'color': 'pink', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カプ・テテフ', 'ko': '카푸나비나', 'zh-Hant': '卡璞・蝶蝶', 'fr': 'Tokopiyon', 'de': 'Kapu-Fala', 'es': 'Tapu Lele', 'it': 'Tapu Lele', 'en': 'Tapu Lele', 'ja': 'カプ・テテフ', 'zh-Hans': '卡璞・蝶蝶'}, 'genera': {'ja-Hrkt': 'とちがみポケモン', 'ko': '토속신포켓몬', 'zh-Hant': '土地神寶可夢', 'fr': 'Pokémon Tutélaire', 'de': 'Schutzpatron', 'es': 'Pokémon Dios Nativo', 'it': 'Pokémon Nume Locale', 'en': 'Land Spirit Pokémon', 'ja': 'とちがみポケモン', 'zh-Hans': '土地神宝可梦'}}
	public class SpecieTapuLele : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuLele? _instance = null;
#nullable restore
        public static SpecieTapuLele Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuLele();
                }
                return _instance;
            }
        }

		public SpecieTapuLele() : base(
			"Tapu-Lele",
			70, // HPs
			85, 75, // Attack & Defense
			130, 115, // Special Attack & Defense
			95			
		) {}
	}


	//Tapu-Lele Pokemon Class
	public class TapuLele : Pokemon
	{

		public TapuLele(string nickname, int level)
		: base(
				786,
				SpecieTapuLele.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public TapuLele() : base(
			786,
			SpecieTapuLele.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}