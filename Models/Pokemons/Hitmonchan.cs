using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hitmonchan Specie to store common natural stats of every {'abilities': ['keen-eye', 'iron-fist', 'inner-focus'], 'base_experience': 159, 'height': 14, 'id': 107, 'moves': ['comet-punch', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'bide', 'metronome', 'swift', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mach-punch', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'revenge', 'brick-break', 'secret-power', 'rock-tomb', 'sky-uppercut', 'bulk-up', 'covet', 'natural-gift', 'feint', 'close-combat', 'fling', 'drain-punch', 'vacuum-wave', 'focus-blast', 'bullet-punch', 'rock-climb', 'stone-edge', 'captivate', 'low-sweep', 'round', 'quick-guard', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'hitmonchan', 'stats': {'hp': 50, 'attack': 105, 'defense': 79, 'special-attack': 35, 'special-defense': 110, 'speed': 76}, 'types': ['fighting'], 'weight': 502, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 0, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'エビワラー', 'roomaji': 'Ebiwalar', 'ko': '홍수몬', 'zh-Hant': '快拳郎', 'fr': 'Tygnon', 'de': 'Nockchan', 'es': 'Hitmonchan', 'it': 'Hitmonchan', 'en': 'Hitmonchan', 'ja': 'エビワラー', 'zh-Hans': '快拳郎'}, 'genera': {'ja-Hrkt': 'パンチポケモン', 'ko': '펀치포켓몬', 'zh-Hant': '拳擊寶可夢', 'fr': 'Pokémon Puncheur', 'de': 'Puncher', 'es': 'Pokémon Puñetazo', 'it': 'Pokémon Tirapugni', 'en': 'Punching Pokémon', 'ja': 'パンチポケモン', 'zh-Hans': '拳击宝可梦'}}
	public class SpecieHitmonchan : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmonchan? _instance = null;
#nullable restore
        public static SpecieHitmonchan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmonchan();
                }
                return _instance;
            }
        }

		public SpecieHitmonchan() : base(
			"Hitmonchan",
			50, // HPs
			105, 79, // Attack & Defense
			35, 110, // Special Attack & Defense
			76			
		) {}
	}


	//Hitmonchan Pokemon Class
	public class Hitmonchan : Pokemon
	{

		public Hitmonchan(string nickname, int level) : base(
			107,
			SpecieHitmonchan.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Hitmonchan() : base(
			107,
			SpecieHitmonchan.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}