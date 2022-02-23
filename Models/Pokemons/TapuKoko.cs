using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Koko Specie to store common natural stats of every {'abilities': ['electric-surge', 'telepathy'], 'base_experience': 257, 'height': 18, 'id': 785, 'moves': ['fly', 'roar', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'screech', 'double-team', 'withdraw', 'light-screen', 'reflect', 'mirror-move', 'substitute', 'thief', 'protect', 'false-swipe', 'swagger', 'spark', 'steel-wing', 'mean-look', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'torment', 'facade', 'nature-power', 'charge', 'taunt', 'aerial-ace', 'calm-mind', 'shock-wave', 'roost', 'u-turn', 'power-swap', 'brave-bird', 'giga-impact', 'discharge', 'grass-knot', 'electro-ball', 'round', 'echoed-voice', 'sky-drop', 'acrobatics', 'volt-switch', 'work-up', 'wild-charge', 'confide', 'electric-terrain', 'dazzling-gleam', 'natures-madness'], 'name': 'tapu-koko', 'stats': {'hp': 70, 'attack': 115, 'defense': 85, 'special-attack': 95, 'special-defense': 75, 'speed': 130}, 'types': ['electric', 'fairy'], 'weight': 205, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カプ・コケコ', 'ko': '카푸꼬꼬꼭', 'zh-Hant': '卡璞・鳴鳴', 'fr': 'Tokorico', 'de': 'Kapu-Riki', 'es': 'Tapu Koko', 'it': 'Tapu Koko', 'en': 'Tapu Koko', 'ja': 'カプ・コケコ', 'zh-Hans': '卡璞・鸣鸣'}, 'genera': {'ja-Hrkt': 'とちがみポケモン', 'ko': '토속신포켓몬', 'zh-Hant': '土地神寶可夢', 'fr': 'Pokémon Tutélaire', 'de': 'Schutzpatron', 'es': 'Pokémon Dios Nativo', 'it': 'Pokémon Nume Locale', 'en': 'Land Spirit Pokémon', 'ja': 'とちがみポケモン', 'zh-Hans': '土地神宝可梦'}}
	public class SpecieTapuKoko : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuKoko? _instance = null;
#nullable restore
        public static SpecieTapuKoko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuKoko();
                }
                return _instance;
            }
        }

		public SpecieTapuKoko() : base(
			"Tapu-Koko",
			70, // HPs
			115, 85, // Attack & Defense
			95, 75, // Special Attack & Defense
			130			
		) {}
	}


	//Tapu-Koko Pokemon Class
	public class TapuKoko : Pokemon
	{

		public TapuKoko(string nickname, int level) : base(
			785,
			SpecieTapuKoko.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance, Fairy.Instance			
		) {}

		public TapuKoko() : base(
			785,
			SpecieTapuKoko.Instance, // Pokemon Specie
			Electric.Instance, Fairy.Instance			
		) {}
	}
}