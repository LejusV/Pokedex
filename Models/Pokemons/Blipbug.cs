using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blipbug Specie to store common natural stats of every {'abilities': ['swarm', 'compound-eyes', 'telepathy'], 'base_experience': 36, 'height': 4, 'id': 824, 'moves': [], 'name': 'blipbug', 'stats': {'hp': 25, 'attack': 20, 'defense': 20, 'special-attack': 25, 'special-defense': 45, 'speed': 45}, 'types': ['bug'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'armor', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'サッチムシ', 'ko': '두루지벌레', 'zh-Hant': '索偵蟲', 'fr': 'Larvadar', 'de': 'Sensect', 'es': 'Blipbug', 'it': 'Blipbug', 'en': 'Blipbug', 'ja': 'サッチムシ', 'zh-Hans': '索侦虫'}, 'genera': {'ja-Hrkt': 'ようちゅうポケモン', 'ko': '유충포켓몬', 'zh-Hant': '幼蟲寶可夢', 'fr': 'Pokémon Larve', 'de': 'Larve', 'es': 'Pokémon Pupa', 'it': 'Pokémon Coleolarva', 'en': 'Larva Pokémon', 'ja': 'ようちゅうポケモン', 'zh-Hans': '幼虫宝可梦'}}
	public class SpecieBlipbug : PokemonSpecie
	{
#nullable enable
		private static SpecieBlipbug? _instance = null;
#nullable restore
        public static SpecieBlipbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlipbug();
                }
                return _instance;
            }
        }

		public SpecieBlipbug() : base(
			"Blipbug",
			25, // HPs
			20, 20, // Attack & Defense
			25, 45, // Special Attack & Defense
			45			
		) {}
	}


	//Blipbug Pokemon Class
	public class Blipbug : Pokemon
	{

		public Blipbug(string nickname, int level)
		: base(
				824,
				SpecieBlipbug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blipbug(int level)
		: base(
				824,
				SpecieBlipbug.Instance, // Pokemon Specie
				"Blipbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blipbug() : base(
			824,
			SpecieBlipbug.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}