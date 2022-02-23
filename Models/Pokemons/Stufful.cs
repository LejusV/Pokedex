using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stufful Specie to store common natural stats of every {'abilities': ['fluffy', 'klutz', 'cute-charm'], 'base_experience': 68, 'height': 5, 'id': 759, 'moves': ['ice-punch', 'thunder-punch', 'swords-dance', 'mega-kick', 'tackle', 'take-down', 'thrash', 'double-edge', 'leer', 'roar', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'flail', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'facade', 'taunt', 'superpower', 'brick-break', 'rock-tomb', 'aerial-ace', 'bulk-up', 'hammer-arm', 'payback', 'fling', 'force-palm', 'focus-blast', 'wide-guard', 'low-sweep', 'round', 'bulldoze', 'work-up', 'confide', 'baby-doll-eyes', 'brutal-swing', 'stomping-tantrum'], 'name': 'stufful', 'stats': {'hp': 70, 'attack': 75, 'defense': 50, 'special-attack': 45, 'special-defense': 50, 'speed': 50}, 'types': ['normal', 'fighting'], 'weight': 68, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 140, 'color': 'pink', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヌイコグマ', 'ko': '포곰곰', 'zh-Hant': '童偶熊', 'fr': 'Nounourson', 'de': 'Velursi', 'es': 'Stufful', 'it': 'Stufful', 'en': 'Stufful', 'ja': 'ヌイコグマ', 'zh-Hans': '童偶熊'}, 'genera': {'ja-Hrkt': 'じたばたポケモン', 'ko': '바둥바둥포켓몬', 'zh-Hant': '抓狂寶可夢', 'fr': 'Pokémon Gigoteur', 'de': 'Wildfang', 'es': 'Pokémon Rabieta', 'it': 'Pokémon Bizzoso', 'en': 'Flailing Pokémon', 'ja': 'じたばたポケモン', 'zh-Hans': '抓狂宝可梦'}}
	public class SpecieStufful : PokemonSpecie
	{
#nullable enable
		private static SpecieStufful? _instance = null;
#nullable restore
        public static SpecieStufful Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStufful();
                }
                return _instance;
            }
        }

		public SpecieStufful() : base(
			"Stufful",
			70, // HPs
			75, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			50			
		) {}
	}


	//Stufful Pokemon Class
	public class Stufful : Pokemon
	{

		public Stufful(string nickname, int level) : base(
			759,
			SpecieStufful.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Fighting.Instance			
		) {}

		public Stufful() : base(
			759,
			SpecieStufful.Instance, // Pokemon Specie
			Normal.Instance, Fighting.Instance			
		) {}
	}
}