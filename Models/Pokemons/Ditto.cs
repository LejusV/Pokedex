using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ditto Specie to store common natural stats of every {'abilities': ['limber', 'imposter'], 'base_experience': 101, 'height': 3, 'id': 132, 'moves': ['transform'], 'name': 'ditto', 'stats': {'hp': 48, 'attack': 48, 'defense': 48, 'special-attack': 48, 'special-defense': 48, 'speed': 48}, 'types': ['normal'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 35, 'color': 'purple', 'shape': 'ball', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ditto'], 'names': {'ja-Hrkt': 'メタモン', 'roomaji': 'Metamon', 'ko': '메타몽', 'zh-Hant': '百變怪', 'fr': 'Métamorph', 'de': 'Ditto', 'es': 'Ditto', 'it': 'Ditto', 'en': 'Ditto', 'ja': 'メタモン', 'zh-Hans': '百变怪'}, 'genera': {'ja-Hrkt': 'へんしんポケモン', 'ko': '변신포켓몬', 'zh-Hant': '變身寶可夢', 'fr': 'Pokémon Morphing', 'de': 'Transform', 'es': 'Pokémon Transform.', 'it': 'Pokémon Mutante', 'en': 'Transform Pokémon', 'ja': 'へんしんポケモン', 'zh-Hans': '变身宝可梦'}}
	public class SpecieDitto : PokemonSpecie
	{
#nullable enable
		private static SpecieDitto? _instance = null;
#nullable restore
        public static SpecieDitto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDitto();
                }
                return _instance;
            }
        }

		public SpecieDitto() : base(
			"Ditto",
			48, // HPs
			48, 48, // Attack & Defense
			48, 48, // Special Attack & Defense
			48			
		) {}
	}


	//Ditto Pokemon Class
	public class Ditto : Pokemon
	{

		public Ditto(string nickname, int level) : base(
			132,
			SpecieDitto.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Ditto() : base(
			132,
			SpecieDitto.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}