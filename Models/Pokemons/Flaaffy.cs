using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flaaffy Specie to store common natural stats of every {'abilities': ['static', 'plus'], 'base_experience': 128, 'height': 8, 'id': 180, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'counter', 'seismic-toss', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'mimic', 'double-team', 'confuse-ray', 'defense-curl', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'focus-punch', 'charge', 'brick-break', 'secret-power', 'signal-beam', 'shock-wave', 'natural-gift', 'fling', 'magnet-rise', 'power-gem', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'after-you', 'round', 'echoed-voice', 'volt-switch', 'electroweb', 'wild-charge', 'cotton-guard', 'confide', 'power-up-punch'], 'name': 'flaaffy', 'stats': {'hp': 70, 'attack': 55, 'defense': 55, 'special-attack': 80, 'special-defense': 60, 'speed': 45}, 'types': ['electric'], 'weight': 133, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'pink', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'モココ', 'roomaji': 'Mokoko', 'ko': '보송송', 'zh-Hant': '茸茸羊', 'fr': 'Lainergie', 'de': 'Waaty', 'es': 'Flaaffy', 'it': 'Flaaffy', 'en': 'Flaaffy', 'ja': 'モココ', 'zh-Hans': '茸茸羊'}, 'genera': {'ja-Hrkt': 'わたげポケモン', 'ko': '솜털포켓몬', 'zh-Hant': '綿毛寶可夢', 'fr': 'Pokémon Laine', 'de': 'Wolle', 'es': 'Pokémon Lana', 'it': 'Pokémon Lana', 'en': 'Wool Pokémon', 'ja': 'わたげポケモン', 'zh-Hans': '绵毛宝可梦'}}
	public class SpecieFlaaffy : PokemonSpecie
	{
#nullable enable
		private static SpecieFlaaffy? _instance = null;
#nullable restore
        public static SpecieFlaaffy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlaaffy();
                }
                return _instance;
            }
        }

		public SpecieFlaaffy() : base(
			"Flaaffy",
			70, // HPs
			55, 55, // Attack & Defense
			80, 60, // Special Attack & Defense
			45			
		) {}
	}


	//Flaaffy Pokemon Class
	public class Flaaffy : Pokemon
	{

		public Flaaffy(string nickname, int level)
		: base(
				180,
				SpecieFlaaffy.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flaaffy() : base(
			180,
			SpecieFlaaffy.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}