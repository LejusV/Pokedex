using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lopunny Specie to store common natural stats of every {'abilities': ['cute-charm', 'klutz', 'limber'], 'base_experience': 168, 'height': 12, 'id': 428, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'jump-kick', 'headbutt', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'defense-curl', 'swift', 'high-jump-kick', 'dizzy-punch', 'splash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'foresight', 'endure', 'charm', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'helping-hand', 'magic-coat', 'endeavor', 'secret-power', 'hyper-voice', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'healing-wish', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'focus-blast', 'giga-impact', 'captivate', 'grass-knot', 'charge-beam', 'low-sweep', 'entrainment', 'after-you', 'round', 'retaliate', 'work-up', 'rototiller', 'confide', 'baby-doll-eyes', 'power-up-punch', 'brutal-swing'], 'name': 'lopunny', 'stats': {'hp': 65, 'attack': 76, 'defense': 84, 'special-attack': 54, 'special-defense': 96, 'speed': 105}, 'types': ['normal'], 'weight': 333, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ミミロップ', 'roomaji': 'Mimilop', 'ko': '이어롭', 'zh-Hant': '長耳兔', 'fr': 'Lockpin', 'de': 'Schlapor', 'es': 'Lopunny', 'it': 'Lopunny', 'en': 'Lopunny', 'ja': 'ミミロップ', 'zh-Hans': '长耳兔'}, 'genera': {'ja-Hrkt': 'うさぎポケモン', 'ko': '토끼포켓몬', 'zh-Hant': '兔子寶可夢', 'fr': 'Pokémon Lapin', 'de': 'Hase', 'es': 'Pokémon Conejo', 'it': 'Pokémon Coniglio', 'en': 'Rabbit Pokémon', 'ja': 'うさぎポケモン', 'zh-Hans': '兔子宝可梦'}}
	public class SpecieLopunny : PokemonSpecie
	{
#nullable enable
		private static SpecieLopunny? _instance = null;
#nullable restore
        public static SpecieLopunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLopunny();
                }
                return _instance;
            }
        }

		public SpecieLopunny() : base(
			"Lopunny",
			65, // HPs
			76, 84, // Attack & Defense
			54, 96, // Special Attack & Defense
			105			
		) {}
	}


	//Lopunny Pokemon Class
	public class Lopunny : Pokemon
	{

		public Lopunny(string nickname, int level)
		: base(
				428,
				SpecieLopunny.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lopunny(int level)
		: base(
				428,
				SpecieLopunny.Instance, // Pokemon Specie
				"Lopunny", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lopunny() : base(
			428,
			SpecieLopunny.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}