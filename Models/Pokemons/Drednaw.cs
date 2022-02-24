using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drednaw Specie to store common natural stats of every {'abilities': ['strong-jaw', 'shell-armor', 'swift-swim'], 'base_experience': 170, 'height': 10, 'id': 834, 'moves': [], 'name': 'drednaw', 'stats': {'hp': 90, 'attack': 115, 'defense': 90, 'special-attack': 48, 'special-defense': 68, 'speed': 74}, 'types': ['water', 'rock'], 'weight': 1155, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'カジリガメ', 'ko': '갈가부기', 'zh-Hant': '暴噬龜', 'fr': 'Torgamord', 'de': 'Kamalm', 'es': 'Drednaw', 'it': 'Drednaw', 'en': 'Drednaw', 'ja': 'カジリガメ', 'zh-Hans': '暴噬龟'}, 'genera': {'ja-Hrkt': 'かみつきポケモン', 'ko': '물어뜯기포켓몬', 'zh-Hant': '緊咬寶可夢', 'fr': 'Pokémon Morsure', 'de': 'Biss', 'es': 'Pokémon Mordisco', 'it': 'Pokémon Morso', 'en': 'Bite Pokémon', 'ja': 'かみつきポケモン', 'zh-Hans': '紧咬宝可梦'}}
	public class SpecieDrednaw : PokemonSpecie
	{
#nullable enable
		private static SpecieDrednaw? _instance = null;
#nullable restore
        public static SpecieDrednaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrednaw();
                }
                return _instance;
            }
        }

		public SpecieDrednaw() : base(
			"Drednaw",
			90, // HPs
			115, 90, // Attack & Defense
			48, 68, // Special Attack & Defense
			74			
		) {}
	}


	//Drednaw Pokemon Class
	public class Drednaw : Pokemon
	{

		public Drednaw(string nickname, int level)
		: base(
				834,
				SpecieDrednaw.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drednaw(int level)
		: base(
				834,
				SpecieDrednaw.Instance, // Pokemon Specie
				"Drednaw", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drednaw() : base(
			834,
			SpecieDrednaw.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
	}
}