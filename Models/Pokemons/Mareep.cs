using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mareep Specie to store common natural stats of every {'abilities': ['static', 'plus'], 'base_experience': 56, 'height': 6, 'id': 179, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'mimic', 'screech', 'double-team', 'confuse-ray', 'defense-curl', 'light-screen', 'reflect', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'flatter', 'facade', 'charge', 'secret-power', 'odor-sleuth', 'signal-beam', 'shock-wave', 'natural-gift', 'magnet-rise', 'power-gem', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'after-you', 'round', 'echoed-voice', 'electroweb', 'wild-charge', 'cotton-guard', 'confide', 'eerie-impulse', 'electric-terrain'], 'name': 'mareep', 'stats': {'hp': 55, 'attack': 40, 'defense': 40, 'special-attack': 65, 'special-defense': 45, 'speed': 35}, 'types': ['electric'], 'weight': 78, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 235, 'color': 'white', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'メリープ', 'roomaji': 'Merriep', 'ko': '메리프', 'zh-Hant': '咩利羊', 'fr': 'Wattouat', 'de': 'Voltilamm', 'es': 'Mareep', 'it': 'Mareep', 'en': 'Mareep', 'ja': 'メリープ', 'zh-Hans': '咩利羊'}, 'genera': {'ja-Hrkt': 'わたげポケモン', 'ko': '솜털포켓몬', 'zh-Hant': '綿毛寶可夢', 'fr': 'Pokémon Laine', 'de': 'Wolle', 'es': 'Pokémon Lana', 'it': 'Pokémon Lana', 'en': 'Wool Pokémon', 'ja': 'わたげポケモン', 'zh-Hans': '绵毛宝可梦'}}
	public class SpecieMareep : PokemonSpecie
	{
#nullable enable
		private static SpecieMareep? _instance = null;
#nullable restore
        public static SpecieMareep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMareep();
                }
                return _instance;
            }
        }

		public SpecieMareep() : base(
			"Mareep",
			55, // HPs
			40, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35			
		) {}
	}


	//Mareep Pokemon Class
	public class Mareep : Pokemon
	{

		public Mareep(string nickname, int level)
		: base(
				179,
				SpecieMareep.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mareep() : base(
			179,
			SpecieMareep.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}