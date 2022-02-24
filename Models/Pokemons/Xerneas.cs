using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Xerneas Specie to store common natural stats of every {'abilities': ['fairy-aura'], 'base_experience': 306, 'height': 30, 'id': 716, 'moves': ['cut', 'take-down', 'roar', 'aurora-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'outrage', 'swagger', 'sleep-talk', 'return', 'frustration', 'megahorn', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'hail', 'facade', 'nature-power', 'ingrain', 'endeavor', 'secret-power', 'hyper-voice', 'aromatherapy', 'block', 'calm-mind', 'gravity', 'close-combat', 'night-slash', 'focus-blast', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'grass-knot', 'wonder-room', 'psyshock', 'round', 'echoed-voice', 'heal-pulse', 'horn-leech', 'misty-terrain', 'moonblast', 'confide', 'geomancy', 'dazzling-gleam'], 'name': 'xerneas', 'stats': {'hp': 126, 'attack': 131, 'defense': 95, 'special-attack': 131, 'special-defense': 98, 'speed': 99}, 'types': ['fairy'], 'weight': 2150, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ゼルネアス', 'ko': '제르네아스', 'zh-Hant': '哲爾尼亞斯', 'fr': 'Xerneas', 'de': 'Xerneas', 'es': 'Xerneas', 'it': 'Xerneas', 'en': 'Xerneas', 'ja': 'ゼルネアス', 'zh-Hans': '哲尔尼亚斯'}, 'genera': {'ja-Hrkt': 'せいめいポケモン', 'ko': '생명포켓몬', 'zh-Hant': '生命寶可夢', 'fr': 'Pokémon Existence', 'de': 'Leben', 'es': 'Pokémon Creación', 'it': 'Pokémon Creazione', 'en': 'Life Pokémon', 'ja': 'せいめいポケモン', 'zh-Hans': '生命宝可梦'}}
	public class SpecieXerneas : PokemonSpecie
	{
#nullable enable
		private static SpecieXerneas? _instance = null;
#nullable restore
        public static SpecieXerneas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXerneas();
                }
                return _instance;
            }
        }

		public SpecieXerneas() : base(
			"Xerneas",
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99			
		) {}
	}


	//Xerneas Pokemon Class
	public class Xerneas : Pokemon
	{

		public Xerneas(string nickname, int level)
		: base(
				716,
				SpecieXerneas.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Xerneas(int level)
		: base(
				716,
				SpecieXerneas.Instance, // Pokemon Specie
				"Xerneas", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Xerneas() : base(
			716,
			SpecieXerneas.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}