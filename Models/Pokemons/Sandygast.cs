using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandygast Specie to store common natural stats of every {'abilities': ['water-compaction', 'sand-veil'], 'base_experience': 64, 'height': 5, 'id': 769, 'moves': ['sand-attack', 'absorb', 'mega-drain', 'earthquake', 'toxic', 'psychic', 'hypnosis', 'double-team', 'harden', 'amnesia', 'rest', 'rock-slide', 'substitute', 'curse', 'protect', 'destiny-bond', 'sandstorm', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'ancient-power', 'shadow-ball', 'stockpile', 'spit-up', 'swallow', 'facade', 'astonish', 'rock-tomb', 'sand-tomb', 'iron-defense', 'rock-polish', 'energy-ball', 'earth-power', 'stone-edge', 'round', 'bulldoze', 'confide', 'infestation', 'shore-up'], 'name': 'sandygast', 'stats': {'hp': 55, 'attack': 55, 'defense': 80, 'special-attack': 70, 'special-defense': 45, 'speed': 15}, 'types': ['ghost', 'ground'], 'weight': 700, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 140, 'color': 'brown', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'スナバァ', 'ko': '모래꿍', 'zh-Hant': '沙丘娃', 'fr': 'Bacabouh', 'de': 'Sankabuh', 'es': 'Sandygast', 'it': 'Sandygast', 'en': 'Sandygast', 'ja': 'スナバァ', 'zh-Hans': '沙丘娃'}, 'genera': {'ja-Hrkt': 'すなやまポケモン', 'ko': '모래산포켓몬', 'zh-Hant': '沙丘寶可夢', 'fr': 'Pokémon Pâtéd’Sable', 'de': 'Sandhaufen', 'es': 'Pokémon Montearena', 'it': 'Pokémon Montesabbia', 'en': 'Sand Heap Pokémon', 'ja': 'すなやまポケモン', 'zh-Hans': '沙丘宝可梦'}}
	public class SpecieSandygast : PokemonSpecie
	{
#nullable enable
		private static SpecieSandygast? _instance = null;
#nullable restore
        public static SpecieSandygast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandygast();
                }
                return _instance;
            }
        }

		public SpecieSandygast() : base(
			"Sandygast",
			55, // HPs
			55, 80, // Attack & Defense
			70, 45, // Special Attack & Defense
			15			
		) {}
	}


	//Sandygast Pokemon Class
	public class Sandygast : Pokemon
	{

		public Sandygast(string nickname, int level)
		: base(
				769,
				SpecieSandygast.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandygast() : base(
			769,
			SpecieSandygast.Instance, // Pokemon Specie
			Ghost.Instance, Ground.Instance			
		) {}
	}
}