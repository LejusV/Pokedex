using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crabrawler Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'iron-fist', 'anger-point'], 'base_experience': 68, 'height': 6, 'id': 739, 'moves': ['leer', 'bubble-beam', 'earthquake', 'toxic', 'double-team', 'amnesia', 'bubble', 'dizzy-punch', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'thief', 'reversal', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'superpower', 'brick-break', 'endeavor', 'rock-tomb', 'iron-defense', 'bulk-up', 'close-combat', 'payback', 'fling', 'focus-blast', 'stone-edge', 'wide-guard', 'round', 'scald', 'bulldoze', 'frost-breath', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'crabrawler', 'stats': {'hp': 47, 'attack': 82, 'defense': 57, 'special-attack': 42, 'special-defense': 47, 'speed': 63}, 'types': ['fighting'], 'weight': 70, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'purple', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'マケンカニ', 'ko': '오기지게', 'zh-Hant': '好勝蟹', 'fr': 'Crabagarre', 'de': 'Krabbox', 'es': 'Crabrawler', 'it': 'Crabrawler', 'en': 'Crabrawler', 'ja': 'マケンカニ', 'zh-Hans': '好胜蟹'}, 'genera': {'ja-Hrkt': 'けんとうポケモン', 'ko': '권투포켓몬', 'zh-Hant': '拳鬥寶可夢', 'fr': 'Pokémon Boxeur', 'de': 'Boxkampf', 'es': 'Pokémon Púgil', 'it': 'Pokémon Pugile', 'en': 'Boxing Pokémon', 'ja': 'けんとうポケモン', 'zh-Hans': '拳斗宝可梦'}}
	public class SpecieCrabrawler : PokemonSpecie
	{
#nullable enable
		private static SpecieCrabrawler? _instance = null;
#nullable restore
        public static SpecieCrabrawler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrabrawler();
                }
                return _instance;
            }
        }

		public SpecieCrabrawler() : base(
			"Crabrawler",
			47, // HPs
			82, 57, // Attack & Defense
			42, 47, // Special Attack & Defense
			63			
		) {}
	}


	//Crabrawler Pokemon Class
	public class Crabrawler : Pokemon
	{

		public Crabrawler(string nickname, int level) : base(
			739,
			SpecieCrabrawler.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Crabrawler() : base(
			739,
			SpecieCrabrawler.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}