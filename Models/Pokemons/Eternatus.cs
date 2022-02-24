using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eternatus Specie to store common natural stats of every {'abilities': ['pressure'], 'base_experience': 345, 'height': 200, 'id': 890, 'moves': [], 'name': 'eternatus', 'stats': {'hp': 140, 'attack': 85, 'defense': 95, 'special-attack': 145, 'special-defense': 95, 'speed': 130}, 'types': ['poison', 'dragon'], 'weight': 9500, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 255, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ムゲンダイナ', 'ko': '무한다이노', 'zh-Hant': '無極汰那', 'fr': 'Éthernatos', 'de': 'Endynalos', 'es': 'Eternatus', 'it': 'Eternatus', 'en': 'Eternatus', 'ja': 'ムゲンダイナ', 'zh-Hans': '无极汰那'}, 'genera': {'ja-Hrkt': 'キョダイポケモン', 'ko': '거대포켓몬', 'zh-Hant': '超極巨寶可夢', 'fr': 'Pokémon Giga', 'de': 'Gigant', 'es': 'Pokémon Gigantesco', 'it': 'Pokémon Gigante', 'en': 'Gigantic Pokémon', 'ja': 'キョダイポケモン', 'zh-Hans': '超极巨宝可梦'}}
	public class SpecieEternatus : PokemonSpecie
	{
#nullable enable
		private static SpecieEternatus? _instance = null;
#nullable restore
        public static SpecieEternatus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEternatus();
                }
                return _instance;
            }
        }

		public SpecieEternatus() : base(
			"Eternatus",
			140, // HPs
			85, 95, // Attack & Defense
			145, 95, // Special Attack & Defense
			130			
		) {}
	}


	//Eternatus Pokemon Class
	public class Eternatus : Pokemon
	{

		public Eternatus(string nickname, int level)
		: base(
				890,
				SpecieEternatus.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Eternatus() : base(
			890,
			SpecieEternatus.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
	}
}