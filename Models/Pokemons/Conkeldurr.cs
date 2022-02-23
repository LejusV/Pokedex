using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Conkeldurr Specie to store common natural stats of every {'abilities': ['guts', 'sheer-force', 'iron-fist'], 'base_experience': 227, 'height': 14, 'id': 534, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'leer', 'hyper-beam', 'low-kick', 'strength', 'rock-throw', 'earthquake', 'dig', 'toxic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'block', 'bulk-up', 'wake-up-slap', 'hammer-arm', 'payback', 'fling', 'poison-jab', 'drain-punch', 'focus-blast', 'giga-impact', 'stone-edge', 'grass-knot', 'smack-down', 'low-sweep', 'round', 'chip-away', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'conkeldurr', 'stats': {'hp': 105, 'attack': 140, 'defense': 95, 'special-attack': 55, 'special-defense': 65, 'speed': 45}, 'types': ['fighting'], 'weight': 870, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ローブシン', 'ko': '노보청', 'zh-Hant': '修建老匠', 'fr': 'Bétochef', 'de': 'Meistagrif', 'es': 'Conkeldurr', 'it': 'Conkeldurr', 'en': 'Conkeldurr', 'ja': 'ローブシン', 'zh-Hans': '修建老匠'}, 'genera': {'ja-Hrkt': 'きんこつポケモン', 'ko': '근골포켓몬', 'zh-Hant': '筋骨寶可夢', 'fr': 'Pokémon Costaud', 'de': 'Muskel', 'es': 'Pokémon Musculoso', 'it': 'Pokémon Forzaimmane', 'en': 'Muscular Pokémon', 'ja': 'きんこつポケモン', 'zh-Hans': '筋骨宝可梦'}}
	public class SpecieConkeldurr : PokemonSpecie
	{
#nullable enable
		private static SpecieConkeldurr? _instance = null;
#nullable restore
        public static SpecieConkeldurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieConkeldurr();
                }
                return _instance;
            }
        }

		public SpecieConkeldurr() : base(
			"Conkeldurr",
			105, // HPs
			140, 95, // Attack & Defense
			55, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Conkeldurr Pokemon Class
	public class Conkeldurr : Pokemon
	{

		public Conkeldurr(string nickname, int level) : base(
			534,
			SpecieConkeldurr.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Conkeldurr() : base(
			534,
			SpecieConkeldurr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}