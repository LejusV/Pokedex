using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dragonair Specie to store common natural stats of every {'abilities': ['shed-skin', 'marvel-scale'], 'base_experience': 147, 'height': 40, 'id': 148, 'moves': ['bind', 'slam', 'headbutt', 'horn-drill', 'body-slam', 'wrap', 'take-down', 'double-edge', 'leer', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'fire-blast', 'waterfall', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'zap-cannon', 'icy-wind', 'detect', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'whirlpool', 'hail', 'facade', 'secret-power', 'dragon-dance', 'shock-wave', 'water-pulse', 'natural-gift', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'draco-meteor', 'captivate', 'round', 'incinerate', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'dragonair', 'stats': {'hp': 61, 'attack': 84, 'defense': 65, 'special-attack': 70, 'special-defense': 70, 'speed': 70}, 'types': ['dragon'], 'weight': 165, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'squiggle', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'ハクリュー', 'roomaji': 'Hakuryu', 'ko': '신뇽', 'zh-Hant': '哈克龍', 'fr': 'Draco', 'de': 'Dragonir', 'es': 'Dragonair', 'it': 'Dragonair', 'en': 'Dragonair', 'ja': 'ハクリュー', 'zh-Hans': '哈克龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieDragonair : PokemonSpecie
	{
#nullable enable
		private static SpecieDragonair? _instance = null;
#nullable restore
        public static SpecieDragonair Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragonair();
                }
                return _instance;
            }
        }

		public SpecieDragonair() : base(
			"Dragonair",
			61, // HPs
			84, 65, // Attack & Defense
			70, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Dragonair Pokemon Class
	public class Dragonair : Pokemon
	{

		public Dragonair(string nickname, int level)
		: base(
				148,
				SpecieDragonair.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dragonair() : base(
			148,
			SpecieDragonair.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}