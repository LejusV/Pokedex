using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scatterbug Specie to store common natural stats of every {'abilities': ['shield-dust', 'compound-eyes', 'friend-guard'], 'base_experience': 40, 'height': 3, 'id': 664, 'moves': ['tackle', 'poison-powder', 'stun-spore', 'string-shot', 'bug-bite', 'rage-powder'], 'name': 'scatterbug', 'stats': {'hp': 38, 'attack': 35, 'defense': 40, 'special-attack': 27, 'special-defense': 25, 'speed': 35}, 'types': ['bug'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'black', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コフキムシ', 'ko': '분이벌레', 'zh-Hant': '粉蝶蟲', 'fr': 'Lépidonille', 'de': 'Purmel', 'es': 'Scatterbug', 'it': 'Scatterbug', 'en': 'Scatterbug', 'ja': 'コフキムシ', 'zh-Hans': '粉蝶虫'}, 'genera': {'ja-Hrkt': 'こなふきポケモン', 'ko': '가루뿜기포켓몬', 'zh-Hant': '噴粉寶可夢', 'fr': 'Pokémon Exhalécaille', 'de': 'Puderinsekt', 'es': 'Pokémon Tiraescamas', 'it': 'Pokémon Tirascaglie', 'en': 'Scatterdust Pokémon', 'ja': 'こなふきポケモン', 'zh-Hans': '喷粉宝可梦'}}
	public class SpecieScatterbug : PokemonSpecie
	{
#nullable enable
		private static SpecieScatterbug? _instance = null;
#nullable restore
        public static SpecieScatterbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScatterbug();
                }
                return _instance;
            }
        }

		public SpecieScatterbug() : base(
			"Scatterbug",
			38, // HPs
			35, 40, // Attack & Defense
			27, 25, // Special Attack & Defense
			35			
		) {}
	}


	//Scatterbug Pokemon Class
	public class Scatterbug : Pokemon
	{

		public Scatterbug(string nickname, int level)
		: base(
				664,
				SpecieScatterbug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scatterbug(int level)
		: base(
				664,
				SpecieScatterbug.Instance, // Pokemon Specie
				"Scatterbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scatterbug() : base(
			664,
			SpecieScatterbug.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}