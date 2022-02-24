using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Heliolisk Specie to store common natural stats of every {'abilities': ['dry-skin', 'sand-veil', 'solar-power'], 'base_experience': 168, 'height': 10, 'id': 695, 'moves': ['fire-punch', 'thunder-punch', 'razor-wind', 'cut', 'surf', 'hyper-beam', 'low-kick', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'double-team', 'light-screen', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'psych-up', 'facade', 'charge', 'secret-power', 'hyper-voice', 'rock-tomb', 'signal-beam', 'shock-wave', 'u-turn', 'magnet-rise', 'dark-pulse', 'dragon-pulse', 'focus-blast', 'giga-impact', 'grass-knot', 'charge-beam', 'low-sweep', 'round', 'volt-switch', 'bulldoze', 'dragon-tail', 'electroweb', 'wild-charge', 'parabolic-charge', 'electrify', 'confide', 'eerie-impulse', 'brutal-swing'], 'name': 'heliolisk', 'stats': {'hp': 62, 'attack': 55, 'defense': 52, 'special-attack': 109, 'special-defense': 94, 'speed': 109}, 'types': ['electric', 'normal'], 'weight': 210, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'エレザード', 'ko': '일레도리자드', 'zh-Hant': '光電傘蜥', 'fr': 'Iguolta', 'de': 'Elezard', 'es': 'Heliolisk', 'it': 'Heliolisk', 'en': 'Heliolisk', 'ja': 'エレザード', 'zh-Hans': '光电伞蜥'}, 'genera': {'ja-Hrkt': 'はつでんポケモン', 'ko': '발전포켓몬', 'zh-Hant': '發電寶可夢', 'fr': 'Pokémon Générateur', 'de': 'Generator', 'es': 'Pokémon Generador', 'it': 'Pokémon Generatore', 'en': 'Generator Pokémon', 'ja': 'はつでんポケモン', 'zh-Hans': '发电宝可梦'}}
	public class SpecieHeliolisk : PokemonSpecie
	{
#nullable enable
		private static SpecieHeliolisk? _instance = null;
#nullable restore
        public static SpecieHeliolisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeliolisk();
                }
                return _instance;
            }
        }

		public SpecieHeliolisk() : base(
			"Heliolisk",
			62, // HPs
			55, 52, // Attack & Defense
			109, 94, // Special Attack & Defense
			109			
		) {}
	}


	//Heliolisk Pokemon Class
	public class Heliolisk : Pokemon
	{

		public Heliolisk(string nickname, int level)
		: base(
				695,
				SpecieHeliolisk.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heliolisk(int level)
		: base(
				695,
				SpecieHeliolisk.Instance, // Pokemon Specie
				"Heliolisk", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Heliolisk() : base(
			695,
			SpecieHeliolisk.Instance, // Pokemon Specie
			Electric.Instance, Normal.Instance			
		) {}
	}
}