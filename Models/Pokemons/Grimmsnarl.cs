using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grimmsnarl Specie to store common natural stats of every {'abilities': ['prankster', 'frisk', 'pickpocket'], 'base_experience': 255, 'height': 15, 'id': 861, 'moves': [], 'name': 'grimmsnarl', 'stats': {'hp': 95, 'attack': 120, 'defense': 65, 'special-attack': 95, 'special-defense': 75, 'speed': 60}, 'types': ['dark', 'fairy'], 'weight': 610, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'オーロンゲ', 'ko': '오롱털', 'zh-Hant': '長毛巨魔', 'fr': 'Angoliath', 'de': 'Olangaa', 'es': 'Grimmsnarl', 'it': 'Grimmsnarl', 'en': 'Grimmsnarl', 'ja': 'オーロンゲ', 'zh-Hans': '长毛巨魔'}, 'genera': {'ja-Hrkt': 'ビルドアップポケモン', 'ko': '벌크업포켓몬', 'zh-Hant': '健美寶可夢', 'fr': 'Pokémon Gonflette', 'de': 'Muskelaufbau', 'es': 'Pokémon Voluminoso', 'it': 'Pokémon Granfisico', 'en': 'Bulk Up Pokémon', 'ja': 'ビルドアップポケモン', 'zh-Hans': '健美宝可梦'}}
	public class SpecieGrimmsnarl : PokemonSpecie
	{
#nullable enable
		private static SpecieGrimmsnarl? _instance = null;
#nullable restore
        public static SpecieGrimmsnarl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrimmsnarl();
                }
                return _instance;
            }
        }

		public SpecieGrimmsnarl() : base(
			"Grimmsnarl",
			95, // HPs
			120, 65, // Attack & Defense
			95, 75, // Special Attack & Defense
			60			
		) {}
	}


	//Grimmsnarl Pokemon Class
	public class Grimmsnarl : Pokemon
	{

		public Grimmsnarl(string nickname, int level) : base(
			861,
			SpecieGrimmsnarl.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Fairy.Instance			
		) {}

		public Grimmsnarl() : base(
			861,
			SpecieGrimmsnarl.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
	}
}