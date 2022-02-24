using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crabominable Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'iron-fist', 'anger-point'], 'base_experience': 167, 'height': 17, 'id': 740, 'moves': ['ice-punch', 'leer', 'ice-beam', 'blizzard', 'bubble-beam', 'earthquake', 'toxic', 'double-team', 'bubble', 'dizzy-punch', 'rest', 'rock-slide', 'substitute', 'thief', 'reversal', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'hail', 'facade', 'brick-break', 'rock-tomb', 'iron-defense', 'bulk-up', 'close-combat', 'payback', 'fling', 'focus-blast', 'giga-impact', 'avalanche', 'stone-edge', 'round', 'scald', 'bulldoze', 'frost-breath', 'work-up', 'confide', 'power-up-punch', 'ice-hammer', 'brutal-swing'], 'name': 'crabominable', 'stats': {'hp': 97, 'attack': 132, 'defense': 77, 'special-attack': 62, 'special-defense': 67, 'speed': 43}, 'types': ['fighting', 'ice'], 'weight': 1800, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'white', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'ケケンカニ', 'ko': '모단단게', 'zh-Hant': '好勝毛蟹', 'fr': 'Crabominable', 'de': 'Krawell', 'es': 'Crabominable', 'it': 'Crabominable', 'en': 'Crabominable', 'ja': 'ケケンカニ', 'zh-Hans': '好胜毛蟹'}, 'genera': {'ja-Hrkt': 'けがにポケモン', 'ko': '털게포켓몬', 'zh-Hant': '毛蟹寶可夢', 'fr': 'Pokémon Crabe Velu', 'de': 'Fellkrabbe', 'es': 'Pokémon Cangrejopelo', 'it': 'Pokémon Peligranchio', 'en': 'Woolly Crab Pokémon', 'ja': 'けがにポケモン', 'zh-Hans': '毛蟹宝可梦'}}
	public class SpecieCrabominable : PokemonSpecie
	{
#nullable enable
		private static SpecieCrabominable? _instance = null;
#nullable restore
        public static SpecieCrabominable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrabominable();
                }
                return _instance;
            }
        }

		public SpecieCrabominable() : base(
			"Crabominable",
			97, // HPs
			132, 77, // Attack & Defense
			62, 67, // Special Attack & Defense
			43			
		) {}
	}


	//Crabominable Pokemon Class
	public class Crabominable : Pokemon
	{

		public Crabominable(string nickname, int level)
		: base(
				740,
				SpecieCrabominable.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crabominable() : base(
			740,
			SpecieCrabominable.Instance, // Pokemon Specie
			Fighting.Instance, Ice.Instance			
		) {}
	}
}