using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Morgrem Specie to store common natural stats of every {'abilities': ['prankster', 'frisk', 'pickpocket'], 'base_experience': 130, 'height': 8, 'id': 860, 'moves': [], 'name': 'morgrem', 'stats': {'hp': 65, 'attack': 60, 'defense': 45, 'special-attack': 75, 'special-defense': 55, 'speed': 70}, 'types': ['dark', 'fairy'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 120, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ギモー', 'ko': '쏘겨모', 'zh-Hant': '詐唬魔', 'fr': 'Fourbelin', 'de': 'Pelzebub', 'es': 'Morgrem', 'it': 'Morgrem', 'en': 'Morgrem', 'ja': 'ギモー', 'zh-Hans': '诈唬魔'}, 'genera': {'ja-Hrkt': 'しょうわるポケモン', 'ko': '성악포켓몬', 'zh-Hant': '壞心眼寶可夢', 'fr': 'Pokémon Scélérat', 'de': 'Schelm', 'es': 'Pokémon Malicioso', 'it': 'Pokémon Furbizia', 'en': 'Devious Pokémon', 'ja': 'しょうわるポケモン', 'zh-Hans': '坏心眼宝可梦'}}
	public class SpecieMorgrem : PokemonSpecie
	{
#nullable enable
		private static SpecieMorgrem? _instance = null;
#nullable restore
        public static SpecieMorgrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorgrem();
                }
                return _instance;
            }
        }

		public SpecieMorgrem() : base(
			"Morgrem",
			65, // HPs
			60, 45, // Attack & Defense
			75, 55, // Special Attack & Defense
			70			
		) {}
	}


	//Morgrem Pokemon Class
	public class Morgrem : Pokemon
	{

		public Morgrem(string nickname, int level) : base(
			860,
			SpecieMorgrem.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Fairy.Instance			
		) {}

		public Morgrem() : base(
			860,
			SpecieMorgrem.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
	}
}