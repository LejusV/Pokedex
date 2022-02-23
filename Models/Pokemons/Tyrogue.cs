using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tyrogue Specie to store common natural stats of every {'abilities': ['guts', 'steadfast', 'vital-spirit'], 'base_experience': 42, 'height': 7, 'id': 236, 'moves': ['mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'toxic', 'mimic', 'double-team', 'swift', 'high-jump-kick', 'rest', 'rock-slide', 'substitute', 'thief', 'mind-reader', 'snore', 'curse', 'protect', 'mach-punch', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'rapid-spin', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'fake-out', 'uproar', 'facade', 'helping-hand', 'role-play', 'brick-break', 'secret-power', 'bulk-up', 'covet', 'natural-gift', 'feint', 'vacuum-wave', 'bullet-punch', 'captivate', 'low-sweep', 'round', 'ally-switch', 'retaliate', 'bulldoze', 'work-up', 'confide'], 'name': 'tyrogue', 'stats': {'hp': 35, 'attack': 35, 'defense': 35, 'special-attack': 35, 'special-defense': 35, 'speed': 35}, 'types': ['fighting'], 'weight': 210, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 0, 'capture_rate': 75, 'color': 'purple', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'バルキー', 'roomaji': 'Balkie', 'ko': '배루키', 'zh-Hant': '無畏小子', 'fr': 'Debugant', 'de': 'Rabauz', 'es': 'Tyrogue', 'it': 'Tyrogue', 'en': 'Tyrogue', 'ja': 'バルキー', 'zh-Hans': '无畏小子'}, 'genera': {'ja-Hrkt': 'けんかポケモン', 'ko': '싸움포켓몬', 'zh-Hant': '打鬥寶可夢', 'fr': 'Pokémon Bagarreur', 'de': 'Racker', 'es': 'Pokémon Peleón', 'it': 'Pokémon Baruffa', 'en': 'Scuffle Pokémon', 'ja': 'けんかポケモン', 'zh-Hans': '打斗宝可梦'}}
	public class SpecieTyrogue : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrogue? _instance = null;
#nullable restore
        public static SpecieTyrogue Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrogue();
                }
                return _instance;
            }
        }

		public SpecieTyrogue() : base(
			"Tyrogue",
			35, // HPs
			35, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
			35			
		) {}
	}


	//Tyrogue Pokemon Class
	public class Tyrogue : Pokemon
	{

		public Tyrogue(string nickname, int level) : base(
			236,
			SpecieTyrogue.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Tyrogue() : base(
			236,
			SpecieTyrogue.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}