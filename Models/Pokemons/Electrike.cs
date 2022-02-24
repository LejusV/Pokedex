using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Electrike Specie to store common natural stats of every {'abilities': ['static', 'lightning-rod', 'minus'], 'base_experience': 59, 'height': 6, 'id': 309, 'moves': ['headbutt', 'tackle', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'flamethrower', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'mimic', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'uproar', 'facade', 'charge', 'secret-power', 'odor-sleuth', 'signal-beam', 'howl', 'shock-wave', 'natural-gift', 'magnet-rise', 'switcheroo', 'thunder-fang', 'ice-fang', 'fire-fang', 'discharge', 'captivate', 'charge-beam', 'flame-burst', 'electro-ball', 'round', 'volt-switch', 'wild-charge', 'snarl', 'confide', 'eerie-impulse'], 'name': 'electrike', 'stats': {'hp': 40, 'attack': 45, 'defense': 40, 'special-attack': 65, 'special-defense': 40, 'speed': 65}, 'types': ['electric'], 'weight': 152, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'fr': 'Dynavolt', 'ja-Hrkt': 'ラクライ', 'roomaji': 'Rakurai', 'ko': '썬더라이', 'zh-Hant': '落雷獸', 'de': 'Frizelbliz', 'es': 'Electrike', 'it': 'Electrike', 'en': 'Electrike', 'ja': 'ラクライ', 'zh-Hans': '落雷兽'}, 'genera': {'fr': 'Pokémon Orage', 'ja-Hrkt': 'いなずまポケモン', 'ko': '천둥번개포켓몬', 'zh-Hant': '閃電寶可夢', 'de': 'Gewitter', 'es': 'Pokémon Calambre', 'it': 'Pokémon Lampo', 'en': 'Lightning Pokémon', 'ja': 'いなずまポケモン', 'zh-Hans': '闪电宝可梦'}}
	public class SpecieElectrike : PokemonSpecie
	{
#nullable enable
		private static SpecieElectrike? _instance = null;
#nullable restore
        public static SpecieElectrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectrike();
                }
                return _instance;
            }
        }

		public SpecieElectrike() : base(
			"Electrike",
			40, // HPs
			45, 40, // Attack & Defense
			65, 40, // Special Attack & Defense
			65			
		) {}
	}


	//Electrike Pokemon Class
	public class Electrike : Pokemon
	{

		public Electrike(string nickname, int level)
		: base(
				309,
				SpecieElectrike.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electrike(int level)
		: base(
				309,
				SpecieElectrike.Instance, // Pokemon Specie
				"Electrike", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electrike() : base(
			309,
			SpecieElectrike.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}