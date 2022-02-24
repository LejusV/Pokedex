using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cosmoem Specie to store common natural stats of every {'abilities': ['sturdy'], 'base_experience': 140, 'height': 1, 'id': 790, 'moves': ['teleport', 'cosmic-power'], 'name': 'cosmoem', 'stats': {'hp': 43, 'attack': 29, 'defense': 131, 'special-attack': 29, 'special-defense': 131, 'speed': 37}, 'types': ['psychic'], 'weight': 9999, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'blue', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'コスモウム', 'ko': '코스모움', 'zh-Hant': '科斯莫姆', 'fr': 'Cosmovum', 'de': 'Cosmovum', 'es': 'Cosmoem', 'it': 'Cosmoem', 'en': 'Cosmoem', 'ja': 'コスモウム', 'zh-Hans': '科斯莫姆'}, 'genera': {'ja-Hrkt': 'げんしせいポケモン', 'ko': '원시성포켓몬', 'zh-Hant': '原始星寶可夢', 'fr': 'Pokémon Proto-Étoile', 'de': 'Urgestirn', 'es': 'Pokémon Protostrella', 'it': 'Pokémon Protostella', 'en': 'Protostar Pokémon', 'ja': 'げんしせいポケモン', 'zh-Hans': '原始星宝可梦'}}
	public class SpecieCosmoem : PokemonSpecie
	{
#nullable enable
		private static SpecieCosmoem? _instance = null;
#nullable restore
        public static SpecieCosmoem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCosmoem();
                }
                return _instance;
            }
        }

		public SpecieCosmoem() : base(
			"Cosmoem",
			43, // HPs
			29, 131, // Attack & Defense
			29, 131, // Special Attack & Defense
			37			
		) {}
	}


	//Cosmoem Pokemon Class
	public class Cosmoem : Pokemon
	{

		public Cosmoem(string nickname, int level)
		: base(
				790,
				SpecieCosmoem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cosmoem() : base(
			790,
			SpecieCosmoem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}