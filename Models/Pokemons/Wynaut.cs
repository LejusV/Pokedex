using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wynaut Specie to store common natural stats of every {'abilities': ['shadow-tag', 'telepathy'], 'base_experience': 52, 'height': 6, 'id': 360, 'moves': ['counter', 'splash', 'destiny-bond', 'charm', 'safeguard', 'encore', 'mirror-coat'], 'name': 'wynaut', 'stats': {'hp': 95, 'attack': 23, 'defense': 48, 'special-attack': 23, 'special-defense': 48, 'speed': 23}, 'types': ['psychic'], 'weight': 140, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 125, 'color': 'blue', 'shape': 'upright', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ソーナノ', 'roomaji': 'Sohnano', 'ko': '마자', 'zh-Hant': '小果然', 'fr': 'Okéoké', 'de': 'Isso', 'es': 'Wynaut', 'it': 'Wynaut', 'en': 'Wynaut', 'ja': 'ソーナノ', 'zh-Hans': '小果然'}, 'genera': {'ja-Hrkt': 'ほがらかポケモン', 'ko': '명랑포켓몬', 'zh-Hant': '開朗寶可夢', 'fr': 'Pokémon Ravi', 'de': 'Strahlekind', 'es': 'Pokémon Radiante', 'it': 'Pokémon Brillante', 'en': 'Bright Pokémon', 'ja': 'ほがらかポケモン', 'zh-Hans': '开朗宝可梦'}}
	public class SpecieWynaut : PokemonSpecie
	{
#nullable enable
		private static SpecieWynaut? _instance = null;
#nullable restore
        public static SpecieWynaut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWynaut();
                }
                return _instance;
            }
        }

		public SpecieWynaut() : base(
			"Wynaut",
			95, // HPs
			23, 48, // Attack & Defense
			23, 48, // Special Attack & Defense
			23			
		) {}
	}


	//Wynaut Pokemon Class
	public class Wynaut : Pokemon
	{

		public Wynaut(string nickname, int level)
		: base(
				360,
				SpecieWynaut.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wynaut() : base(
			360,
			SpecieWynaut.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}