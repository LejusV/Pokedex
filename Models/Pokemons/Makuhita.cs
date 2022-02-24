using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Makuhita Specie to store common natural stats of every {'abilities': ['thick-fat', 'guts', 'sheer-force'], 'base_experience': 47, 'height': 10, 'id': 296, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'whirlwind', 'mega-kick', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'surf', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'focus-energy', 'metronome', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'feint-attack', 'belly-drum', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'vital-throw', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'fake-out', 'facade', 'focus-punch', 'smelling-salts', 'helping-hand', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'arm-thrust', 'rock-tomb', 'bulk-up', 'wake-up-slap', 'natural-gift', 'feint', 'close-combat', 'fling', 'force-palm', 'poison-jab', 'vacuum-wave', 'focus-blast', 'bullet-punch', 'rock-climb', 'captivate', 'wide-guard', 'smack-down', 'heavy-slam', 'low-sweep', 'round', 'chip-away', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'makuhita', 'stats': {'hp': 72, 'attack': 60, 'defense': 30, 'special-attack': 20, 'special-defense': 30, 'speed': 25}, 'types': ['fighting'], 'weight': 864, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 180, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'マクノシタ', 'roomaji': 'Makunoshita', 'ko': '마크탕', 'zh-Hant': '幕下力士', 'fr': 'Makuhita', 'de': 'Makuhita', 'es': 'Makuhita', 'it': 'Makuhita', 'en': 'Makuhita', 'ja': 'マクノシタ', 'zh-Hans': '幕下力士'}, 'genera': {'ja-Hrkt': 'こんじょうポケモン', 'ko': '근성포켓몬', 'zh-Hant': '毅力寶可夢', 'fr': 'Pokémon Tenace', 'de': 'Courage', 'es': 'Pokémon Valiente', 'it': 'Pokémon Coraggio', 'en': 'Guts Pokémon', 'ja': 'こんじょうポケモン', 'zh-Hans': '毅力宝可梦'}}
	public class SpecieMakuhita : PokemonSpecie
	{
#nullable enable
		private static SpecieMakuhita? _instance = null;
#nullable restore
        public static SpecieMakuhita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMakuhita();
                }
                return _instance;
            }
        }

		public SpecieMakuhita() : base(
			"Makuhita",
			72, // HPs
			60, 30, // Attack & Defense
			20, 30, // Special Attack & Defense
			25			
		) {}
	}


	//Makuhita Pokemon Class
	public class Makuhita : Pokemon
	{

		public Makuhita(string nickname, int level)
		: base(
				296,
				SpecieMakuhita.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Makuhita(int level)
		: base(
				296,
				SpecieMakuhita.Instance, // Pokemon Specie
				"Makuhita", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Makuhita() : base(
			296,
			SpecieMakuhita.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}