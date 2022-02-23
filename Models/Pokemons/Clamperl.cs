using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clamperl Specie to store common natural stats of every {'abilities': ['shell-armor', 'rattled'], 'base_experience': 69, 'height': 4, 'id': 366, 'moves': ['body-slam', 'double-edge', 'supersonic', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'toxic', 'mimic', 'double-team', 'confuse-ray', 'barrier', 'waterfall', 'clamp', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'refresh', 'secret-power', 'dive', 'mud-sport', 'muddy-water', 'iron-defense', 'water-pulse', 'brine', 'natural-gift', 'aqua-ring', 'captivate', 'round', 'scald', 'shell-smash', 'confide'], 'name': 'clamperl', 'stats': {'hp': 35, 'attack': 64, 'defense': 85, 'special-attack': 74, 'special-defense': 55, 'speed': 32}, 'types': ['water'], 'weight': 525, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'ball', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'パールル', 'roomaji': 'Pearlulu', 'ko': '진주몽', 'zh-Hant': '珍珠貝', 'fr': 'Coquiperl', 'de': 'Perlu', 'es': 'Clamperl', 'it': 'Clamperl', 'en': 'Clamperl', 'ja': 'パールル', 'zh-Hans': '珍珠贝'}, 'genera': {'ja-Hrkt': '２まいがいポケモン', 'ko': '두조개포켓몬', 'zh-Hant': '雙殼貝寶可夢', 'fr': 'Pokémon Bivalve', 'de': 'Muschel', 'es': 'Pokémon Bivalvo', 'it': 'Pokémon Bivalve', 'en': 'Bivalve Pokémon', 'ja': '２まいがいポケモン', 'zh-Hans': '双壳贝宝可梦'}}
	public class SpecieClamperl : PokemonSpecie
	{
#nullable enable
		private static SpecieClamperl? _instance = null;
#nullable restore
        public static SpecieClamperl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClamperl();
                }
                return _instance;
            }
        }

		public SpecieClamperl() : base(
			"Clamperl",
			35, // HPs
			64, 85, // Attack & Defense
			74, 55, // Special Attack & Defense
			32			
		) {}
	}


	//Clamperl Pokemon Class
	public class Clamperl : Pokemon
	{

		public Clamperl(string nickname, int level) : base(
			366,
			SpecieClamperl.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Clamperl() : base(
			366,
			SpecieClamperl.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}