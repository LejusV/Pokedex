using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spritzee Specie to store common natural stats of every {'abilities': ['healer', 'aroma-veil'], 'base_experience': 68, 'height': 2, 'id': 682, 'moves': ['disable', 'thunderbolt', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'torment', 'facade', 'helping-hand', 'wish', 'magic-coat', 'endeavor', 'skill-swap', 'refresh', 'secret-power', 'aromatherapy', 'odor-sleuth', 'covet', 'calm-mind', 'gyro-ball', 'energy-ball', 'nasty-plot', 'flash-cannon', 'trick-room', 'captivate', 'charge-beam', 'after-you', 'round', 'echoed-voice', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'fairy-wind', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'spritzee', 'stats': {'hp': 78, 'attack': 52, 'defense': 60, 'special-attack': 63, 'special-defense': 65, 'speed': 23}, 'types': ['fairy'], 'weight': 5, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'pink', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'シュシュプ', 'ko': '슈쁘', 'zh-Hant': '粉香香', 'fr': 'Fluvetin', 'de': 'Parfi', 'es': 'Spritzee', 'it': 'Spritzee', 'en': 'Spritzee', 'ja': 'シュシュプ', 'zh-Hans': '粉香香'}, 'genera': {'ja-Hrkt': 'こうすいポケモン', 'ko': '향수포켓몬', 'zh-Hant': '香水寶可夢', 'fr': 'Pokémon Fragrance', 'de': 'Parfüm', 'es': 'Pokémon Aroma', 'it': 'Pokémon Profumo', 'en': 'Perfume Pokémon', 'ja': 'こうすいポケモン', 'zh-Hans': '香水宝可梦'}}
	public class SpecieSpritzee : PokemonSpecie
	{
#nullable enable
		private static SpecieSpritzee? _instance = null;
#nullable restore
        public static SpecieSpritzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpritzee();
                }
                return _instance;
            }
        }

		public SpecieSpritzee() : base(
			"Spritzee",
			78, // HPs
			52, 60, // Attack & Defense
			63, 65, // Special Attack & Defense
			23			
		) {}
	}


	//Spritzee Pokemon Class
	public class Spritzee : Pokemon
	{

		public Spritzee(string nickname, int level)
		: base(
				682,
				SpecieSpritzee.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spritzee() : base(
			682,
			SpecieSpritzee.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}