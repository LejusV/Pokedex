using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gurdurr Specie to store common natural stats of every {'abilities': ['guts', 'sheer-force', 'iron-fist'], 'base_experience': 142, 'height': 12, 'id': 533, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'leer', 'low-kick', 'strength', 'rock-throw', 'dig', 'toxic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'block', 'bulk-up', 'wake-up-slap', 'hammer-arm', 'payback', 'fling', 'poison-jab', 'drain-punch', 'focus-blast', 'stone-edge', 'grass-knot', 'smack-down', 'low-sweep', 'round', 'chip-away', 'retaliate', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'gurdurr', 'stats': {'hp': 85, 'attack': 105, 'defense': 85, 'special-attack': 40, 'special-defense': 50, 'speed': 40}, 'types': ['fighting'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 90, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ドテッコツ', 'ko': '토쇠골', 'zh-Hant': '鐵骨土人', 'fr': 'Ouvrifier', 'de': 'Strepoli', 'es': 'Gurdurr', 'it': 'Gurdurr', 'en': 'Gurdurr', 'ja': 'ドテッコツ', 'zh-Hans': '铁骨土人'}, 'genera': {'ja-Hrkt': 'きんこつポケモン', 'ko': '근골포켓몬', 'zh-Hant': '筋骨寶可夢', 'fr': 'Pokémon Costaud', 'de': 'Muskel', 'es': 'Pokémon Musculoso', 'it': 'Pokémon Forzaimmane', 'en': 'Muscular Pokémon', 'ja': 'きんこつポケモン', 'zh-Hans': '筋骨宝可梦'}}
	public class SpecieGurdurr : PokemonSpecie
	{
#nullable enable
		private static SpecieGurdurr? _instance = null;
#nullable restore
        public static SpecieGurdurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGurdurr();
                }
                return _instance;
            }
        }

		public SpecieGurdurr() : base(
			"Gurdurr",
			85, // HPs
			105, 85, // Attack & Defense
			40, 50, // Special Attack & Defense
			40			
		) {}
	}


	//Gurdurr Pokemon Class
	public class Gurdurr : Pokemon
	{

		public Gurdurr(string nickname, int level)
		: base(
				533,
				SpecieGurdurr.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gurdurr(int level)
		: base(
				533,
				SpecieGurdurr.Instance, // Pokemon Specie
				"Gurdurr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gurdurr() : base(
			533,
			SpecieGurdurr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}