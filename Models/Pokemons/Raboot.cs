using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raboot Specie to store common natural stats of every {'abilities': ['blaze', 'libero'], 'base_experience': 147, 'height': 6, 'id': 814, 'moves': [], 'name': 'raboot', 'stats': {'hp': 65, 'attack': 86, 'defense': 60, 'special-attack': 55, 'special-defense': 60, 'speed': 94}, 'types': ['fire'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ラビフット', 'ko': '래비풋', 'zh-Hant': '騰蹴小將', 'fr': 'Lapyro', 'de': 'Kickerlo', 'es': 'Raboot', 'it': 'Raboot', 'en': 'Raboot', 'ja': 'ラビフット', 'zh-Hans': '腾蹴小将'}, 'genera': {'ja-Hrkt': 'うさぎポケモン', 'ko': '토끼포켓몬', 'zh-Hant': '兔子寶可夢', 'fr': 'Pokémon Lapin', 'de': 'Hase', 'es': 'Pokémon Conejo', 'it': 'Pokémon Coniglio', 'en': 'Rabbit Pokémon', 'ja': 'うさぎポケモン', 'zh-Hans': '兔子宝可梦'}}
	public class SpecieRaboot : PokemonSpecie
	{
#nullable enable
		private static SpecieRaboot? _instance = null;
#nullable restore
        public static SpecieRaboot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaboot();
                }
                return _instance;
            }
        }

		public SpecieRaboot() : base(
			"Raboot",
			65, // HPs
			86, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			94			
		) {}
	}


	//Raboot Pokemon Class
	public class Raboot : Pokemon
	{

		public Raboot(string nickname, int level) : base(
			814,
			SpecieRaboot.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Raboot() : base(
			814,
			SpecieRaboot.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}