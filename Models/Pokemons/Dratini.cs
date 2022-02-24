using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dratini Specie to store common natural stats of every {'abilities': ['shed-skin', 'marvel-scale'], 'base_experience': 60, 'height': 18, 'id': 147, 'moves': ['bind', 'slam', 'headbutt', 'body-slam', 'wrap', 'take-down', 'double-edge', 'leer', 'supersonic', 'flamethrower', 'mist', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'light-screen', 'haze', 'reflect', 'bide', 'fire-blast', 'waterfall', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'zap-cannon', 'icy-wind', 'detect', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'extreme-speed', 'whirlpool', 'hail', 'facade', 'secret-power', 'dragon-dance', 'shock-wave', 'water-pulse', 'natural-gift', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'draco-meteor', 'captivate', 'aqua-jet', 'round', 'incinerate', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'dratini', 'stats': {'hp': 41, 'attack': 64, 'defense': 45, 'special-attack': 50, 'special-defense': 50, 'speed': 50}, 'types': ['dragon'], 'weight': 33, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'squiggle', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'ミニリュウ', 'roomaji': 'Miniryu', 'ko': '미뇽', 'zh-Hant': '迷你龍', 'fr': 'Minidraco', 'de': 'Dratini', 'es': 'Dratini', 'it': 'Dratini', 'en': 'Dratini', 'ja': 'ミニリュウ', 'zh-Hans': '迷你龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieDratini : PokemonSpecie
	{
#nullable enable
		private static SpecieDratini? _instance = null;
#nullable restore
        public static SpecieDratini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDratini();
                }
                return _instance;
            }
        }

		public SpecieDratini() : base(
			"Dratini",
			41, // HPs
			64, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			50			
		) {}
	}


	//Dratini Pokemon Class
	public class Dratini : Pokemon
	{

		public Dratini(string nickname, int level)
		: base(
				147,
				SpecieDratini.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dratini() : base(
			147,
			SpecieDratini.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}