using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hatenna Specie to store common natural stats of every {'abilities': ['healer', 'anticipation', 'magic-bounce'], 'base_experience': 53, 'height': 4, 'id': 856, 'moves': [], 'name': 'hatenna', 'stats': {'hp': 42, 'attack': 30, 'defense': 45, 'special-attack': 56, 'special-defense': 53, 'speed': 39}, 'types': ['psychic'], 'weight': 34, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 235, 'color': 'pink', 'shape': 'legs', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ミブリム', 'ko': '몸지브림', 'zh-Hant': '迷布莉姆', 'fr': 'Bibichut', 'de': 'Brimova', 'es': 'Hatenna', 'it': 'Hatenna', 'en': 'Hatenna', 'ja': 'ミブリム', 'zh-Hans': '迷布莉姆'}, 'genera': {'ja-Hrkt': 'おだやかポケモン', 'ko': '차분포켓몬', 'zh-Hant': '寧靜寶可夢', 'fr': 'Pokémon Calme', 'de': 'Geruhsam', 'es': 'Pokémon Calma', 'it': 'Pokémon Calma', 'en': 'Calm Pokémon', 'ja': 'おだやかポケモン', 'zh-Hans': '宁静宝可梦'}}
	public class SpecieHatenna : PokemonSpecie
	{
#nullable enable
		private static SpecieHatenna? _instance = null;
#nullable restore
        public static SpecieHatenna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHatenna();
                }
                return _instance;
            }
        }

		public SpecieHatenna() : base(
			"Hatenna",
			42, // HPs
			30, 45, // Attack & Defense
			56, 53, // Special Attack & Defense
			39			
		) {}
	}


	//Hatenna Pokemon Class
	public class Hatenna : Pokemon
	{

		public Hatenna(string nickname, int level) : base(
			856,
			SpecieHatenna.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Hatenna() : base(
			856,
			SpecieHatenna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}