using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gigalith Specie to store common natural stats of every {'abilities': ['sturdy', 'sand-stream', 'sand-force'], 'base_experience': 232, 'height': 17, 'id': 526, 'moves': ['sand-attack', 'headbutt', 'tackle', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'harden', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'facade', 'nature-power', 'superpower', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'gravity', 'rock-polish', 'power-gem', 'earth-power', 'giga-impact', 'flash-cannon', 'iron-head', 'stone-edge', 'stealth-rock', 'smack-down', 'round', 'bulldoze', 'confide'], 'name': 'gigalith', 'stats': {'hp': 85, 'attack': 135, 'defense': 130, 'special-attack': 60, 'special-defense': 80, 'speed': 25}, 'types': ['rock'], 'weight': 2600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ギガイアス', 'ko': '기가이어스', 'zh-Hant': '龐岩怪', 'fr': 'Gigalithe', 'de': 'Brockoloss', 'es': 'Gigalith', 'it': 'Gigalith', 'en': 'Gigalith', 'ja': 'ギガイアス', 'zh-Hans': '庞岩怪'}, 'genera': {'ja-Hrkt': 'こうあつポケモン', 'ko': '고압포켓몬', 'zh-Hant': '高壓寶可夢', 'fr': 'Pokémon Surpression', 'de': 'Kompression', 'es': 'Pokémon Presurizado', 'it': 'Pokémon Pressionalta', 'en': 'Compressed Pokémon', 'ja': 'こうあつポケモン', 'zh-Hans': '高压宝可梦'}}
	public class SpecieGigalith : PokemonSpecie
	{
#nullable enable
		private static SpecieGigalith? _instance = null;
#nullable restore
        public static SpecieGigalith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGigalith();
                }
                return _instance;
            }
        }

		public SpecieGigalith() : base(
			"Gigalith",
			85, // HPs
			135, 130, // Attack & Defense
			60, 80, // Special Attack & Defense
			25			
		) {}
	}


	//Gigalith Pokemon Class
	public class Gigalith : Pokemon
	{

		public Gigalith(string nickname, int level)
		: base(
				526,
				SpecieGigalith.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gigalith(int level)
		: base(
				526,
				SpecieGigalith.Instance, // Pokemon Specie
				"Gigalith", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gigalith() : base(
			526,
			SpecieGigalith.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}