using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chewtle Specie to store common natural stats of every {'abilities': ['strong-jaw', 'shell-armor', 'swift-swim'], 'base_experience': 57, 'height': 3, 'id': 833, 'moves': [], 'name': 'chewtle', 'stats': {'hp': 50, 'attack': 64, 'defense': 50, 'special-attack': 38, 'special-defense': 38, 'speed': 44}, 'types': ['water'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'カムカメ', 'ko': '깨물부기', 'zh-Hant': '咬咬龜', 'fr': 'Khélocrok', 'de': 'Kamehaps', 'es': 'Chewtle', 'it': 'Chewtle', 'en': 'Chewtle', 'ja': 'カムカメ', 'zh-Hans': '咬咬龟 '}, 'genera': {'ja-Hrkt': 'くいつきポケモン', 'ko': '물고늘어지기포켓몬', 'zh-Hant': '咬住寶可夢', 'fr': 'Pokémon Mordillage', 'de': 'Schnapp', 'es': 'Pokémon Mordedura', 'it': 'Pokémon Mordace', 'en': 'Snapping Pokémon', 'ja': 'くいつきポケモン', 'zh-Hans': '咬住宝可梦'}}
	public class SpecieChewtle : PokemonSpecie
	{
#nullable enable
		private static SpecieChewtle? _instance = null;
#nullable restore
        public static SpecieChewtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChewtle();
                }
                return _instance;
            }
        }

		public SpecieChewtle() : base(
			"Chewtle",
			50, // HPs
			64, 50, // Attack & Defense
			38, 38, // Special Attack & Defense
			44			
		) {}
	}


	//Chewtle Pokemon Class
	public class Chewtle : Pokemon
	{

		public Chewtle(string nickname, int level) : base(
			833,
			SpecieChewtle.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Chewtle() : base(
			833,
			SpecieChewtle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}