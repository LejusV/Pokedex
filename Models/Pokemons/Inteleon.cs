using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Inteleon Specie to store common natural stats of every {'abilities': ['torrent', 'sniper'], 'base_experience': 265, 'height': 19, 'id': 818, 'moves': [], 'name': 'inteleon', 'stats': {'hp': 70, 'attack': 85, 'defense': 65, 'special-attack': 125, 'special-defense': 65, 'speed': 120}, 'types': ['water'], 'weight': 452, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'インテレオン', 'ko': '인텔리레온', 'zh-Hant': '千面避役', 'fr': 'Lézargus', 'de': 'Intelleon', 'es': 'Inteleon', 'it': 'Inteleon', 'en': 'Inteleon', 'ja': 'インテレオン', 'zh-Hans': '千面避役'}, 'genera': {'ja-Hrkt': 'エージェントポケモン', 'ko': '에이전트포켓몬', 'zh-Hant': '特工寶可夢', 'fr': 'Pokémon Agent Secret', 'de': 'Geheimagent', 'es': 'Pokémon Agente', 'it': 'Pokémon Agente', 'en': 'Secret Agent Pokémon', 'ja': 'エージェントポケモン', 'zh-Hans': '特工宝可梦'}}
	public class SpecieInteleon : PokemonSpecie
	{
#nullable enable
		private static SpecieInteleon? _instance = null;
#nullable restore
        public static SpecieInteleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInteleon();
                }
                return _instance;
            }
        }

		public SpecieInteleon() : base(
			"Inteleon",
			70, // HPs
			85, 65, // Attack & Defense
			125, 65, // Special Attack & Defense
			120			
		) {}
	}


	//Inteleon Pokemon Class
	public class Inteleon : Pokemon
	{

		public Inteleon(string nickname, int level) : base(
			818,
			SpecieInteleon.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Inteleon() : base(
			818,
			SpecieInteleon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}