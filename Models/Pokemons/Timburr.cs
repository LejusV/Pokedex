using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Timburr Specie to store common natural stats of every {'abilities': ['guts', 'sheer-force', 'iron-fist'], 'base_experience': 61, 'height': 6, 'id': 532, 'moves': ['pound', 'comet-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'leer', 'low-kick', 'counter', 'strength', 'rock-throw', 'dig', 'toxic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'mach-punch', 'scary-face', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'smelling-salts', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'block', 'bulk-up', 'wake-up-slap', 'hammer-arm', 'payback', 'fling', 'force-palm', 'poison-jab', 'drain-punch', 'focus-blast', 'stone-edge', 'grass-knot', 'wide-guard', 'smack-down', 'low-sweep', 'round', 'chip-away', 'retaliate', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'timburr', 'stats': {'hp': 75, 'attack': 80, 'defense': 55, 'special-attack': 25, 'special-defense': 35, 'speed': 35}, 'types': ['fighting'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 180, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ドッコラー', 'ko': '으랏차', 'zh-Hant': '搬運小匠', 'fr': 'Charpenti', 'de': 'Praktibalk', 'es': 'Timburr', 'it': 'Timburr', 'en': 'Timburr', 'ja': 'ドッコラー', 'zh-Hans': '搬运小匠'}, 'genera': {'ja-Hrkt': 'きんこつポケモン', 'ko': '근골포켓몬', 'zh-Hant': '筋骨寶可夢', 'fr': 'Pokémon Costaud', 'de': 'Muskel', 'es': 'Pokémon Musculoso', 'it': 'Pokémon Forzaimmane', 'en': 'Muscular Pokémon', 'ja': 'きんこつポケモン', 'zh-Hans': '筋骨宝可梦'}}
	public class SpecieTimburr : PokemonSpecie
	{
#nullable enable
		private static SpecieTimburr? _instance = null;
#nullable restore
        public static SpecieTimburr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTimburr();
                }
                return _instance;
            }
        }

		public SpecieTimburr() : base(
			"Timburr",
			75, // HPs
			80, 55, // Attack & Defense
			25, 35, // Special Attack & Defense
			35			
		) {}
	}


	//Timburr Pokemon Class
	public class Timburr : Pokemon
	{

		public Timburr(string nickname, int level) : base(
			532,
			SpecieTimburr.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Timburr() : base(
			532,
			SpecieTimburr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}