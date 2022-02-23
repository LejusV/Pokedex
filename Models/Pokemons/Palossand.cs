using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Palossand Specie to store common natural stats of every {'abilities': ['water-compaction', 'sand-veil'], 'base_experience': 168, 'height': 13, 'id': 770, 'moves': ['sand-attack', 'absorb', 'mega-drain', 'earthquake', 'toxic', 'psychic', 'hypnosis', 'double-team', 'harden', 'rest', 'rock-slide', 'substitute', 'protect', 'sludge-bomb', 'sandstorm', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'shadow-ball', 'facade', 'astonish', 'rock-tomb', 'sand-tomb', 'iron-defense', 'embargo', 'fling', 'rock-polish', 'energy-ball', 'earth-power', 'giga-impact', 'stone-edge', 'round', 'quash', 'bulldoze', 'confide', 'infestation', 'shore-up'], 'name': 'palossand', 'stats': {'hp': 85, 'attack': 75, 'defense': 110, 'special-attack': 100, 'special-defense': 75, 'speed': 35}, 'types': ['ghost', 'ground'], 'weight': 2500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'シロデスナ', 'ko': '모래성이당', 'zh-Hant': '噬沙堡爺', 'fr': 'Trépassable', 'de': 'Colossand', 'es': 'Palossand', 'it': 'Palossand', 'en': 'Palossand', 'ja': 'シロデスナ', 'zh-Hans': '噬沙堡爷'}, 'genera': {'ja-Hrkt': 'すなのしろポケモン', 'ko': '모래성포켓몬', 'zh-Hant': '沙堡寶可夢', 'fr': 'Pokémon Châtod’Sable', 'de': 'Sandschloss', 'es': 'Pokémon Castiarena', 'it': 'Pokémon Castelsabbia', 'en': 'Sand Castle Pokémon', 'ja': 'すなのしろポケモン', 'zh-Hans': '沙堡宝可梦'}}
	public class SpeciePalossand : PokemonSpecie
	{
#nullable enable
		private static SpeciePalossand? _instance = null;
#nullable restore
        public static SpeciePalossand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalossand();
                }
                return _instance;
            }
        }

		public SpeciePalossand() : base(
			"Palossand",
			85, // HPs
			75, 110, // Attack & Defense
			100, 75, // Special Attack & Defense
			35			
		) {}
	}


	//Palossand Pokemon Class
	public class Palossand : Pokemon
	{

		public Palossand(string nickname, int level) : base(
			770,
			SpeciePalossand.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance, Ground.Instance			
		) {}

		public Palossand() : base(
			770,
			SpeciePalossand.Instance, // Pokemon Specie
			Ghost.Instance, Ground.Instance			
		) {}
	}
}