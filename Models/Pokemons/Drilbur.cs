using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drilbur Specie to store common natural stats of every {'abilities': ['sand-rush', 'sand-force', 'mold-breaker'], 'base_experience': 66, 'height': 3, 'id': 529, 'moves': ['scratch', 'swords-dance', 'cut', 'submission', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'double-team', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'metal-claw', 'hidden-power', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'mud-sport', 'crush-claw', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'fling', 'poison-jab', 'x-scissor', 'earth-power', 'shadow-claw', 'rock-climb', 'stealth-rock', 'hone-claws', 'round', 'bulldoze', 'drill-run', 'confide'], 'name': 'drilbur', 'stats': {'hp': 60, 'attack': 85, 'defense': 40, 'special-attack': 30, 'special-defense': 45, 'speed': 68}, 'types': ['ground'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'モグリュー', 'ko': '두더류', 'zh-Hant': '螺釘地鼠', 'fr': 'Rototaupe', 'de': 'Rotomurf', 'es': 'Drilbur', 'it': 'Drilbur', 'en': 'Drilbur', 'ja': 'モグリュー', 'zh-Hans': '螺钉地鼠'}, 'genera': {'ja-Hrkt': 'もぐらポケモン', 'ko': '두더지포켓몬', 'zh-Hant': '鼴鼠寶可夢', 'fr': 'Pokémon Taupe', 'de': 'Maulwurf', 'es': 'Pokémon Topo', 'it': 'Pokémon Talpa', 'en': 'Mole Pokémon', 'ja': 'もぐらポケモン', 'zh-Hans': '鼹鼠宝可梦'}}
	public class SpecieDrilbur : PokemonSpecie
	{
#nullable enable
		private static SpecieDrilbur? _instance = null;
#nullable restore
        public static SpecieDrilbur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrilbur();
                }
                return _instance;
            }
        }

		public SpecieDrilbur() : base(
			"Drilbur",
			60, // HPs
			85, 40, // Attack & Defense
			30, 45, // Special Attack & Defense
			68			
		) {}
	}


	//Drilbur Pokemon Class
	public class Drilbur : Pokemon
	{

		public Drilbur(string nickname, int level)
		: base(
				529,
				SpecieDrilbur.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drilbur(int level)
		: base(
				529,
				SpecieDrilbur.Instance, // Pokemon Specie
				"Drilbur", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drilbur() : base(
			529,
			SpecieDrilbur.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}