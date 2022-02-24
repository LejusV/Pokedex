using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Bulu Specie to store common natural stats of every {'abilities': ['grassy-surge', 'telepathy'], 'base_experience': 257, 'height': 19, 'id': 787, 'moves': ['swords-dance', 'whirlwind', 'horn-attack', 'roar', 'disable', 'hyper-beam', 'leech-seed', 'solar-beam', 'toxic', 'withdraw', 'light-screen', 'reflect', 'skull-bash', 'rock-slide', 'substitute', 'protect', 'scary-face', 'giga-drain', 'false-swipe', 'swagger', 'mean-look', 'sleep-talk', 'return', 'frustration', 'safeguard', 'megahorn', 'hidden-power', 'sunny-day', 'psych-up', 'torment', 'facade', 'nature-power', 'taunt', 'superpower', 'brick-break', 'rock-tomb', 'bulk-up', 'calm-mind', 'payback', 'fling', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'stone-edge', 'grass-knot', 'wood-hammer', 'round', 'echoed-voice', 'work-up', 'horn-leech', 'snarl', 'rototiller', 'grassy-terrain', 'confide', 'dazzling-gleam', 'leafage', 'smart-strike', 'brutal-swing', 'natures-madness'], 'name': 'tapu-bulu', 'stats': {'hp': 70, 'attack': 130, 'defense': 115, 'special-attack': 85, 'special-defense': 95, 'speed': 75}, 'types': ['grass', 'fairy'], 'weight': 455, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': -1, 'capture_rate': 3, 'color': 'red', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カプ・ブルル', 'ko': '카푸브루루', 'zh-Hant': '卡璞・哞哞', 'fr': 'Tokotoro', 'de': 'Kapu-Toro', 'es': 'Tapu Bulu', 'it': 'Tapu Bulu', 'en': 'Tapu Bulu', 'ja': 'カプ・ブルル', 'zh-Hans': '卡璞・哞哞'}, 'genera': {'ja-Hrkt': 'とちがみポケモン', 'ko': '토속신포켓몬', 'zh-Hant': '土地神寶可夢', 'fr': 'Pokémon Tutélaire', 'de': 'Schutzpatron', 'es': 'Pokémon Dios Nativo', 'it': 'Pokémon Nume Locale', 'en': 'Land Spirit Pokémon', 'ja': 'とちがみポケモン', 'zh-Hans': '土地神宝可梦'}}
	public class SpecieTapuBulu : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuBulu? _instance = null;
#nullable restore
        public static SpecieTapuBulu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuBulu();
                }
                return _instance;
            }
        }

		public SpecieTapuBulu() : base(
			"Tapu-Bulu",
			70, // HPs
			130, 115, // Attack & Defense
			85, 95, // Special Attack & Defense
			75			
		) {}
	}


	//Tapu-Bulu Pokemon Class
	public class TapuBulu : Pokemon
	{

		public TapuBulu(string nickname, int level)
		: base(
				787,
				SpecieTapuBulu.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public TapuBulu() : base(
			787,
			SpecieTapuBulu.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
	}
}