using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ambipom Specie to store common natural stats of every {'abilities': ['technician', 'pickup', 'skill-link'], 'base_experience': 169, 'height': 12, 'id': 424, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'sand-attack', 'headbutt', 'tail-whip', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'screech', 'double-team', 'swift', 'dream-eater', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'mud-slap', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'taunt', 'role-play', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'astonish', 'tickle', 'aerial-ace', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'payback', 'fling', 'last-resort', 'seed-bomb', 'giga-impact', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'captivate', 'grass-knot', 'double-hit', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'acrobatics', 'retaliate', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'ambipom', 'stats': {'hp': 75, 'attack': 100, 'defense': 66, 'special-attack': 60, 'special-defense': 66, 'speed': 115}, 'types': ['normal'], 'weight': 203, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'エテボース', 'roomaji': 'Eteboth', 'ko': '겟핸보숭', 'zh-Hant': '雙尾怪手', 'fr': 'Capidextre', 'de': 'Ambidiffel', 'es': 'Ambipom', 'it': 'Ambipom', 'en': 'Ambipom', 'ja': 'エテボース', 'zh-Hans': '双尾怪手'}, 'genera': {'ja-Hrkt': 'おながポケモン', 'ko': '긴꼬리포켓몬', 'zh-Hant': '長尾寶可夢', 'fr': 'Pokémon Longqueue', 'de': 'Langschweif', 'es': 'Pokémon Cola Larga', 'it': 'Pokémon Lungacoda', 'en': 'Long Tail Pokémon', 'ja': 'おながポケモン', 'zh-Hans': '长尾宝可梦'}}
	public class SpecieAmbipom : PokemonSpecie
	{
#nullable enable
		private static SpecieAmbipom? _instance = null;
#nullable restore
        public static SpecieAmbipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmbipom();
                }
                return _instance;
            }
        }

		public SpecieAmbipom() : base(
			"Ambipom",
			75, // HPs
			100, 66, // Attack & Defense
			60, 66, // Special Attack & Defense
			115			
		) {}
	}


	//Ambipom Pokemon Class
	public class Ambipom : Pokemon
	{

		public Ambipom(string nickname, int level)
		: base(
				424,
				SpecieAmbipom.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ambipom(int level)
		: base(
				424,
				SpecieAmbipom.Instance, // Pokemon Specie
				"Ambipom", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ambipom() : base(
			424,
			SpecieAmbipom.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}