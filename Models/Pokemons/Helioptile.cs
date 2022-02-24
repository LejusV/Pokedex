using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Helioptile Specie to store common natural stats of every {'abilities': ['dry-skin', 'sand-veil', 'solar-power'], 'base_experience': 58, 'height': 5, 'id': 694, 'moves': ['pound', 'razor-wind', 'cut', 'tail-whip', 'surf', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'light-screen', 'glare', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'psych-up', 'facade', 'charge', 'secret-power', 'camouflage', 'rock-tomb', 'signal-beam', 'shock-wave', 'u-turn', 'magnet-rise', 'dark-pulse', 'grass-knot', 'charge-beam', 'low-sweep', 'round', 'volt-switch', 'bulldoze', 'dragon-tail', 'electroweb', 'wild-charge', 'parabolic-charge', 'electrify', 'confide', 'electric-terrain'], 'name': 'helioptile', 'stats': {'hp': 44, 'attack': 38, 'defense': 33, 'special-attack': 61, 'special-defense': 43, 'speed': 70}, 'types': ['electric', 'normal'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'エリキテル', 'ko': '목도리키텔', 'zh-Hant': '傘電蜥', 'fr': 'Galvaran', 'de': 'Eguana', 'es': 'Helioptile', 'it': 'Helioptile', 'en': 'Helioptile', 'ja': 'エリキテル', 'zh-Hans': '伞电蜥'}, 'genera': {'ja-Hrkt': 'はつでんポケモン', 'ko': '발전포켓몬', 'zh-Hant': '發電寶可夢', 'fr': 'Pokémon Générateur', 'de': 'Generator', 'es': 'Pokémon Generador', 'it': 'Pokémon Generatore', 'en': 'Generator Pokémon', 'ja': 'はつでんポケモン', 'zh-Hans': '发电宝可梦'}}
	public class SpecieHelioptile : PokemonSpecie
	{
#nullable enable
		private static SpecieHelioptile? _instance = null;
#nullable restore
        public static SpecieHelioptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHelioptile();
                }
                return _instance;
            }
        }

		public SpecieHelioptile() : base(
			"Helioptile",
			44, // HPs
			38, 33, // Attack & Defense
			61, 43, // Special Attack & Defense
			70			
		) {}
	}


	//Helioptile Pokemon Class
	public class Helioptile : Pokemon
	{

		public Helioptile(string nickname, int level)
		: base(
				694,
				SpecieHelioptile.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Helioptile(int level)
		: base(
				694,
				SpecieHelioptile.Instance, // Pokemon Specie
				"Helioptile", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Helioptile() : base(
			694,
			SpecieHelioptile.Instance, // Pokemon Specie
			Electric.Instance, Normal.Instance			
		) {}
	}
}