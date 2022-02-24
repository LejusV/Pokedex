using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Minior-Red-Meteor Specie to store common natural stats of every {'abilities': ['shields-down'], 'base_experience': 154, 'height': 3, 'id': 774, 'moves': ['tackle', 'take-down', 'double-edge', 'hyper-beam', 'solar-beam', 'earthquake', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'swift', 'explosion', 'rest', 'rock-slide', 'substitute', 'protect', 'sandstorm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'psych-up', 'ancient-power', 'facade', 'rock-tomb', 'cosmic-power', 'calm-mind', 'gyro-ball', 'u-turn', 'rock-polish', 'power-gem', 'giga-impact', 'stone-edge', 'stealth-rock', 'charge-beam', 'autotomize', 'round', 'shell-smash', 'acrobatics', 'bulldoze', 'confide', 'dazzling-gleam'], 'name': 'minior-red-meteor', 'stats': {'hp': 60, 'attack': 60, 'defense': 100, 'special-attack': 60, 'special-defense': 100, 'speed': 60}, 'types': ['rock', 'flying'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 30, 'color': 'brown', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'メテノ', 'ko': '메테노', 'zh-Hant': '小隕星', 'fr': 'Météno', 'de': 'Meteno', 'es': 'Minior', 'it': 'Minior', 'en': 'Minior', 'ja': 'メテノ', 'zh-Hans': '小陨星'}, 'genera': {'ja-Hrkt': 'ながれぼしポケモン', 'ko': '유성포켓몬', 'zh-Hant': '流星寶可夢', 'fr': 'Pokémon Météore', 'de': 'Meteor', 'es': 'Pokémon Meteoro', 'it': 'Pokémon Meteora', 'en': 'Meteor Pokémon', 'ja': 'ながれぼしポケモン', 'zh-Hans': '流星宝可梦'}}
	public class SpecieMiniorRedMeteor : PokemonSpecie
	{
#nullable enable
		private static SpecieMiniorRedMeteor? _instance = null;
#nullable restore
        public static SpecieMiniorRedMeteor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMiniorRedMeteor();
                }
                return _instance;
            }
        }

		public SpecieMiniorRedMeteor() : base(
			"Minior-Red-Meteor",
			60, // HPs
			60, 100, // Attack & Defense
			60, 100, // Special Attack & Defense
			60			
		) {}
	}


	//Minior-Red-Meteor Pokemon Class
	public class MiniorRedMeteor : Pokemon
	{

		public MiniorRedMeteor(string nickname, int level)
		: base(
				774,
				SpecieMiniorRedMeteor.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MiniorRedMeteor() : base(
			774,
			SpecieMiniorRedMeteor.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
	}
}