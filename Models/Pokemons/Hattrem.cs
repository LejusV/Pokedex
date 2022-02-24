using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hattrem Specie to store common natural stats of every {'abilities': ['healer', 'anticipation', 'magic-bounce'], 'base_experience': 130, 'height': 6, 'id': 857, 'moves': [], 'name': 'hattrem', 'stats': {'hp': 57, 'attack': 40, 'defense': 65, 'special-attack': 86, 'special-defense': 73, 'speed': 49}, 'types': ['psychic'], 'weight': 48, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 120, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'テブリム', 'ko': '손지브림', 'zh-Hant': '提布莉姆', 'fr': 'Chapotus', 'de': 'Brimano', 'es': 'Hattrem', 'it': 'Hattrem', 'en': 'Hattrem', 'ja': 'テブリム', 'zh-Hans': '提布莉姆'}, 'genera': {'ja-Hrkt': 'せいしゅくポケモン', 'ko': '정숙포켓몬', 'zh-Hant': '肅靜寶可夢', 'fr': 'Pokémon Serein', 'de': 'Ruhe', 'es': 'Pokémon Serenidad', 'it': 'Pokémon Quiete', 'en': 'Serene Pokémon', 'ja': 'せいしゅくポケモン', 'zh-Hans': '肃静宝可梦'}}
	public class SpecieHattrem : PokemonSpecie
	{
#nullable enable
		private static SpecieHattrem? _instance = null;
#nullable restore
        public static SpecieHattrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHattrem();
                }
                return _instance;
            }
        }

		public SpecieHattrem() : base(
			"Hattrem",
			57, // HPs
			40, 65, // Attack & Defense
			86, 73, // Special Attack & Defense
			49			
		) {}
	}


	//Hattrem Pokemon Class
	public class Hattrem : Pokemon
	{

		public Hattrem(string nickname, int level)
		: base(
				857,
				SpecieHattrem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hattrem() : base(
			857,
			SpecieHattrem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}